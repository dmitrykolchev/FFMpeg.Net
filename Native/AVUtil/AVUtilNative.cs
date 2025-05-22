using System;

namespace FFMpegSharp.Native
{
    public unsafe partial class AVUtilNative
    {
        public delegate* unmanaged[Cdecl]<AVAES*> av_aes_alloc;

        public delegate* unmanaged[Cdecl]<AVAES*, byte*, int, int, int> av_aes_init;

        public delegate* unmanaged[Cdecl]<AVAES*, byte*, byte*, int, byte*, int, void> av_aes_crypt;

        public delegate* unmanaged[Cdecl]<AVAESCTR*> av_aes_ctr_alloc;

        public delegate* unmanaged[Cdecl]<AVAESCTR*, byte*, int> av_aes_ctr_init;

        public delegate* unmanaged[Cdecl]<AVAESCTR*, void> av_aes_ctr_free;

        public delegate* unmanaged[Cdecl]<AVAESCTR*, byte*, byte*, int, void> av_aes_ctr_crypt;

        public delegate* unmanaged[Cdecl]<AVAESCTR*, byte*> av_aes_ctr_get_iv;

        public delegate* unmanaged[Cdecl]<AVAESCTR*, void> av_aes_ctr_set_random_iv;

        public delegate* unmanaged[Cdecl]<AVAESCTR*, byte*, void> av_aes_ctr_set_iv;

        public delegate* unmanaged[Cdecl]<AVAESCTR*, byte*, void> av_aes_ctr_set_full_iv;

        public delegate* unmanaged[Cdecl]<AVAESCTR*, void> av_aes_ctr_increment_iv;

        public delegate* unmanaged[Cdecl]<uint> avutil_version;

        public delegate* unmanaged[Cdecl]<sbyte*> av_version_info;

        public delegate* unmanaged[Cdecl]<sbyte*> avutil_configuration;

        public delegate* unmanaged[Cdecl]<sbyte*> avutil_license;

        public delegate* unmanaged[Cdecl]<AVMediaType, sbyte*> av_get_media_type_string;

        public delegate* unmanaged[Cdecl]<AVPictureType, sbyte> av_get_picture_type_char;

        public static void* av_x_if_null([NativeTypeName("const void *")] void* p, [NativeTypeName("const void *")] void* x)
        {
            return (void*)(unchecked((nint)((p) != null ? p : x)));
        }

        public delegate* unmanaged[Cdecl]<uint, void*, ulong, uint> av_int_list_length_for_size;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<sbyte*, sbyte*, void*> av_fopen_utf8;

        public delegate* unmanaged[Cdecl]<AVRational> av_get_time_base_q;

        public delegate* unmanaged[Cdecl]<sbyte*, uint, sbyte*> av_fourcc_make_string;

        public delegate* unmanaged[Cdecl]<AVSampleFormat, sbyte*> av_get_sample_fmt_name;

        public delegate* unmanaged[Cdecl]<sbyte*, AVSampleFormat> av_get_sample_fmt;

        public delegate* unmanaged[Cdecl]<AVSampleFormat, int, AVSampleFormat> av_get_alt_sample_fmt;

        public delegate* unmanaged[Cdecl]<AVSampleFormat, AVSampleFormat> av_get_packed_sample_fmt;

        public delegate* unmanaged[Cdecl]<AVSampleFormat, AVSampleFormat> av_get_planar_sample_fmt;

        public delegate* unmanaged[Cdecl]<sbyte*, int, AVSampleFormat, sbyte*> av_get_sample_fmt_string;

        public delegate* unmanaged[Cdecl]<AVSampleFormat, int> av_get_bytes_per_sample;

        public delegate* unmanaged[Cdecl]<AVSampleFormat, int> av_sample_fmt_is_planar;

        public delegate* unmanaged[Cdecl]<int*, int, int, AVSampleFormat, int, int> av_samples_get_buffer_size;

        public delegate* unmanaged[Cdecl]<byte**, int*, byte*, int, int, AVSampleFormat, int, int> av_samples_fill_arrays;

        public delegate* unmanaged[Cdecl]<byte**, int*, int, int, AVSampleFormat, int, int> av_samples_alloc;

        public delegate* unmanaged[Cdecl]<byte***, int*, int, int, AVSampleFormat, int, int> av_samples_alloc_array_and_samples;

        public delegate* unmanaged[Cdecl]<byte**, byte**, int, int, int, int, AVSampleFormat, int> av_samples_copy;

        public delegate* unmanaged[Cdecl]<byte**, int, int, int, AVSampleFormat, int> av_samples_set_silence;

        public delegate* unmanaged[Cdecl]<nuint, AVBufferRef*> av_buffer_alloc;

        public delegate* unmanaged[Cdecl]<nuint, AVBufferRef*> av_buffer_allocz;

        public delegate* unmanaged[Cdecl]<byte*, nuint, delegate* unmanaged[Cdecl]<void*, byte*, void>, void*, int, AVBufferRef*> av_buffer_create;

        public delegate* unmanaged[Cdecl]<void*, byte*, void> av_buffer_default_free;

        public delegate* unmanaged[Cdecl]<AVBufferRef*, AVBufferRef*> av_buffer_ref;

        public delegate* unmanaged[Cdecl]<AVBufferRef**, void> av_buffer_unref;

        public delegate* unmanaged[Cdecl]<AVBufferRef*, int> av_buffer_is_writable;

        public delegate* unmanaged[Cdecl]<AVBufferRef*, void*> av_buffer_get_opaque;

        public delegate* unmanaged[Cdecl]<AVBufferRef*, int> av_buffer_get_ref_count;

        public delegate* unmanaged[Cdecl]<AVBufferRef**, int> av_buffer_make_writable;

        public delegate* unmanaged[Cdecl]<AVBufferRef**, nuint, int> av_buffer_realloc;

        public delegate* unmanaged[Cdecl]<AVBufferRef**, AVBufferRef*, int> av_buffer_replace;

        public delegate* unmanaged[Cdecl]<nuint, delegate* unmanaged[Cdecl]<nuint, AVBufferRef*>, AVBufferPool*> av_buffer_pool_init;

        public delegate* unmanaged[Cdecl]<nuint, void*, delegate* unmanaged[Cdecl]<void*, nuint, AVBufferRef*>, delegate* unmanaged[Cdecl]<void*, void>, AVBufferPool*> av_buffer_pool_init2;

        public delegate* unmanaged[Cdecl]<AVBufferPool**, void> av_buffer_pool_uninit;

        public delegate* unmanaged[Cdecl]<AVBufferPool*, AVBufferRef*> av_buffer_pool_get;

        public delegate* unmanaged[Cdecl]<AVBufferRef*, void*> av_buffer_pool_buffer_get_opaque;

        public delegate* unmanaged[Cdecl]<void*, void*, int, int, int> av_opt_show2;

        public delegate* unmanaged[Cdecl]<void*, void> av_opt_set_defaults;

        public delegate* unmanaged[Cdecl]<void*, int, int, void> av_opt_set_defaults2;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, sbyte*, int> av_set_options_string;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte**, sbyte*, sbyte*, int> av_opt_set_from_string;

        public delegate* unmanaged[Cdecl]<void*, void> av_opt_free;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, int> av_opt_flag_is_set;

        public delegate* unmanaged[Cdecl]<void*, AVDictionary**, int> av_opt_set_dict;

        public delegate* unmanaged[Cdecl]<void*, AVDictionary**, int, int> av_opt_set_dict2;

        public delegate* unmanaged[Cdecl]<sbyte**, sbyte*, sbyte*, uint, sbyte**, sbyte**, int> av_opt_get_key_value;

        public const int AV_OPT_FLAG_IMPLICIT_KEY = 1;

        public delegate* unmanaged[Cdecl]<void*, AVOption*, sbyte*, int*, int> av_opt_eval_flags;

        public delegate* unmanaged[Cdecl]<void*, AVOption*, sbyte*, int*, int> av_opt_eval_int;

        public delegate* unmanaged[Cdecl]<void*, AVOption*, sbyte*, long*, int> av_opt_eval_int64;

        public delegate* unmanaged[Cdecl]<void*, AVOption*, sbyte*, float*, int> av_opt_eval_float;

        public delegate* unmanaged[Cdecl]<void*, AVOption*, sbyte*, double*, int> av_opt_eval_double;

        public delegate* unmanaged[Cdecl]<void*, AVOption*, sbyte*, AVRational*, int> av_opt_eval_q;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, int, int, AVOption*> av_opt_find;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, int, int, void**, AVOption*> av_opt_find2;

        public delegate* unmanaged[Cdecl]<void*, AVOption*, AVOption*> av_opt_next;

        public delegate* unmanaged[Cdecl]<void*, void*, void*> av_opt_child_next;

        public delegate* unmanaged[Cdecl]<AVClass*, void**, AVClass*> av_opt_child_class_iterate;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, int, int> av_opt_set;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, long, int, int> av_opt_set_int;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, double, int, int> av_opt_set_double;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, AVRational, int, int> av_opt_set_q;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, byte*, int, int, int> av_opt_set_bin;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, int, int, int, int> av_opt_set_image_size;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, AVPixelFormat, int, int> av_opt_set_pixel_fmt;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, AVSampleFormat, int, int> av_opt_set_sample_fmt;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, AVRational, int, int> av_opt_set_video_rate;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<void*, sbyte*, long, int, int> av_opt_set_channel_layout;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, AVChannelLayout*, int, int> av_opt_set_chlayout;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, AVDictionary*, int, int> av_opt_set_dict_val;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, int, byte**, int> av_opt_get;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, int, long*, int> av_opt_get_int;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, int, double*, int> av_opt_get_double;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, int, AVRational*, int> av_opt_get_q;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, int, int*, int*, int> av_opt_get_image_size;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, int, AVPixelFormat*, int> av_opt_get_pixel_fmt;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, int, AVSampleFormat*, int> av_opt_get_sample_fmt;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, int, AVRational*, int> av_opt_get_video_rate;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<void*, sbyte*, int, long*, int> av_opt_get_channel_layout;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, int, AVChannelLayout*, int> av_opt_get_chlayout;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, int, AVDictionary**, int> av_opt_get_dict_val;

        public delegate* unmanaged[Cdecl]<AVClass*, void*, sbyte*, void*> av_opt_ptr;

        public delegate* unmanaged[Cdecl]<AVOptionRanges**, void> av_opt_freep_ranges;

        public delegate* unmanaged[Cdecl]<AVOptionRanges**, void*, sbyte*, int, int> av_opt_query_ranges;

        public delegate* unmanaged[Cdecl]<void*, void*, int> av_opt_copy;

        public delegate* unmanaged[Cdecl]<AVOptionRanges**, void*, sbyte*, int, int> av_opt_query_ranges_default;

        public delegate* unmanaged[Cdecl]<void*, AVOption*, int> av_opt_is_set_to_default;

        public delegate* unmanaged[Cdecl]<void*, sbyte*, int, int> av_opt_is_set_to_default_by_name;

        public delegate* unmanaged[Cdecl]<void*, int, int, sbyte**, sbyte, sbyte, int> av_opt_serialize;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<sbyte*, ulong> av_get_channel_layout;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<sbyte*, ulong*, int*, int> av_get_extended_channel_layout;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<sbyte*, int, int, ulong, void> av_get_channel_layout_string;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVBPrint*, int, ulong, void> av_bprint_channel_layout;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<ulong, int> av_get_channel_layout_nb_channels;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<int, long> av_get_default_channel_layout;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<ulong, ulong, int> av_get_channel_layout_channel_index;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<ulong, int, ulong> av_channel_layout_extract_channel;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<ulong, sbyte*> av_get_channel_name;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<ulong, sbyte*> av_get_channel_description;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<uint, ulong*, sbyte**, int> av_get_standard_channel_layout;

        public delegate* unmanaged[Cdecl]<sbyte*, nuint, AVChannel, int> av_channel_name;

        public delegate* unmanaged[Cdecl]<AVBPrint*, AVChannel, void> av_channel_name_bprint;

        public delegate* unmanaged[Cdecl]<sbyte*, nuint, AVChannel, int> av_channel_description;

        public delegate* unmanaged[Cdecl]<AVBPrint*, AVChannel, void> av_channel_description_bprint;

        public delegate* unmanaged[Cdecl]<sbyte*, AVChannel> av_channel_from_string;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, ulong, int> av_channel_layout_from_mask;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, sbyte*, int> av_channel_layout_from_string;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, int, void> av_channel_layout_default;

        public delegate* unmanaged[Cdecl]<void**, AVChannelLayout*> av_channel_layout_standard;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, void> av_channel_layout_uninit;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, AVChannelLayout*, int> av_channel_layout_copy;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, sbyte*, nuint, int> av_channel_layout_describe;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, AVBPrint*, int> av_channel_layout_describe_bprint;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, uint, AVChannel> av_channel_layout_channel_from_index;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, AVChannel, int> av_channel_layout_index_from_channel;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, sbyte*, int> av_channel_layout_index_from_string;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, sbyte*, AVChannel> av_channel_layout_channel_from_string;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, ulong, ulong> av_channel_layout_subset;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, int> av_channel_layout_check;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, AVChannelLayout*, int> av_channel_layout_compare;

        public delegate* unmanaged[Cdecl]<AVDictionary*, sbyte*, AVDictionaryEntry*, int, AVDictionaryEntry*> av_dict_get;

        public delegate* unmanaged[Cdecl]<AVDictionary*, AVDictionaryEntry*, AVDictionaryEntry*> av_dict_iterate;

        public delegate* unmanaged[Cdecl]<AVDictionary*, int> av_dict_count;

        public delegate* unmanaged[Cdecl]<AVDictionary**, sbyte*, sbyte*, int, int> av_dict_set;

        public delegate* unmanaged[Cdecl]<AVDictionary**, sbyte*, long, int, int> av_dict_set_int;

        public delegate* unmanaged[Cdecl]<AVDictionary**, sbyte*, sbyte*, sbyte*, int, int> av_dict_parse_string;

        public delegate* unmanaged[Cdecl]<AVDictionary**, AVDictionary*, int, int> av_dict_copy;

        public delegate* unmanaged[Cdecl]<AVDictionary**, void> av_dict_free;

        public delegate* unmanaged[Cdecl]<AVDictionary*, sbyte**, sbyte, sbyte, int> av_dict_get_string;

        public delegate* unmanaged[Cdecl]<AVFrame*> av_frame_alloc;

        public delegate* unmanaged[Cdecl]<AVFrame**, void> av_frame_free;

        public delegate* unmanaged[Cdecl]<AVFrame*, AVFrame*, int> av_frame_ref;

        public delegate* unmanaged[Cdecl]<AVFrame*, AVFrame*, int> av_frame_replace;

        public delegate* unmanaged[Cdecl]<AVFrame*, AVFrame*> av_frame_clone;

        public delegate* unmanaged[Cdecl]<AVFrame*, void> av_frame_unref;

        public delegate* unmanaged[Cdecl]<AVFrame*, AVFrame*, void> av_frame_move_ref;

        public delegate* unmanaged[Cdecl]<AVFrame*, int, int> av_frame_get_buffer;

        public delegate* unmanaged[Cdecl]<AVFrame*, int> av_frame_is_writable;

        public delegate* unmanaged[Cdecl]<AVFrame*, int> av_frame_make_writable;

        public delegate* unmanaged[Cdecl]<AVFrame*, AVFrame*, int> av_frame_copy;

        public delegate* unmanaged[Cdecl]<AVFrame*, AVFrame*, int> av_frame_copy_props;

        public delegate* unmanaged[Cdecl]<AVFrame*, int, AVBufferRef*> av_frame_get_plane_buffer;

        public delegate* unmanaged[Cdecl]<AVFrame*, AVFrameSideDataType, nuint, AVFrameSideData*> av_frame_new_side_data;

        public delegate* unmanaged[Cdecl]<AVFrame*, AVFrameSideDataType, AVBufferRef*, AVFrameSideData*> av_frame_new_side_data_from_buf;

        public delegate* unmanaged[Cdecl]<AVFrame*, AVFrameSideDataType, AVFrameSideData*> av_frame_get_side_data;

        public delegate* unmanaged[Cdecl]<AVFrame*, AVFrameSideDataType, void> av_frame_remove_side_data;

        public const int AV_FRAME_CROP_UNALIGNED = 1 << 0;

        public delegate* unmanaged[Cdecl]<AVFrame*, int, int> av_frame_apply_cropping;

        public delegate* unmanaged[Cdecl]<AVFrameSideDataType, sbyte*> av_frame_side_data_name;

        public delegate* unmanaged[Cdecl]<void*, int, sbyte*, sbyte*, void> av_vlog;

        public delegate* unmanaged[Cdecl]<int> av_log_get_level;

        public delegate* unmanaged[Cdecl]<int, void> av_log_set_level;

        public delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<void*, int, sbyte*, sbyte*, void>, void> av_log_set_callback;

        public delegate* unmanaged[Cdecl]<void*, int, sbyte*, sbyte*, void> av_log_default_callback;

        public delegate* unmanaged[Cdecl]<void*, sbyte*> av_default_item_name;

        public delegate* unmanaged[Cdecl]<void*, AVClassCategory> av_default_get_category;

        public delegate* unmanaged[Cdecl]<void*, int, sbyte*, sbyte*, sbyte*, int, int*, void> av_log_format_line;

        public delegate* unmanaged[Cdecl]<void*, int, sbyte*, sbyte*, sbyte*, int, int*, int> av_log_format_line2;

        public delegate* unmanaged[Cdecl]<int, void> av_log_set_flags;

        public delegate* unmanaged[Cdecl]<int> av_log_get_flags;

        public static AVRational av_make_q(int num, int den)
        {
            AVRational r = new AVRational
            {
                num = num,
                den = den,
            };

            return r;
        }

        public static int av_cmp_q(AVRational a, AVRational b)
        {
            long tmp = a.num * (long)(b.den) - b.num * (long)(a.den);

            if ((tmp) != 0)
            {
                return (int)((tmp ^ a.den ^ b.den) >> 63) | 1;
            }
            else if ((b.den) != 0 && (a.den) != 0)
            {
                return 0;
            }
            else if ((a.num) != 0 && (b.num) != 0)
            {
                return (a.num >> 31) - (b.num >> 31);
            }
            else
            {
                return (-2147483647 - 1);
            }
        }

        public static double av_q2d(AVRational a)
        {
            return a.num / (double)(a.den);
        }

        public delegate* unmanaged[Cdecl]<int*, int*, long, long, long, int> av_reduce;

        public delegate* unmanaged[Cdecl]<AVRational, AVRational, AVRational> av_mul_q;

        public delegate* unmanaged[Cdecl]<AVRational, AVRational, AVRational> av_div_q;

        public delegate* unmanaged[Cdecl]<AVRational, AVRational, AVRational> av_add_q;

        public delegate* unmanaged[Cdecl]<AVRational, AVRational, AVRational> av_sub_q;

        public static AVRational av_inv_q(AVRational q)
        {
            AVRational r = new AVRational
            {
                num = q.den,
                den = q.num,
            };

            return r;
        }

        public delegate* unmanaged[Cdecl]<double, int, AVRational> av_d2q;

        public delegate* unmanaged[Cdecl]<AVRational, AVRational, AVRational, int> av_nearer_q;

        public delegate* unmanaged[Cdecl]<AVRational, AVRational*, int> av_find_nearest_q_idx;

        public delegate* unmanaged[Cdecl]<AVRational, uint> av_q2intfloat;

        public delegate* unmanaged[Cdecl]<AVRational, AVRational, int, AVRational, AVRational> av_gcd_q;

        public delegate* unmanaged[Cdecl]<int*, int*, AVPixFmtDescriptor*, void> av_image_fill_max_pixsteps;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, int, int, int> av_image_get_linesize;

        public delegate* unmanaged[Cdecl]<int*, AVPixelFormat, int, int> av_image_fill_linesizes;

        public delegate* unmanaged[Cdecl]<nuint*, AVPixelFormat, int, nint*, int> av_image_fill_plane_sizes;

        public delegate* unmanaged[Cdecl]<byte**, AVPixelFormat, int, byte*, int*, int> av_image_fill_pointers;

        public delegate* unmanaged[Cdecl]<byte**, int*, int, int, AVPixelFormat, int, int> av_image_alloc;

        public delegate* unmanaged[Cdecl]<byte*, int, byte*, int, int, int, void> av_image_copy_plane;

        public delegate* unmanaged[Cdecl]<byte*, nint, byte*, nint, nint, int, void> av_image_copy_plane_uc_from;

        public delegate* unmanaged[Cdecl]<byte**, int*, byte**, int*, AVPixelFormat, int, int, void> av_image_copy;

        public delegate* unmanaged[Cdecl]<byte**, nint*, byte**, nint*, AVPixelFormat, int, int, void> av_image_copy_uc_from;

        public delegate* unmanaged[Cdecl]<byte**, int*, byte*, AVPixelFormat, int, int, int, int> av_image_fill_arrays;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, int, int, int, int> av_image_get_buffer_size;

        public delegate* unmanaged[Cdecl]<byte*, int, byte**, int*, AVPixelFormat, int, int, int, int> av_image_copy_to_buffer;

        public delegate* unmanaged[Cdecl]<uint, uint, int, void*, int> av_image_check_size;

        public delegate* unmanaged[Cdecl]<uint, uint, long, AVPixelFormat, int, void*, int> av_image_check_size2;

        public delegate* unmanaged[Cdecl]<uint, uint, AVRational, int> av_image_check_sar;

        public delegate* unmanaged[Cdecl]<byte**, nint*, AVPixelFormat, AVColorRange, int, int, int> av_image_fill_black;

        public delegate* unmanaged[Cdecl]<sbyte*, AVHWDeviceType> av_hwdevice_find_type_by_name;

        public delegate* unmanaged[Cdecl]<AVHWDeviceType, sbyte*> av_hwdevice_get_type_name;

        public delegate* unmanaged[Cdecl]<AVHWDeviceType, AVHWDeviceType> av_hwdevice_iterate_types;

        public delegate* unmanaged[Cdecl]<AVHWDeviceType, AVBufferRef*> av_hwdevice_ctx_alloc;

        public delegate* unmanaged[Cdecl]<AVBufferRef*, int> av_hwdevice_ctx_init;

        public delegate* unmanaged[Cdecl]<AVBufferRef**, AVHWDeviceType, sbyte*, AVDictionary*, int, int> av_hwdevice_ctx_create;

        public delegate* unmanaged[Cdecl]<AVBufferRef**, AVHWDeviceType, AVBufferRef*, int, int> av_hwdevice_ctx_create_derived;

        public delegate* unmanaged[Cdecl]<AVBufferRef**, AVHWDeviceType, AVBufferRef*, AVDictionary*, int, int> av_hwdevice_ctx_create_derived_opts;

        public delegate* unmanaged[Cdecl]<AVBufferRef*, AVBufferRef*> av_hwframe_ctx_alloc;

        public delegate* unmanaged[Cdecl]<AVBufferRef*, int> av_hwframe_ctx_init;

        public delegate* unmanaged[Cdecl]<AVBufferRef*, AVFrame*, int, int> av_hwframe_get_buffer;

        public delegate* unmanaged[Cdecl]<AVFrame*, AVFrame*, int, int> av_hwframe_transfer_data;

        public delegate* unmanaged[Cdecl]<AVBufferRef*, AVHWFrameTransferDirection, AVPixelFormat**, int, int> av_hwframe_transfer_get_formats;

        public delegate* unmanaged[Cdecl]<AVBufferRef*, void*> av_hwdevice_hwconfig_alloc;

        public delegate* unmanaged[Cdecl]<AVBufferRef*, void*, AVHWFramesConstraints*> av_hwdevice_get_hwframe_constraints;

        public delegate* unmanaged[Cdecl]<AVHWFramesConstraints**, void> av_hwframe_constraints_free;

        public const int AV_HWFRAME_MAP_READ = 1 << 0;
        public const int AV_HWFRAME_MAP_WRITE = 1 << 1;
        public const int AV_HWFRAME_MAP_OVERWRITE = 1 << 2;
        public const int AV_HWFRAME_MAP_DIRECT = 1 << 3;

        public delegate* unmanaged[Cdecl]<AVFrame*, AVFrame*, int, int> av_hwframe_map;

        public delegate* unmanaged[Cdecl]<AVBufferRef**, AVPixelFormat, AVBufferRef*, AVBufferRef*, int, int> av_hwframe_ctx_create_derived;

        public delegate* unmanaged[Cdecl]<AVPixFmtDescriptor*, int> av_get_bits_per_pixel;

        public delegate* unmanaged[Cdecl]<AVPixFmtDescriptor*, int> av_get_padded_bits_per_pixel;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, AVPixFmtDescriptor*> av_pix_fmt_desc_get;

        public delegate* unmanaged[Cdecl]<AVPixFmtDescriptor*, AVPixFmtDescriptor*> av_pix_fmt_desc_next;

        public delegate* unmanaged[Cdecl]<AVPixFmtDescriptor*, AVPixelFormat> av_pix_fmt_desc_get_id;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, int*, int*, int> av_pix_fmt_get_chroma_sub_sample;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, int> av_pix_fmt_count_planes;

        public delegate* unmanaged[Cdecl]<AVColorRange, sbyte*> av_color_range_name;

        public delegate* unmanaged[Cdecl]<sbyte*, int> av_color_range_from_name;

        public delegate* unmanaged[Cdecl]<AVColorPrimaries, sbyte*> av_color_primaries_name;

        public delegate* unmanaged[Cdecl]<sbyte*, int> av_color_primaries_from_name;

        public delegate* unmanaged[Cdecl]<AVColorTransferCharacteristic, sbyte*> av_color_transfer_name;

        public delegate* unmanaged[Cdecl]<sbyte*, int> av_color_transfer_from_name;

        public delegate* unmanaged[Cdecl]<AVColorSpace, sbyte*> av_color_space_name;

        public delegate* unmanaged[Cdecl]<sbyte*, int> av_color_space_from_name;

        public delegate* unmanaged[Cdecl]<AVChromaLocation, sbyte*> av_chroma_location_name;

        public delegate* unmanaged[Cdecl]<sbyte*, int> av_chroma_location_from_name;

        public delegate* unmanaged[Cdecl]<int*, int*, AVChromaLocation, int> av_chroma_location_enum_to_pos;

        public delegate* unmanaged[Cdecl]<int, int, AVChromaLocation> av_chroma_location_pos_to_enum;

        public delegate* unmanaged[Cdecl]<sbyte*, AVPixelFormat> av_get_pix_fmt;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, sbyte*> av_get_pix_fmt_name;

        public delegate* unmanaged[Cdecl]<sbyte*, int, AVPixelFormat, sbyte*> av_get_pix_fmt_string;

        public delegate* unmanaged[Cdecl]<void*, byte**, int*, AVPixFmtDescriptor*, int, int, int, int, int, int, void> av_read_image_line2;

        public delegate* unmanaged[Cdecl]<ushort*, byte**, int*, AVPixFmtDescriptor*, int, int, int, int, int, void> av_read_image_line;

        public delegate* unmanaged[Cdecl]<void*, byte**, int*, AVPixFmtDescriptor*, int, int, int, int, int, void> av_write_image_line2;

        public delegate* unmanaged[Cdecl]<ushort*, byte**, int*, AVPixFmtDescriptor*, int, int, int, int, void> av_write_image_line;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, AVPixelFormat> av_pix_fmt_swap_endianness;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, AVPixelFormat, int, int> av_get_pix_fmt_loss;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, AVPixelFormat, AVPixelFormat, int, int*, AVPixelFormat> av_find_best_pix_fmt_of_2;
    }
}
