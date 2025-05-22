namespace FFMpegSharp.Native
{
    public unsafe partial struct AVFrameSideData
    {
        [NativeTypeName("enum AVFrameSideDataType")]
        public AVFrameSideDataType type;

        [NativeTypeName("uint8_t *")]
        public byte* data;

        [NativeTypeName("size_t")]
        public nuint size;

        public AVDictionary* metadata;

        public AVBufferRef* buf;
    }
}
