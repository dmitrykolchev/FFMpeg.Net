namespace FFMpegSharp.Native
{
    public unsafe partial struct AVOutputFormat
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* long_name;

        [NativeTypeName("const char *")]
        public sbyte* mime_type;

        [NativeTypeName("const char *")]
        public sbyte* extensions;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID audio_codec;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID video_codec;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID subtitle_codec;

        public int flags;

        [NativeTypeName("const struct AVCodecTag *const *")]
        public AVCodecTag** codec_tag;

        [NativeTypeName("const AVClass *")]
        public AVClass* priv_class;
    }
}
