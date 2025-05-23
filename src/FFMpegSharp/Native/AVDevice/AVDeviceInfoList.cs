namespace FFMpegSharp.Native
{
    public unsafe partial struct AVDeviceInfoList
    {
        public AVDeviceInfo** devices;

        public int nb_devices;

        public int default_device;
    }
}
