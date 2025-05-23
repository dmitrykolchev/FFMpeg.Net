using System;

namespace FFMpegSharp.Native
{
    public unsafe partial struct AVBufferSrcParameters
    {
        public int format;

        public AVRational time_base;

        public int width;

        public int height;

        public AVRational sample_aspect_ratio;

        public AVRational frame_rate;

        public AVBufferRef* hw_frames_ctx;

        public int sample_rate;

        [NativeTypeName("uint64_t")]
        [Obsolete]
        public ulong channel_layout;

        public AVChannelLayout ch_layout;
    }
}
