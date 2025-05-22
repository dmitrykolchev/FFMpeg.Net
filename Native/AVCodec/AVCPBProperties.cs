namespace FFMpegSharp.Native
{
    public partial struct AVCPBProperties
    {
        [NativeTypeName("int64_t")]
        public long max_bitrate;

        [NativeTypeName("int64_t")]
        public long min_bitrate;

        [NativeTypeName("int64_t")]
        public long avg_bitrate;

        [NativeTypeName("int64_t")]
        public long buffer_size;

        [NativeTypeName("uint64_t")]
        public ulong vbv_delay;
    }
}
