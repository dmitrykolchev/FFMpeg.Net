namespace FFMpegSharp.Native
{
    public unsafe partial struct AVIODirContext
    {
        [NativeTypeName("struct URLContext *")]
        public URLContext* url_context;

        public partial struct URLContext
        {
        }
    }
}
