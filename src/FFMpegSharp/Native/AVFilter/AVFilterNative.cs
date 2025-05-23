using System;

namespace FFMpegSharp.Native
{
    public unsafe partial class AVFilterNative
    {
        public delegate* unmanaged[Cdecl]<uint> avfilter_version;

        public delegate* unmanaged[Cdecl]<sbyte*> avfilter_configuration;

        public delegate* unmanaged[Cdecl]<sbyte*> avfilter_license;

        public delegate* unmanaged[Cdecl]<AVFilterPad*, int, sbyte*> avfilter_pad_get_name;

        public delegate* unmanaged[Cdecl]<AVFilterPad*, int, AVMediaType> avfilter_pad_get_type;

        public delegate* unmanaged[Cdecl]<AVFilter*, int, uint> avfilter_filter_pad_count;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, uint, AVFilterContext*, uint, int> avfilter_link;

        public delegate* unmanaged[Cdecl]<AVFilterLink**, void> avfilter_link_free;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, int> avfilter_config_links;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, sbyte*, sbyte*, sbyte*, int, int, int> avfilter_process_command;

        public delegate* unmanaged[Cdecl]<void**, AVFilter*> av_filter_iterate;

        public delegate* unmanaged[Cdecl]<sbyte*, AVFilter*> avfilter_get_by_name;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, sbyte*, int> avfilter_init_str;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVDictionary**, int> avfilter_init_dict;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, void> avfilter_free;

        public delegate* unmanaged[Cdecl]<AVFilterLink*, AVFilterContext*, uint, uint, int> avfilter_insert_filter;

        public delegate* unmanaged[Cdecl]<AVClass*> avfilter_get_class;

        public delegate* unmanaged[Cdecl]<AVFilterGraph*> avfilter_graph_alloc;

        public delegate* unmanaged[Cdecl]<AVFilterGraph*, AVFilter*, sbyte*, AVFilterContext*> avfilter_graph_alloc_filter;

        public delegate* unmanaged[Cdecl]<AVFilterGraph*, sbyte*, AVFilterContext*> avfilter_graph_get_filter;

        public delegate* unmanaged[Cdecl]<AVFilterContext**, AVFilter*, sbyte*, sbyte*, void*, AVFilterGraph*, int> avfilter_graph_create_filter;

        public delegate* unmanaged[Cdecl]<AVFilterGraph*, uint, void> avfilter_graph_set_auto_convert;

        public const int AVFILTER_AUTO_CONVERT_ALL = 0;
        public const int AVFILTER_AUTO_CONVERT_NONE = -1;

        public delegate* unmanaged[Cdecl]<AVFilterGraph*, void*, int> avfilter_graph_config;

        public delegate* unmanaged[Cdecl]<AVFilterGraph**, void> avfilter_graph_free;

        public delegate* unmanaged[Cdecl]<AVFilterInOut*> avfilter_inout_alloc;

        public delegate* unmanaged[Cdecl]<AVFilterInOut**, void> avfilter_inout_free;

        public delegate* unmanaged[Cdecl]<AVFilterGraph*, sbyte*, AVFilterInOut*, AVFilterInOut*, void*, int> avfilter_graph_parse;

        public delegate* unmanaged[Cdecl]<AVFilterGraph*, sbyte*, AVFilterInOut**, AVFilterInOut**, void*, int> avfilter_graph_parse_ptr;

        public delegate* unmanaged[Cdecl]<AVFilterGraph*, sbyte*, AVFilterInOut**, AVFilterInOut**, int> avfilter_graph_parse2;

        public delegate* unmanaged[Cdecl]<AVFilterGraph*, sbyte*, int, AVFilterGraphSegment**, int> avfilter_graph_segment_parse;

        public delegate* unmanaged[Cdecl]<AVFilterGraphSegment*, int, int> avfilter_graph_segment_create_filters;

        public delegate* unmanaged[Cdecl]<AVFilterGraphSegment*, int, int> avfilter_graph_segment_apply_opts;

        public delegate* unmanaged[Cdecl]<AVFilterGraphSegment*, int, int> avfilter_graph_segment_init;

        public delegate* unmanaged[Cdecl]<AVFilterGraphSegment*, int, AVFilterInOut**, AVFilterInOut**, int> avfilter_graph_segment_link;

        public delegate* unmanaged[Cdecl]<AVFilterGraphSegment*, int, AVFilterInOut**, AVFilterInOut**, int> avfilter_graph_segment_apply;

        public delegate* unmanaged[Cdecl]<AVFilterGraphSegment**, void> avfilter_graph_segment_free;

        public delegate* unmanaged[Cdecl]<AVFilterGraph*, sbyte*, sbyte*, sbyte*, sbyte*, int, int, int> avfilter_graph_send_command;

        public delegate* unmanaged[Cdecl]<AVFilterGraph*, sbyte*, sbyte*, sbyte*, int, double, int> avfilter_graph_queue_command;

        public delegate* unmanaged[Cdecl]<AVFilterGraph*, sbyte*, sbyte*> avfilter_graph_dump;

        public delegate* unmanaged[Cdecl]<AVFilterGraph*, int> avfilter_graph_request_oldest;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVFrame*, int, int> av_buffersink_get_frame_flags;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, uint, void> av_buffersink_set_frame_size;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVMediaType> av_buffersink_get_type;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVRational> av_buffersink_get_time_base;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, int> av_buffersink_get_format;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVRational> av_buffersink_get_frame_rate;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, int> av_buffersink_get_w;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, int> av_buffersink_get_h;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVRational> av_buffersink_get_sample_aspect_ratio;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, int> av_buffersink_get_channels;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, ulong> av_buffersink_get_channel_layout;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVChannelLayout*, int> av_buffersink_get_ch_layout;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, int> av_buffersink_get_sample_rate;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVBufferRef*> av_buffersink_get_hw_frames_ctx;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVFrame*, int> av_buffersink_get_frame;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVFrame*, int, int> av_buffersink_get_samples;

        public const int AV_BUFFERSRC_FLAG_NO_CHECK_FORMAT = 1;
        public const int AV_BUFFERSRC_FLAG_PUSH = 4;
        public const int AV_BUFFERSRC_FLAG_KEEP_REF = 8;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, uint> av_buffersrc_get_nb_failed_requests;

        public delegate* unmanaged[Cdecl]<AVBufferSrcParameters*> av_buffersrc_parameters_alloc;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVBufferSrcParameters*, int> av_buffersrc_parameters_set;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVFrame*, int> av_buffersrc_write_frame;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVFrame*, int> av_buffersrc_add_frame;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVFrame*, int, int> av_buffersrc_add_frame_flags;

        public delegate* unmanaged[Cdecl]<AVFilterContext*, long, uint, int> av_buffersrc_close;
    }
}
