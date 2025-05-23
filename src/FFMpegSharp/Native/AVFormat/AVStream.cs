using System;

namespace FFMpegSharp.Native
{
    public unsafe partial struct AVStream
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        public int index;

        public int id;

        public AVCodecParameters* codecpar;

        public void* priv_data;

        public AVRational time_base;

        [NativeTypeName("int64_t")]
        public long start_time;

        [NativeTypeName("int64_t")]
        public long duration;

        [NativeTypeName("int64_t")]
        public long nb_frames;

        public int disposition;

        [NativeTypeName("enum AVDiscard")]
        public AVDiscard discard;

        public AVRational sample_aspect_ratio;

        public AVDictionary* metadata;

        public AVRational avg_frame_rate;

        public AVPacket attached_pic;

        [Obsolete]
        public AVPacketSideData* side_data;

        [Obsolete]
        public int nb_side_data;

        public int event_flags;

        public AVRational r_frame_rate;

        public int pts_wrap_bits;
    }
}
