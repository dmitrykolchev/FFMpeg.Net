using System.Runtime.InteropServices;

namespace FFMpegSharp.Native
{
    public unsafe partial struct AVChannelLayout
    {
        [NativeTypeName("enum AVChannelOrder")]
        public AVChannelOrder order;

        public int nb_channels;

        [NativeTypeName("__AnonymousRecord_channel_layout_L324_C5")]
        public _u_e__Union u;

        public void* opaque;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("uint64_t")]
            public ulong mask;

            [FieldOffset(0)]
            public AVChannelCustom* map;
        }
    }
}
