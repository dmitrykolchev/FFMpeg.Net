
using FFMpegSharp.Native;
using System.Runtime.InteropServices;

namespace FFMpegSharp;

internal static class Program
{
    private static unsafe void Main(string[] args)
    {
        nint ptr = Marshal.StringToHGlobalAnsi(args.Length > 0 ? args[0] : "libx264");

        var avc = NativeApi.Instance;
        AVCodec* codec = avc.avcodec_find_encoder_by_name((sbyte*)ptr.ToPointer());
        AVCodecContext* c = avc.avcodec_alloc_context3(codec);
        AVPacket* pkt = avc.av_packet_alloc();

        /* put sample parameters */
        c->bit_rate = 400000;
        /* resolution must be a multiple of two */
        c->width = 352;
        c->height = 288;
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
            //avc.av_opt_set(c->priv_data, "preset", "slow", 0);
            Console.WriteLine("av_opt_set(c->priv_data, \"preset\", \"slow\", 0);");
        }

        int ret = avc.avcodec_open2(c, codec, null);




        sbyte* name = avc.avcodec_get_name(codec->id);
        string codecname = Marshal.PtrToStringAnsi(new nint(name));
        Console.WriteLine(codecname);

        Marshal.FreeHGlobal(ptr);
    }
}