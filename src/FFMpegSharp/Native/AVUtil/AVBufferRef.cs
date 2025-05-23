namespace FFMpegSharp.Native
{
    public unsafe partial struct AVBufferRef
    {
        public AVBuffer* buffer;

        [NativeTypeName("uint8_t *")]
        public byte* data;

        [NativeTypeName("size_t")]
        public nuint size;
    }
}
