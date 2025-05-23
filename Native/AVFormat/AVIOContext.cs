namespace FFMpegSharp.Native
{
    public unsafe partial struct AVIOContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        [NativeTypeName("unsigned char *")]
        public byte* buffer;

        public int buffer_size;

        [NativeTypeName("unsigned char *")]
        public byte* buf_ptr;

        [NativeTypeName("unsigned char *")]
        public byte* buf_end;

        public void* opaque;

        [NativeTypeName("int (*)(void *, uint8_t *, int)")]
        public delegate* unmanaged[Cdecl]<void*, byte*, int, int> read_packet;

        [NativeTypeName("int (*)(void *, uint8_t *, int)")]
        public delegate* unmanaged[Cdecl]<void*, byte*, int, int> write_packet;

        [NativeTypeName("int64_t (*)(void *, int64_t, int)")]
        public delegate* unmanaged[Cdecl]<void*, long, int, long> seek;

        [NativeTypeName("int64_t")]
        public long pos;

        public int eof_reached;

        public int error;

        public int write_flag;

        public int max_packet_size;

        public int min_packet_size;

        [NativeTypeName("unsigned long")]
        public uint checksum;

        [NativeTypeName("unsigned char *")]
        public byte* checksum_ptr;

        [NativeTypeName("unsigned long (*)(unsigned long, const uint8_t *, unsigned int)")]
        public delegate* unmanaged[Cdecl]<uint, byte*, uint, uint> update_checksum;

        [NativeTypeName("int (*)(void *, int)")]
        public delegate* unmanaged[Cdecl]<void*, int, int> read_pause;

        [NativeTypeName("int64_t (*)(void *, int, int64_t, int)")]
        public delegate* unmanaged[Cdecl]<void*, int, long, int, long> read_seek;

        public int seekable;

        public int direct;

        [NativeTypeName("const char *")]
        public sbyte* protocol_whitelist;

        [NativeTypeName("const char *")]
        public sbyte* protocol_blacklist;

        [NativeTypeName("int (*)(void *, uint8_t *, int, enum AVIODataMarkerType, int64_t)")]
        public delegate* unmanaged[Cdecl]<void*, byte*, int, AVIODataMarkerType, long, int> write_data_type;

        public int ignore_boundary_point;

        [NativeTypeName("unsigned char *")]
        public byte* buf_ptr_max;

        [NativeTypeName("int64_t")]
        public long bytes_read;

        [NativeTypeName("int64_t")]
        public long bytes_written;
    }
}
