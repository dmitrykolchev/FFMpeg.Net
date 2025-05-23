namespace FFMpegSharp.Native
{
    public unsafe partial struct AVChapter
    {
        [NativeTypeName("int64_t")]
        public long id;

        public AVRational time_base;

        [NativeTypeName("int64_t")]
        public long start;

        [NativeTypeName("int64_t")]
        public long end;

        public AVDictionary* metadata;
    }
}
