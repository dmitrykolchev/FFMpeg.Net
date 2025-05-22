namespace FFMpegSharp.Native
{
    public unsafe partial struct AVCodecParser
    {
        [NativeTypeName("int[7]")]
        public fixed int codec_ids[7];

        public int priv_data_size;

        [NativeTypeName("int (*)(AVCodecParserContext *)")]
        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, int> parser_init;

        [NativeTypeName("int (*)(AVCodecParserContext *, AVCodecContext *, const uint8_t **, int *, const uint8_t *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, AVCodecContext*, byte**, int*, byte*, int, int> parser_parse;

        [NativeTypeName("void (*)(AVCodecParserContext *)")]
        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, void> parser_close;

        [NativeTypeName("int (*)(AVCodecContext *, const uint8_t *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, byte*, int, int> split;
    }
}
