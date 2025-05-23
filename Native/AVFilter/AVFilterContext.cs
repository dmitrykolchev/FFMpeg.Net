namespace FFMpegSharp.Native
{
    public unsafe partial struct AVFilterContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        [NativeTypeName("const AVFilter *")]
        public AVFilter* filter;

        [NativeTypeName("char *")]
        public sbyte* name;

        public AVFilterPad* input_pads;

        public AVFilterLink** inputs;

        [NativeTypeName("unsigned int")]
        public uint nb_inputs;

        public AVFilterPad* output_pads;

        public AVFilterLink** outputs;

        [NativeTypeName("unsigned int")]
        public uint nb_outputs;

        public void* priv;

        [NativeTypeName("struct AVFilterGraph *")]
        public AVFilterGraph* graph;

        public int thread_type;

        public AVFilterInternal* @internal;

        [NativeTypeName("struct AVFilterCommand *")]
        public AVFilterCommand* command_queue;

        [NativeTypeName("char *")]
        public sbyte* enable_str;

        public void* enable;

        public double* var_values;

        public int is_disabled;

        public AVBufferRef* hw_device_ctx;

        public int nb_threads;

        [NativeTypeName("unsigned int")]
        public uint ready;

        public int extra_hw_frames;

        public partial struct AVFilterCommand
        {
        }
    }
}
