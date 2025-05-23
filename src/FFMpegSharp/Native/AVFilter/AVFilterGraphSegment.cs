namespace FFMpegSharp.Native
{
    public unsafe partial struct AVFilterGraphSegment
    {
        public AVFilterGraph* graph;

        public AVFilterChain** chains;

        [NativeTypeName("size_t")]
        public nuint nb_chains;

        [NativeTypeName("char *")]
        public sbyte* scale_sws_opts;
    }
}
