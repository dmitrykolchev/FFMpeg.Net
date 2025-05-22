namespace FFMpegSharp.Native
{
    public unsafe partial struct AVHWAccel
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID id;

        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat pix_fmt;

        public int capabilities;
    }
}
