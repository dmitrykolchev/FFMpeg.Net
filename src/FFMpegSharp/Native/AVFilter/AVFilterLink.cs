using System;

namespace FFMpegSharp.Native
{
    public unsafe partial struct AVFilterLink
    {
        public AVFilterContext* src;

        public AVFilterPad* srcpad;

        public AVFilterContext* dst;

        public AVFilterPad* dstpad;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        public int w;

        public int h;

        public AVRational sample_aspect_ratio;

        [NativeTypeName("uint64_t")]
        [Obsolete]
        public ulong channel_layout;

        public int sample_rate;

        public int format;

        public AVRational time_base;

        public AVChannelLayout ch_layout;

        public AVFilterFormatsConfig incfg;

        public AVFilterFormatsConfig outcfg;

        [NativeTypeName("__AnonymousEnum_avfilter_L587_C5")]
        public int init_state;

        [NativeTypeName("struct AVFilterGraph *")]
        public AVFilterGraph* graph;

        [NativeTypeName("int64_t")]
        public long current_pts;

        [NativeTypeName("int64_t")]
        public long current_pts_us;

        public int age_index;

        public AVRational frame_rate;

        public int min_samples;

        public int max_samples;

        [NativeTypeName("int64_t")]
        public long frame_count_in;

        [NativeTypeName("int64_t")]
        public long frame_count_out;

        [NativeTypeName("int64_t")]
        public long sample_count_in;

        [NativeTypeName("int64_t")]
        public long sample_count_out;

        public void* frame_pool;

        public int frame_wanted_out;

        public AVBufferRef* hw_frames_ctx;

        [NativeTypeName("char[61440]")]
        public fixed sbyte reserved[61440];

        public const int AVLINK_UNINIT = 0;
        public const int AVLINK_STARTINIT = 1;
        public const int AVLINK_INIT = 2;
    }
}
