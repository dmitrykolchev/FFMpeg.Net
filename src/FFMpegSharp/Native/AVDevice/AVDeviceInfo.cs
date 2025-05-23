namespace FFMpegSharp.Native
{
    public unsafe partial struct AVDeviceInfo
    {
        [NativeTypeName("char *")]
        public sbyte* device_name;

        [NativeTypeName("char *")]
        public sbyte* device_description;

        [NativeTypeName("enum AVMediaType *")]
        public AVMediaType* media_types;

        public int nb_media_types;
    }
}
