namespace FFMpegSharp.Native
{
    public unsafe partial struct AVPacketSideData
    {
        [NativeTypeName("uint8_t *")]
        public byte* data;

        [NativeTypeName("size_t")]
        public nuint size;

        [NativeTypeName("enum AVPacketSideDataType")]
        public AVPacketSideDataType type;
    }
}
