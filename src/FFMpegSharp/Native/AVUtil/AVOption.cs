using System.Runtime.InteropServices;

namespace FFMpegSharp.Native
{
    public unsafe partial struct AVOption
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* help;

        public int offset;

        [NativeTypeName("enum AVOptionType")]
        public AVOptionType type;

        [NativeTypeName("__AnonymousRecord_opt_L270_C5")]
        public _default_val_e__Union default_val;

        public double min;

        public double max;

        public int flags;

        [NativeTypeName("const char *")]
        public sbyte* unit;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _default_val_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("int64_t")]
            public long i64;

            [FieldOffset(0)]
            public double dbl;

            [FieldOffset(0)]
            [NativeTypeName("const char *")]
            public sbyte* str;

            [FieldOffset(0)]
            public AVRational q;
        }
    }
}
