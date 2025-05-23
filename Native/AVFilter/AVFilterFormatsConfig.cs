namespace FFMpegSharp.Native
{
    public unsafe partial struct AVFilterFormatsConfig
    {
        public AVFilterFormats* formats;

        public AVFilterFormats* samplerates;

        public AVFilterChannelLayouts* channel_layouts;
    }
}
