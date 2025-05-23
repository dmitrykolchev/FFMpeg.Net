
using FFMpegSharp.Native;
using System.Runtime.InteropServices;

namespace FFMpegSharp;

internal static class Program
{
    private static readonly AVCodecNative avc = AVCodecNative.Instance;
    private static readonly AVUtilNative avu = AVUtilNative.Instance;

    private const int EAGAIN = 11;
    private static readonly int AVERROR_EOF = MKTAG((byte)'E', (byte)'O', (byte)'F', (byte)' ');

    private static int MKTAG(byte a, byte b, byte c, byte d)
    {
        return -(int)((uint)a | ((uint)b << 8) | ((uint)c << 16) | ((uint)d << 24));
    }

    private static int AVERROR(int error)
    {
        return -error;
    }


    private static unsafe void Main(string[] args)
    {
        nint ptr = Marshal.StringToHGlobalAnsi(args.Length > 0 ? args[0] : "libx264");

        AVCodec* codec = avc.avcodec_find_encoder_by_name((sbyte*)ptr.ToPointer());
        AVCodecContext* c = avc.avcodec_alloc_context3(codec);
        AVPacket* pkt = avc.av_packet_alloc();

        /* put sample parameters */
        c->bit_rate = 400000;
        /* resolution must be a multiple of two */
        c->width = 1920;
        c->height = 1080;
        /* frames per second */
        c->time_base = new AVRational { num = 1, den = 25 };
        c->framerate = new AVRational { num = 25, den = 1 };
        /* emit one intra frame every ten frames
         * check frame pict_type before passing frame
         * to encoder, if frame->pict_type is AV_PICTURE_TYPE_I
         * then gop_size is ignored and the output of encoder
         * will always be I frame irrespective to gop_size
         */
        c->gop_size = 10;
        c->max_b_frames = 1;
        c->pix_fmt = AVPixelFormat.AV_PIX_FMT_YUV420P;

        if (codec->id == AVCodecID.AV_CODEC_ID_H264)
        {
            nint presetPtr = Marshal.StringToHGlobalAnsi("preset");
            nint slowPtr = Marshal.StringToHGlobalAnsi("slow");
            int result = avu.av_opt_set(c->priv_data, (sbyte*)presetPtr, (sbyte*)slowPtr, 0);
            //Console.WriteLine("av_opt_set(c->priv_data, \"preset\", \"slow\", 0);");
        }

        int ret = avc.avcodec_open2(c, codec, null);

        string fileName = "test.264";

        AVFrame* frame = avu.av_frame_alloc();

        frame->format = (int)c->pix_fmt;
        frame->width = c->width;
        frame->height = c->height;

        ret = avu.av_frame_get_buffer(frame, 0);

        using (FileStream file = File.Create(fileName))
        {

            /* encode 1 second of video */
            for (int i = 0; i < 25; i++)
            {
                Console.Out.Flush();

                /* Make sure the frame data is writable.
                   On the first round, the frame is fresh from av_frame_get_buffer()
                   and therefore we know it is writable.
                   But on the next rounds, encode() will have called
                   avcodec_send_frame(), and the codec may have kept a reference to
                   the frame in its internal structures, that makes the frame
                   unwritable.
                   av_frame_make_writable() checks that and allocates a new buffer
                   for the frame only if necessary.
                 */
                ret = avu.av_frame_make_writable(frame);
                if (ret < 0)
                {
                    throw new InvalidOperationException();
                }

                /* Prepare a dummy image.
                   In real code, this is where you would have your own logic for
                   filling the frame. FFmpeg does not care what you put in the
                   frame.
                 */
                /* Y */
                for (int y = 0; y < c->height; y++)
                {
                    for (int x = 0; x < c->width; x++)
                    {
                        frame->data[0][(y * frame->linesize[0]) + x] = (byte)(x + y + (i * 3));
                    }
                }

                /* Cb and Cr */
                for (int y = 0; y < c->height / 2; y++)
                {
                    for (int x = 0; x < c->width / 2; x++)
                    {
                        frame->data[1][(y * frame->linesize[1]) + x] = (byte)(128 + y + (i * 2));
                        frame->data[2][(y * frame->linesize[2]) + x] = (byte)(64 + x + (i * 5));
                    }
                }

                frame->pts = i;

                /* encode the image */
                encode(c, frame, pkt, file);
            }

            /* flush the encoder */
            encode(c, null, pkt, file);

            /* Add sequence end code to have a real MPEG file.
               It makes only sense because this tiny examples writes packets
               directly. This is called "elementary stream" and only works for some
               codecs. To create a valid file, you usually need to write packets
               into a proper file format or protocol; see mux.c.
             */
            byte[] endcode = [0, 0, 1, 0xb7];
            if (codec->id == AVCodecID.AV_CODEC_ID_MPEG1VIDEO || codec->id == AVCodecID.AV_CODEC_ID_MPEG2VIDEO)
            {
                file.Write(endcode, 0, endcode.Length);
            }
        }

        avc.avcodec_free_context(&c);
        avu.av_frame_free(&frame);
        avc.av_packet_free(&pkt);
    }

    private static unsafe void encode(AVCodecContext* enc_ctx, AVFrame* frame, AVPacket* pkt, Stream stream)
    {
        int ret;

        /* send the frame to the encoder */
        if (frame is not null)
        {
            Console.WriteLine($"Send frame \"{frame->pts}\"");
        }

        ret = avc.avcodec_send_frame(enc_ctx, frame);
        if (ret < 0)
        {
            throw new InvalidOperationException("Error sending a frame for encoding");
        }

        while (ret >= 0)
        {
            ret = avc.avcodec_receive_packet(enc_ctx, pkt);
            if (ret == AVERROR(EAGAIN) || ret == AVERROR_EOF)
            {
                return;
            }
            else if (ret < 0)
            {
                throw new InvalidOperationException("Error during encoding");
            }

            Console.WriteLine($"Write packet {pkt->pts} (size={pkt->size})");
            stream.Write(new ReadOnlySpan<byte>(pkt->data, pkt->size));
            avc.av_packet_unref(pkt);
        }
    }
}