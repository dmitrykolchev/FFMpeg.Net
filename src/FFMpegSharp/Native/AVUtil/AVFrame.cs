using System;

namespace FFMpegSharp.Native
{
    public unsafe partial struct AVFrame
    {
        [NativeTypeName("uint8_t *[8]")]
        public _data_e__FixedBuffer data;

        [NativeTypeName("int[8]")]
        public fixed int linesize[8];

        [NativeTypeName("uint8_t **")]
        public byte** extended_data;

        public int width;

        public int height;

        public int nb_samples;

        public int format;

        [Obsolete]
        public int key_frame;

        [NativeTypeName("enum AVPictureType")]
        public AVPictureType pict_type;

        public AVRational sample_aspect_ratio;

        [NativeTypeName("int64_t")]
        public long pts;

        [NativeTypeName("int64_t")]
        public long pkt_dts;

        public AVRational time_base;

        [Obsolete]
        public int coded_picture_number;

        [Obsolete]
        public int display_picture_number;

        public int quality;

        public void* opaque;

        public int repeat_pict;

        [Obsolete]
        public int interlaced_frame;

        [Obsolete]
        public int top_field_first;

        [Obsolete]
        public int palette_has_changed;

        [NativeTypeName("int64_t")]
        [Obsolete]
        public long reordered_opaque;

        public int sample_rate;

        [NativeTypeName("uint64_t")]
        [Obsolete]
        public ulong channel_layout;

        [NativeTypeName("AVBufferRef *[8]")]
        public _buf_e__FixedBuffer buf;

        public AVBufferRef** extended_buf;

        public int nb_extended_buf;

        public AVFrameSideData** side_data;

        public int nb_side_data;

        public int flags;

        [NativeTypeName("enum AVColorRange")]
        public AVColorRange color_range;

        [NativeTypeName("enum AVColorPrimaries")]
        public AVColorPrimaries color_primaries;

        [NativeTypeName("enum AVColorTransferCharacteristic")]
        public AVColorTransferCharacteristic color_trc;

        [NativeTypeName("enum AVColorSpace")]
        public AVColorSpace colorspace;

        [NativeTypeName("enum AVChromaLocation")]
        public AVChromaLocation chroma_location;

        [NativeTypeName("int64_t")]
        public long best_effort_timestamp;

        [NativeTypeName("int64_t")]
        [Obsolete]
        public long pkt_pos;

        [NativeTypeName("int64_t")]
        [Obsolete]
        public long pkt_duration;

        public AVDictionary* metadata;

        public int decode_error_flags;

        [Obsolete]
        public int channels;

        [Obsolete]
        public int pkt_size;

        public AVBufferRef* hw_frames_ctx;

        public AVBufferRef* opaque_ref;

        [NativeTypeName("size_t")]
        public nuint crop_top;

        [NativeTypeName("size_t")]
        public nuint crop_bottom;

        [NativeTypeName("size_t")]
        public nuint crop_left;

        [NativeTypeName("size_t")]
        public nuint crop_right;

        public AVBufferRef* private_ref;

        public AVChannelLayout ch_layout;

        [NativeTypeName("int64_t")]
        public long duration;

        public unsafe partial struct _data_e__FixedBuffer
        {
            public byte* e0;
            public byte* e1;
            public byte* e2;
            public byte* e3;
            public byte* e4;
            public byte* e5;
            public byte* e6;
            public byte* e7;

            public ref byte* this[int index]
            {
                get
                {
                    fixed (byte** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public unsafe partial struct _buf_e__FixedBuffer
        {
            public AVBufferRef* e0;
            public AVBufferRef* e1;
            public AVBufferRef* e2;
            public AVBufferRef* e3;
            public AVBufferRef* e4;
            public AVBufferRef* e5;
            public AVBufferRef* e6;
            public AVBufferRef* e7;

            public ref AVBufferRef* this[int index]
            {
                get
                {
                    fixed (AVBufferRef** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
