namespace FFMpegSharp.Native
{
    public unsafe partial class AVDeviceNative
    {
        public delegate* unmanaged[Cdecl]<uint> avdevice_version;

        public delegate* unmanaged[Cdecl]<sbyte*> avdevice_configuration;

        public delegate* unmanaged[Cdecl]<sbyte*> avdevice_license;

        public delegate* unmanaged[Cdecl]<void> avdevice_register_all;

        public delegate* unmanaged[Cdecl]<AVInputFormat*, AVInputFormat*> av_input_audio_device_next;

        public delegate* unmanaged[Cdecl]<AVInputFormat*, AVInputFormat*> av_input_video_device_next;

        public delegate* unmanaged[Cdecl]<AVOutputFormat*, AVOutputFormat*> av_output_audio_device_next;

        public delegate* unmanaged[Cdecl]<AVOutputFormat*, AVOutputFormat*> av_output_video_device_next;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVAppToDevMessageType, void*, nuint, int> avdevice_app_to_dev_control_message;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVDevToAppMessageType, void*, nuint, int> avdevice_dev_to_app_control_message;

        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVDeviceInfoList**, int> avdevice_list_devices;

        public delegate* unmanaged[Cdecl]<AVDeviceInfoList**, void> avdevice_free_list_devices;

        public delegate* unmanaged[Cdecl]<AVInputFormat*, sbyte*, AVDictionary*, AVDeviceInfoList**, int> avdevice_list_input_sources;

        public delegate* unmanaged[Cdecl]<AVOutputFormat*, sbyte*, AVDictionary*, AVDeviceInfoList**, int> avdevice_list_output_sinks;
    }
}
