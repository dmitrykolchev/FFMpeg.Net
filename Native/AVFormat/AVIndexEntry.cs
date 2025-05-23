namespace FFMpegSharp.Native
{
    public partial struct AVIndexEntry
    {
        [NativeTypeName("int64_t")]
        public long pos;

        [NativeTypeName("int64_t")]
        public long timestamp;

        public int _bitfield;

        [NativeTypeName("int : 2")]
        public int flags
        {
            readonly get
            {
                return (_bitfield << 30) >> 30;
            }

            set
            {
                _bitfield = (_bitfield & ~0x3) | (value & 0x3);
            }
        }

        [NativeTypeName("int : 30")]
        public int size
        {
            readonly get
            {
                return (_bitfield << 0) >> 2;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFFF << 2)) | ((value & 0x3FFFFFFF) << 2);
            }
        }

        public int min_distance;
    }
}
