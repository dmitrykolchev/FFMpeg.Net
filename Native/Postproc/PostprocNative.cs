namespace FFMpegSharp.Native
{
    public unsafe partial class PostprocNative
    {
        public delegate* unmanaged[Cdecl]<uint> postproc_version;

        public delegate* unmanaged[Cdecl]<sbyte*> postproc_configuration;

        public delegate* unmanaged[Cdecl]<sbyte*> postproc_license;

        public delegate* unmanaged[Cdecl]<byte**, int*, byte**, int*, int, int, sbyte*, int, void*, void*, int, void> pp_postprocess;

        public delegate* unmanaged[Cdecl]<sbyte*, int, void*> pp_get_mode_by_name_and_quality;

        public delegate* unmanaged[Cdecl]<void*, void> pp_free_mode;

        public delegate* unmanaged[Cdecl]<int, int, int, void*> pp_get_context;

        public delegate* unmanaged[Cdecl]<void*, void> pp_free_context;
    }
}
