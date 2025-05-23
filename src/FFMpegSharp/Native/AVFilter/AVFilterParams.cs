namespace FFMpegSharp.Native
{
    public unsafe partial struct AVFilterParams
    {
        public AVFilterContext* filter;

        [NativeTypeName("char *")]
        public sbyte* filter_name;

        [NativeTypeName("char *")]
        public sbyte* instance_name;

        public AVDictionary* opts;

        public AVFilterPadParams** inputs;

        [NativeTypeName("unsigned int")]
        public uint nb_inputs;

        public AVFilterPadParams** outputs;

        [NativeTypeName("unsigned int")]
        public uint nb_outputs;
    }
}
