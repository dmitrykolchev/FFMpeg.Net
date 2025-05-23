namespace FFMpegSharp.Native
{
    public unsafe partial struct AVIOInterruptCB
    {
        [NativeTypeName("int (*)(void *)")]
        public delegate* unmanaged[Cdecl]<void*, int> callback;

        public void* opaque;
    }
}
