using System;

namespace FFMpegSharp.Native
{
    public unsafe partial struct AVCodec
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* long_name;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID id;

        public int capabilities;

        [NativeTypeName("uint8_t")]
        public byte max_lowres;

        [NativeTypeName("const AVRational *")]
        public AVRational* supported_framerates;

        [NativeTypeName("const enum AVPixelFormat *")]
        public AVPixelFormat* pix_fmts;

        [NativeTypeName("const int *")]
        public int* supported_samplerates;

        [NativeTypeName("const enum AVSampleFormat *")]
        public AVSampleFormat* sample_fmts;

        [NativeTypeName("const uint64_t *")]
        [Obsolete]
        public ulong* channel_layouts;

        [NativeTypeName("const AVClass *")]
        public AVClass* priv_class;

        [NativeTypeName("const AVProfile *")]
        public AVProfile* profiles;

        [NativeTypeName("const char *")]
        public sbyte* wrapper_name;

        [NativeTypeName("const AVChannelLayout *")]
        public AVChannelLayout* ch_layouts;
    }
}
