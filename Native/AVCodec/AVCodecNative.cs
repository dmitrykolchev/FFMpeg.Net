using System;

namespace FFMpegSharp.Native
{
    public unsafe partial class AVCodecNative
    {
        public delegate* unmanaged[Cdecl]<uint> avcodec_version;

        public delegate* unmanaged[Cdecl]<sbyte*> avcodec_configuration;

        public delegate* unmanaged[Cdecl]<sbyte*> avcodec_license;

        public delegate* unmanaged[Cdecl]<AVCodec*, AVCodecContext*> avcodec_alloc_context3;

        public delegate* unmanaged[Cdecl]<AVCodecContext**, void> avcodec_free_context;

        public delegate* unmanaged[Cdecl]<AVClass*> avcodec_get_class;

        public delegate* unmanaged[Cdecl]<AVClass*> avcodec_get_subtitle_rect_class;

        public delegate* unmanaged[Cdecl]<AVCodecParameters*, AVCodecContext*, int> avcodec_parameters_from_context;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVCodecParameters*, int> avcodec_parameters_to_context;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVCodec*, AVDictionary**, int> avcodec_open2;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, int> avcodec_close;

        public delegate* unmanaged[Cdecl]<AVSubtitle*, void> avsubtitle_free;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int, int> avcodec_default_get_buffer2;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPacket*, int, int> avcodec_default_get_encode_buffer;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, int*, int*, void> avcodec_align_dimensions;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, int*, int*, int*, void> avcodec_align_dimensions2;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<int*, int*, AVChromaLocation, int> avcodec_enum_to_chroma_pos;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<int, int, AVChromaLocation> avcodec_chroma_pos_to_enum;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVSubtitle*, int*, AVPacket*, int> avcodec_decode_subtitle2;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPacket*, int> avcodec_send_packet;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int> avcodec_receive_frame;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int> avcodec_send_frame;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPacket*, int> avcodec_receive_packet;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVBufferRef*, AVPixelFormat, AVBufferRef**, int> avcodec_get_hw_frames_parameters;

        public delegate* unmanaged[Cdecl]<void**, AVCodecParser*> av_parser_iterate;

        public delegate* unmanaged[Cdecl]<int, AVCodecParserContext*> av_parser_init;

        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, AVCodecContext*, byte**, int*, byte*, int, long, long, long, int> av_parser_parse2;

        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, void> av_parser_close;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, byte*, int, AVSubtitle*, int> avcodec_encode_subtitle;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, uint> avcodec_pix_fmt_to_codec_tag;

        public delegate* unmanaged[Cdecl]<AVPixelFormat*, AVPixelFormat, int, int*, AVPixelFormat> avcodec_find_best_pix_fmt_of_list;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPixelFormat*, AVPixelFormat> avcodec_default_get_format;

        public delegate* unmanaged[Cdecl]<sbyte*, int, AVCodecContext*, int, void> avcodec_string;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int>, void*, int*, int, int, int> avcodec_default_execute;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int, int, int>, void*, int*, int, int> avcodec_default_execute2;

        public delegate* unmanaged[Cdecl]<AVFrame*, int, AVSampleFormat, byte*, int, int, int> avcodec_fill_audio_frame;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, void> avcodec_flush_buffers;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, int, int> av_get_audio_frame_duration;

        public delegate* unmanaged[Cdecl]<void*, uint*, nuint, void> av_fast_padded_malloc;

        public delegate* unmanaged[Cdecl]<void*, uint*, nuint, void> av_fast_padded_mallocz;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, int> avcodec_is_open;

        public delegate* unmanaged[Cdecl]<void**, AVCodec*> av_codec_iterate;

        public delegate* unmanaged[Cdecl]<AVCodecID, AVCodec*> avcodec_find_decoder;

        public delegate* unmanaged[Cdecl]<sbyte*, AVCodec*> avcodec_find_decoder_by_name;

        public delegate* unmanaged[Cdecl]<AVCodecID, AVCodec*> avcodec_find_encoder;

        public delegate* unmanaged[Cdecl]<sbyte*, AVCodec*> avcodec_find_encoder_by_name;

        public delegate* unmanaged[Cdecl]<AVCodec*, int> av_codec_is_encoder;

        public delegate* unmanaged[Cdecl]<AVCodec*, int> av_codec_is_decoder;

        public delegate* unmanaged[Cdecl]<AVCodec*, int, sbyte*> av_get_profile_name;

        public const int AV_CODEC_HW_CONFIG_METHOD_HW_DEVICE_CTX = 0x01;
        public const int AV_CODEC_HW_CONFIG_METHOD_HW_FRAMES_CTX = 0x02;
        public const int AV_CODEC_HW_CONFIG_METHOD_INTERNAL = 0x04;
        public const int AV_CODEC_HW_CONFIG_METHOD_AD_HOC = 0x08;

        public delegate* unmanaged[Cdecl]<AVCodec*, int, AVCodecHWConfig*> avcodec_get_hw_config;

        public delegate* unmanaged[Cdecl]<AVCodecID, AVMediaType> avcodec_get_type;

        public delegate* unmanaged[Cdecl]<AVCodecID, sbyte*> avcodec_get_name;

        public delegate* unmanaged[Cdecl]<AVCodecID, int> av_get_bits_per_sample;

        public delegate* unmanaged[Cdecl]<AVCodecID, int> av_get_exact_bits_per_sample;

        public delegate* unmanaged[Cdecl]<AVCodecID, int, sbyte*> avcodec_profile_name;

        public delegate* unmanaged[Cdecl]<AVSampleFormat, int, AVCodecID> av_get_pcm_codec;

        public delegate* unmanaged[Cdecl]<nuint*, AVCPBProperties*> av_cpb_properties_alloc;

        public delegate* unmanaged[Cdecl]<byte*, uint, uint> av_xiphlacing;

        public delegate* unmanaged[Cdecl]<AVCodecID, AVCodecDescriptor*> avcodec_descriptor_get;

        public delegate* unmanaged[Cdecl]<AVCodecDescriptor*, AVCodecDescriptor*> avcodec_descriptor_next;

        public delegate* unmanaged[Cdecl]<sbyte*, AVCodecDescriptor*> avcodec_descriptor_get_by_name;

        public delegate* unmanaged[Cdecl]<AVPacketSideData**, int*, AVPacketSideDataType, nuint, int, AVPacketSideData*> av_packet_side_data_new;

        public delegate* unmanaged[Cdecl]<AVPacketSideData**, int*, AVPacketSideDataType, void*, nuint, int, AVPacketSideData*> av_packet_side_data_add;

        public delegate* unmanaged[Cdecl]<AVPacketSideData*, int, AVPacketSideDataType, AVPacketSideData*> av_packet_side_data_get;

        public delegate* unmanaged[Cdecl]<AVPacketSideData*, int*, AVPacketSideDataType, void> av_packet_side_data_remove;

        public delegate* unmanaged[Cdecl]<AVPacketSideData**, int*, void> av_packet_side_data_free;

        public delegate* unmanaged[Cdecl]<AVPacketSideDataType, sbyte*> av_packet_side_data_name;

        public delegate* unmanaged[Cdecl]<AVPacket*> av_packet_alloc;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacket*> av_packet_clone;

        public delegate* unmanaged[Cdecl]<AVPacket**, void> av_packet_free;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVPacket*, void> av_init_packet;

        public delegate* unmanaged[Cdecl]<AVPacket*, int, int> av_new_packet;

        public delegate* unmanaged[Cdecl]<AVPacket*, int, void> av_shrink_packet;

        public delegate* unmanaged[Cdecl]<AVPacket*, int, int> av_grow_packet;

        public delegate* unmanaged[Cdecl]<AVPacket*, byte*, int, int> av_packet_from_data;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacketSideDataType, nuint, byte*> av_packet_new_side_data;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacketSideDataType, byte*, nuint, int> av_packet_add_side_data;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacketSideDataType, nuint, int> av_packet_shrink_side_data;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacketSideDataType, nuint*, byte*> av_packet_get_side_data;

        public delegate* unmanaged[Cdecl]<AVDictionary*, nuint*, byte*> av_packet_pack_dictionary;

        public delegate* unmanaged[Cdecl]<byte*, nuint, AVDictionary**, int> av_packet_unpack_dictionary;

        public delegate* unmanaged[Cdecl]<AVPacket*, void> av_packet_free_side_data;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacket*, int> av_packet_ref;

        public delegate* unmanaged[Cdecl]<AVPacket*, void> av_packet_unref;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacket*, void> av_packet_move_ref;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacket*, int> av_packet_copy_props;

        public delegate* unmanaged[Cdecl]<AVPacket*, int> av_packet_make_refcounted;

        public delegate* unmanaged[Cdecl]<AVPacket*, int> av_packet_make_writable;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVRational, AVRational, void> av_packet_rescale_ts;

        public delegate* unmanaged[Cdecl]<AVCodecParameters*> avcodec_parameters_alloc;

        public delegate* unmanaged[Cdecl]<AVCodecParameters**, void> avcodec_parameters_free;

        public delegate* unmanaged[Cdecl]<AVCodecParameters*, AVCodecParameters*, int> avcodec_parameters_copy;

        public delegate* unmanaged[Cdecl]<AVCodecParameters*, int, int> av_get_audio_frame_duration2;
    }
}
