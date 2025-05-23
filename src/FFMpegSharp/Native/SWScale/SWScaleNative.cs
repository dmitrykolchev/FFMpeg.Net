namespace FFMpegSharp.Native
{
    public unsafe partial class SWScaleNative
    {
        public delegate* unmanaged[Cdecl]<uint> swscale_version;

        public delegate* unmanaged[Cdecl]<sbyte*> swscale_configuration;

        public delegate* unmanaged[Cdecl]<sbyte*> swscale_license;

        public delegate* unmanaged[Cdecl]<int, int*> sws_getCoefficients;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, int> sws_isSupportedInput;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, int> sws_isSupportedOutput;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, int> sws_isSupportedEndiannessConversion;

        public delegate* unmanaged[Cdecl]<SwsContext*> sws_alloc_context;

        public delegate* unmanaged[Cdecl]<SwsContext*, SwsFilter*, SwsFilter*, int> sws_init_context;

        public delegate* unmanaged[Cdecl]<SwsContext*, void> sws_freeContext;

        public delegate* unmanaged[Cdecl]<int, int, AVPixelFormat, int, int, AVPixelFormat, int, SwsFilter*, SwsFilter*, double*, SwsContext*> sws_getContext;

        public delegate* unmanaged[Cdecl]<SwsContext*, byte**, int*, int, int, byte**, int*, int> sws_scale;

        public delegate* unmanaged[Cdecl]<SwsContext*, AVFrame*, AVFrame*, int> sws_scale_frame;

        public delegate* unmanaged[Cdecl]<SwsContext*, AVFrame*, AVFrame*, int> sws_frame_start;

        public delegate* unmanaged[Cdecl]<SwsContext*, void> sws_frame_end;

        public delegate* unmanaged[Cdecl]<SwsContext*, uint, uint, int> sws_send_slice;

        public delegate* unmanaged[Cdecl]<SwsContext*, uint, uint, int> sws_receive_slice;

        public delegate* unmanaged[Cdecl]<SwsContext*, uint> sws_receive_slice_alignment;

        public delegate* unmanaged[Cdecl]<SwsContext*, int*, int, int*, int, int, int, int, int> sws_setColorspaceDetails;

        public delegate* unmanaged[Cdecl]<SwsContext*, int**, int*, int**, int*, int*, int*, int*, int> sws_getColorspaceDetails;

        public delegate* unmanaged[Cdecl]<int, SwsVector*> sws_allocVec;

        public delegate* unmanaged[Cdecl]<double, double, SwsVector*> sws_getGaussianVec;

        public delegate* unmanaged[Cdecl]<SwsVector*, double, void> sws_scaleVec;

        public delegate* unmanaged[Cdecl]<SwsVector*, double, void> sws_normalizeVec;

        public delegate* unmanaged[Cdecl]<SwsVector*, void> sws_freeVec;

        public delegate* unmanaged[Cdecl]<float, float, float, float, float, float, int, SwsFilter*> sws_getDefaultFilter;

        public delegate* unmanaged[Cdecl]<SwsFilter*, void> sws_freeFilter;

        public delegate* unmanaged[Cdecl]<SwsContext*, int, int, AVPixelFormat, int, int, AVPixelFormat, int, SwsFilter*, SwsFilter*, double*, SwsContext*> sws_getCachedContext;

        public delegate* unmanaged[Cdecl]<byte*, byte*, int, byte*, void> sws_convertPalette8ToPacked32;

        public delegate* unmanaged[Cdecl]<byte*, byte*, int, byte*, void> sws_convertPalette8ToPacked24;

        public delegate* unmanaged[Cdecl]<AVClass*> sws_get_class;
    }
}
