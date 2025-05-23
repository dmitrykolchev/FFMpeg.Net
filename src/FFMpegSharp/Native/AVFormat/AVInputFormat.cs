namespace FFMpegSharp.Native
{
    public unsafe partial struct AVInputFormat
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* long_name;

        public int flags;

        [NativeTypeName("const char *")]
        public sbyte* extensions;

        [NativeTypeName("const struct AVCodecTag *const *")]
        public AVCodecTag** codec_tag;

        [NativeTypeName("const AVClass *")]
        public AVClass* priv_class;

        [NativeTypeName("const char *")]
        public sbyte* mime_type;

        public int raw_codec_id;

        public int priv_data_size;

        public int flags_internal;

        [NativeTypeName("int (*)(const AVProbeData *)")]
        public delegate* unmanaged[Cdecl]<AVProbeData*, int> read_probe;

        [NativeTypeName("int (*)(struct AVFormatContext *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> read_header;

        [NativeTypeName("int (*)(struct AVFormatContext *, AVPacket *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVPacket*, int> read_packet;

        [NativeTypeName("int (*)(struct AVFormatContext *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> read_close;

        [NativeTypeName("int (*)(struct AVFormatContext *, int, int64_t, int)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, long, int, int> read_seek;

        [NativeTypeName("int64_t (*)(struct AVFormatContext *, int, int64_t *, int64_t)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, long*, long, long> read_timestamp;

        [NativeTypeName("int (*)(struct AVFormatContext *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> read_play;

        [NativeTypeName("int (*)(struct AVFormatContext *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> read_pause;

        [NativeTypeName("int (*)(struct AVFormatContext *, int, int64_t, int64_t, int64_t, int)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, long, long, long, int, int> read_seek2;

        [NativeTypeName("int (*)(struct AVFormatContext *, struct AVDeviceInfoList *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVDeviceInfoList*, int> get_device_list;
    }
}
