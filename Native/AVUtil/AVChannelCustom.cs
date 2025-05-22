namespace FFMpegSharp.Native
{
    public unsafe partial struct AVChannelCustom
    {
        [NativeTypeName("enum AVChannel")]
        public AVChannel id;

        [NativeTypeName("char[16]")]
        public fixed sbyte name[16];

        public void* opaque;
    }
}
