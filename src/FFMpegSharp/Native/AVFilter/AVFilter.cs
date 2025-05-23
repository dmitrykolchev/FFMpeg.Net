using System.Runtime.InteropServices;

namespace FFMpegSharp.Native
{
    public unsafe partial struct AVFilter
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* description;

        [NativeTypeName("const AVFilterPad *")]
        public AVFilterPad* inputs;

        [NativeTypeName("const AVFilterPad *")]
        public AVFilterPad* outputs;

        [NativeTypeName("const AVClass *")]
        public AVClass* priv_class;

        public int flags;

        [NativeTypeName("uint8_t")]
        public byte nb_inputs;

        [NativeTypeName("uint8_t")]
        public byte nb_outputs;

        [NativeTypeName("uint8_t")]
        public byte formats_state;

        [NativeTypeName("int (*)(AVFilterContext *)")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, int> preinit;

        [NativeTypeName("int (*)(AVFilterContext *)")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, int> init;

        [NativeTypeName("void (*)(AVFilterContext *)")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, void> uninit;

        [NativeTypeName("__AnonymousRecord_avfilter_L290_C5")]
        public _formats_e__Union formats;

        public int priv_size;

        public int flags_internal;

        [NativeTypeName("int (*)(AVFilterContext *, const char *, const char *, char *, int, int)")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, sbyte*, sbyte*, sbyte*, int, int, int> process_command;

        [NativeTypeName("int (*)(AVFilterContext *)")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, int> activate;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _formats_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("int (*)(AVFilterContext *)")]
            public delegate* unmanaged[Cdecl]<AVFilterContext*, int> query_func;

            [FieldOffset(0)]
            [NativeTypeName("const enum AVPixelFormat *")]
            public AVPixelFormat* pixels_list;

            [FieldOffset(0)]
            [NativeTypeName("const enum AVSampleFormat *")]
            public AVSampleFormat* samples_list;

            [FieldOffset(0)]
            [NativeTypeName("enum AVPixelFormat")]
            public AVPixelFormat pix_fmt;

            [FieldOffset(0)]
            [NativeTypeName("enum AVSampleFormat")]
            public AVSampleFormat sample_fmt;
        }
    }
}
