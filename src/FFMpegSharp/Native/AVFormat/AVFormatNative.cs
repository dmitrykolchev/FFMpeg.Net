using System;

namespace FFMpegSharp.Native
{
    public unsafe partial class AVFormatNative
    {
        public delegate* unmanaged[Cdecl]<AVIOContext*, AVPacket*, int, int> av_get_packet;

        public delegate* unmanaged[Cdecl]<AVIOContext*, AVPacket*, int, int> av_append_packet;

        public delegate* unmanaged[Cdecl]<sbyte*, int> av_disposition_from_string;

        public delegate* unmanaged[Cdecl]<int, sbyte*> av_disposition_to_string;

        public delegate* unmanaged[Cdecl]<AVStream*, AVCodecParserContext*> av_stream_get_parser;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVStream*, long> av_stream_get_end_pts;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, void> av_format_inject_global_side_data;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVDurationEstimationMethod> av_fmt_ctx_get_duration_estimation_method;

        public delegate* unmanaged[Cdecl]<uint> avformat_version;

        public delegate* unmanaged[Cdecl]<sbyte*> avformat_configuration;

        public delegate* unmanaged[Cdecl]<sbyte*> avformat_license;

        public delegate* unmanaged[Cdecl]<int> avformat_network_init;

        public delegate* unmanaged[Cdecl]<int> avformat_network_deinit;

        public delegate* unmanaged[Cdecl]<void**, AVOutputFormat*> av_muxer_iterate;

        public delegate* unmanaged[Cdecl]<void**, AVInputFormat*> av_demuxer_iterate;

        public delegate* unmanaged[Cdecl]<AVFormatContext*> avformat_alloc_context;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, void> avformat_free_context;

        public delegate* unmanaged[Cdecl]<AVClass*> avformat_get_class;

        public delegate* unmanaged[Cdecl]<AVClass*> av_stream_get_class;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVCodec*, AVStream*> avformat_new_stream;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVStream*, AVPacketSideDataType, byte*, nuint, int> av_stream_add_side_data;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVStream*, AVPacketSideDataType, nuint, byte*> av_stream_new_side_data;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVStream*, AVPacketSideDataType, nuint*, byte*> av_stream_get_side_data;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, AVProgram*> av_new_program;

        public delegate* unmanaged[Cdecl]<AVFormatContext**, AVOutputFormat*, sbyte*, sbyte*, int> avformat_alloc_output_context2;

        public delegate* unmanaged[Cdecl]<sbyte*, AVInputFormat*> av_find_input_format;

        public delegate* unmanaged[Cdecl]<AVProbeData*, int, AVInputFormat*> av_probe_input_format;

        public delegate* unmanaged[Cdecl]<AVProbeData*, int, int*, AVInputFormat*> av_probe_input_format2;

        public delegate* unmanaged[Cdecl]<AVProbeData*, int, int*, AVInputFormat*> av_probe_input_format3;

        public delegate* unmanaged[Cdecl]<AVIOContext*, AVInputFormat**, sbyte*, void*, uint, uint, int> av_probe_input_buffer2;

        public delegate* unmanaged[Cdecl]<AVIOContext*, AVInputFormat**, sbyte*, void*, uint, uint, int> av_probe_input_buffer;

        public delegate* unmanaged[Cdecl]<AVFormatContext**, sbyte*, AVInputFormat*, AVDictionary**, int> avformat_open_input;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVDictionary**, int> avformat_find_stream_info;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVProgram*, int, AVProgram*> av_find_program_from_stream;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, uint, void> av_program_add_stream_index;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVMediaType, int, int, AVCodec**, int, int> av_find_best_stream;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVPacket*, int> av_read_frame;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, long, int, int> av_seek_frame;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, long, long, long, int, int> avformat_seek_file;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> avformat_flush;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> av_read_play;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> av_read_pause;

        public delegate* unmanaged[Cdecl]<AVFormatContext**, void> avformat_close_input;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVDictionary**, int> avformat_write_header;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVDictionary**, int> avformat_init_output;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVPacket*, int> av_write_frame;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVPacket*, int> av_interleaved_write_frame;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, AVFrame*, int> av_write_uncoded_frame;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, AVFrame*, int> av_interleaved_write_uncoded_frame;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, int> av_write_uncoded_frame_query;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> av_write_trailer;

        public delegate* unmanaged[Cdecl]<sbyte*, sbyte*, sbyte*, AVOutputFormat*> av_guess_format;

        public delegate* unmanaged[Cdecl]<AVOutputFormat*, sbyte*, sbyte*, sbyte*, AVMediaType, AVCodecID> av_guess_codec;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, long*, long*, int> av_get_output_timestamp;

        public delegate* unmanaged[Cdecl]<void*, byte*, int, void> av_hex_dump;

        public delegate* unmanaged[Cdecl]<void*, int, byte*, int, void> av_hex_dump_log;

        public delegate* unmanaged[Cdecl]<void*, AVPacket*, int, AVStream*, void> av_pkt_dump2;

        public delegate* unmanaged[Cdecl]<void*, int, AVPacket*, int, AVStream*, void> av_pkt_dump_log2;

        public delegate* unmanaged[Cdecl]<AVCodecTag**, uint, AVCodecID> av_codec_get_id;

        public delegate* unmanaged[Cdecl]<AVCodecTag**, AVCodecID, uint> av_codec_get_tag;

        public delegate* unmanaged[Cdecl]<AVCodecTag**, AVCodecID, uint*, int> av_codec_get_tag2;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> av_find_default_stream_index;

        public delegate* unmanaged[Cdecl]<AVStream*, long, int, int> av_index_search_timestamp;

        public delegate* unmanaged[Cdecl]<AVStream*, int> avformat_index_get_entries_count;

        public delegate* unmanaged[Cdecl]<AVStream*, int, AVIndexEntry*> avformat_index_get_entry;

        public delegate* unmanaged[Cdecl]<AVStream*, long, int, AVIndexEntry*> avformat_index_get_entry_from_timestamp;

        public delegate* unmanaged[Cdecl]<AVStream*, long, long, int, int, int, int> av_add_index_entry;

        public delegate* unmanaged[Cdecl]<sbyte*, int, sbyte*, int, sbyte*, int, int*, sbyte*, int, sbyte*, void> av_url_split;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, sbyte*, int, void> av_dump_format;

        public delegate* unmanaged[Cdecl]<sbyte*, int, sbyte*, int, int, int> av_get_frame_filename2;

        public delegate* unmanaged[Cdecl]<sbyte*, int, sbyte*, int, int> av_get_frame_filename;

        public delegate* unmanaged[Cdecl]<sbyte*, int> av_filename_number_test;

        public delegate* unmanaged[Cdecl]<AVFormatContext**, int, sbyte*, int, int> av_sdp_create;

        public delegate* unmanaged[Cdecl]<sbyte*, sbyte*, int> av_match_ext;

        public delegate* unmanaged[Cdecl]<AVOutputFormat*, AVCodecID, int, int> avformat_query_codec;

        public delegate* unmanaged[Cdecl]<AVCodecTag*> avformat_get_riff_video_tags;

        public delegate* unmanaged[Cdecl]<AVCodecTag*> avformat_get_riff_audio_tags;

        public delegate* unmanaged[Cdecl]<AVCodecTag*> avformat_get_mov_video_tags;

        public delegate* unmanaged[Cdecl]<AVCodecTag*> avformat_get_mov_audio_tags;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVStream*, AVFrame*, AVRational> av_guess_sample_aspect_ratio;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVStream*, AVFrame*, AVRational> av_guess_frame_rate;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVStream*, sbyte*, int> avformat_match_stream_specifier;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> avformat_queue_attached_pictures;

        public delegate* unmanaged[Cdecl]<AVOutputFormat*, AVStream*, AVStream*, AVTimebaseSource, int> avformat_transfer_internal_stream_timing_info;

        public delegate* unmanaged[Cdecl]<AVStream*, AVRational> av_stream_get_codec_timebase;

        public delegate* unmanaged[Cdecl]<sbyte*, sbyte*> avio_find_protocol_name;

        public delegate* unmanaged[Cdecl]<sbyte*, int, int> avio_check;

        public delegate* unmanaged[Cdecl]<AVIODirContext**, sbyte*, AVDictionary**, int> avio_open_dir;

        public delegate* unmanaged[Cdecl]<AVIODirContext*, AVIODirEntry**, int> avio_read_dir;

        public delegate* unmanaged[Cdecl]<AVIODirContext**, int> avio_close_dir;

        public delegate* unmanaged[Cdecl]<AVIODirEntry**, void> avio_free_directory_entry;

        public delegate* unmanaged[Cdecl]<byte*, int, int, void*, delegate* unmanaged[Cdecl]<void*, byte*, int, int>, delegate* unmanaged[Cdecl]<void*, byte*, int, int>, delegate* unmanaged[Cdecl]<void*, long, int, long>, AVIOContext*> avio_alloc_context;

        public delegate* unmanaged[Cdecl]<AVIOContext**, void> avio_context_free;

        public delegate* unmanaged[Cdecl]<AVIOContext*, int, void> avio_w8;

        public delegate* unmanaged[Cdecl]<AVIOContext*, byte*, int, void> avio_write;

        public delegate* unmanaged[Cdecl]<AVIOContext*, ulong, void> avio_wl64;

        public delegate* unmanaged[Cdecl]<AVIOContext*, ulong, void> avio_wb64;

        public delegate* unmanaged[Cdecl]<AVIOContext*, uint, void> avio_wl32;

        public delegate* unmanaged[Cdecl]<AVIOContext*, uint, void> avio_wb32;

        public delegate* unmanaged[Cdecl]<AVIOContext*, uint, void> avio_wl24;

        public delegate* unmanaged[Cdecl]<AVIOContext*, uint, void> avio_wb24;

        public delegate* unmanaged[Cdecl]<AVIOContext*, uint, void> avio_wl16;

        public delegate* unmanaged[Cdecl]<AVIOContext*, uint, void> avio_wb16;

        public delegate* unmanaged[Cdecl]<AVIOContext*, sbyte*, int> avio_put_str;

        public delegate* unmanaged[Cdecl]<AVIOContext*, sbyte*, int> avio_put_str16le;

        public delegate* unmanaged[Cdecl]<AVIOContext*, sbyte*, int> avio_put_str16be;

        public delegate* unmanaged[Cdecl]<AVIOContext*, long, AVIODataMarkerType, void> avio_write_marker;

        public delegate* unmanaged[Cdecl]<AVIOContext*, long, int, long> avio_seek;

        public delegate* unmanaged[Cdecl]<AVIOContext*, long, long> avio_skip;

        public delegate* unmanaged[Cdecl]<AVIOContext*, long> avio_size;

        public delegate* unmanaged[Cdecl]<AVIOContext*, int> avio_feof;

        public delegate* unmanaged[Cdecl]<AVIOContext*, sbyte*, sbyte*, int> avio_vprintf;

        public delegate* unmanaged[Cdecl]<AVIOContext*, sbyte**, void> avio_print_string_array;

        public delegate* unmanaged[Cdecl]<AVIOContext*, void> avio_flush;

        public delegate* unmanaged[Cdecl]<AVIOContext*, byte*, int, int> avio_read;

        public delegate* unmanaged[Cdecl]<AVIOContext*, byte*, int, int> avio_read_partial;

        public delegate* unmanaged[Cdecl]<AVIOContext*, int> avio_r8;

        public delegate* unmanaged[Cdecl]<AVIOContext*, uint> avio_rl16;

        public delegate* unmanaged[Cdecl]<AVIOContext*, uint> avio_rl24;

        public delegate* unmanaged[Cdecl]<AVIOContext*, uint> avio_rl32;

        public delegate* unmanaged[Cdecl]<AVIOContext*, ulong> avio_rl64;

        public delegate* unmanaged[Cdecl]<AVIOContext*, uint> avio_rb16;

        public delegate* unmanaged[Cdecl]<AVIOContext*, uint> avio_rb24;

        public delegate* unmanaged[Cdecl]<AVIOContext*, uint> avio_rb32;

        public delegate* unmanaged[Cdecl]<AVIOContext*, ulong> avio_rb64;

        public delegate* unmanaged[Cdecl]<AVIOContext*, int, sbyte*, int, int> avio_get_str;

        public delegate* unmanaged[Cdecl]<AVIOContext*, int, sbyte*, int, int> avio_get_str16le;

        public delegate* unmanaged[Cdecl]<AVIOContext*, int, sbyte*, int, int> avio_get_str16be;

        public delegate* unmanaged[Cdecl]<AVIOContext**, sbyte*, int, int> avio_open;

        public delegate* unmanaged[Cdecl]<AVIOContext**, sbyte*, int, AVIOInterruptCB*, AVDictionary**, int> avio_open2;

        public delegate* unmanaged[Cdecl]<AVIOContext*, int> avio_close;

        public delegate* unmanaged[Cdecl]<AVIOContext**, int> avio_closep;

        public delegate* unmanaged[Cdecl]<AVIOContext**, int> avio_open_dyn_buf;

        public delegate* unmanaged[Cdecl]<AVIOContext*, byte**, int> avio_get_dyn_buf;

        public delegate* unmanaged[Cdecl]<AVIOContext*, byte**, int> avio_close_dyn_buf;

        public delegate* unmanaged[Cdecl]<void**, int, sbyte*> avio_enum_protocols;

        public delegate* unmanaged[Cdecl]<sbyte*, AVClass*> avio_protocol_get_class;

        public delegate* unmanaged[Cdecl]<AVIOContext*, int, int> avio_pause;

        public delegate* unmanaged[Cdecl]<AVIOContext*, int, long, int, long> avio_seek_time;

        public delegate* unmanaged[Cdecl]<AVIOContext*, AVBPrint*, nuint, int> avio_read_to_bprint;

        public delegate* unmanaged[Cdecl]<AVIOContext*, AVIOContext**, int> avio_accept;

        public delegate* unmanaged[Cdecl]<AVIOContext*, int> avio_handshake;
    }
}
