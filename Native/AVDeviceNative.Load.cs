namespace FFMpegSharp.Native;

public partial class AVDeviceNative : AVNative<AVDeviceNative>
{
    private const string _LibraryPath = @"D:\LIBS\ffmpeg-6.1\bin\avdevice-60.dll";

    public static AVDeviceNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
