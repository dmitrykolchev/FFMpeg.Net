namespace FFMpegSharp.Native
{
    public unsafe partial struct AVFilterGraph
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        public AVFilterContext** filters;

        [NativeTypeName("unsigned int")]
        public uint nb_filters;

        [NativeTypeName("char *")]
        public sbyte* scale_sws_opts;

        public int thread_type;

        public int nb_threads;

        public AVFilterGraphInternal* @internal;

        public void* opaque;

        [NativeTypeName("avfilter_execute_func *")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, delegate* unmanaged[Cdecl]<AVFilterContext*, void*, int, int, int>, void*, int*, int, int> execute;

        [NativeTypeName("char *")]
        public sbyte* aresample_swr_opts;

        public AVFilterLink** sink_links;

        public int sink_links_count;

        [NativeTypeName("unsigned int")]
        public uint disable_auto_convert;
    }
}
