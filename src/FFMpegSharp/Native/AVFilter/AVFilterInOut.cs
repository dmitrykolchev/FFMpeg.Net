namespace FFMpegSharp.Native
{
    public unsafe partial struct AVFilterInOut
    {
        [NativeTypeName("char *")]
        public sbyte* name;

        public AVFilterContext* filter_ctx;

        public int pad_idx;

        [NativeTypeName("struct AVFilterInOut *")]
        public AVFilterInOut* next;
    }
}
