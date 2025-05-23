using System;

namespace FFMpegSharp.Native
{
    public unsafe partial class SWResampleNative
    {
        public delegate* unmanaged[Cdecl]<AVClass*> swr_get_class;

        public delegate* unmanaged[Cdecl]<SwrContext*> swr_alloc;

        public delegate* unmanaged[Cdecl]<SwrContext*, int> swr_init;

        public delegate* unmanaged[Cdecl]<SwrContext*, int> swr_is_initialized;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<SwrContext*, long, AVSampleFormat, int, long, AVSampleFormat, int, int, void*, SwrContext*> swr_alloc_set_opts;

        public delegate* unmanaged[Cdecl]<SwrContext**, AVChannelLayout*, AVSampleFormat, int, AVChannelLayout*, AVSampleFormat, int, int, void*, int> swr_alloc_set_opts2;

        public delegate* unmanaged[Cdecl]<SwrContext**, void> swr_free;

        public delegate* unmanaged[Cdecl]<SwrContext*, void> swr_close;

        public delegate* unmanaged[Cdecl]<SwrContext*, byte**, int, byte**, int, int> swr_convert;

        public delegate* unmanaged[Cdecl]<SwrContext*, long, long> swr_next_pts;

        public delegate* unmanaged[Cdecl]<SwrContext*, int, int, int> swr_set_compensation;

        public delegate* unmanaged[Cdecl]<SwrContext*, int*, int> swr_set_channel_mapping;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<ulong, ulong, double, double, double, double, double, double*, int, AVMatrixEncoding, void*, int> swr_build_matrix;

        public delegate* unmanaged[Cdecl]<AVChannelLayout*, AVChannelLayout*, double, double, double, double, double, double*, nint, AVMatrixEncoding, void*, int> swr_build_matrix2;

        public delegate* unmanaged[Cdecl]<SwrContext*, double*, int, int> swr_set_matrix;

        public delegate* unmanaged[Cdecl]<SwrContext*, int, int> swr_drop_output;

        public delegate* unmanaged[Cdecl]<SwrContext*, int, int> swr_inject_silence;

        public delegate* unmanaged[Cdecl]<SwrContext*, long, long> swr_get_delay;

        public delegate* unmanaged[Cdecl]<SwrContext*, int, int> swr_get_out_samples;

        public delegate* unmanaged[Cdecl]<uint> swresample_version;

        public delegate* unmanaged[Cdecl]<sbyte*> swresample_configuration;

        public delegate* unmanaged[Cdecl]<sbyte*> swresample_license;

        public delegate* unmanaged[Cdecl]<SwrContext*, AVFrame*, AVFrame*, int> swr_convert_frame;

        public delegate* unmanaged[Cdecl]<SwrContext*, AVFrame*, AVFrame*, int> swr_config_frame;
    }
}
