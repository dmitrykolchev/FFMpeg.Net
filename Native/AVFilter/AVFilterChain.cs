namespace FFMpegSharp.Native
{
    public unsafe partial struct AVFilterChain
    {
        public AVFilterParams** filters;

        [NativeTypeName("size_t")]
        public nuint nb_filters;
    }
}
