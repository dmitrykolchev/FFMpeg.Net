namespace FFMpegSharp.Native;

public partial class SWScaleNative : AVNative<SWScaleNative>
{
    private const string _LibraryPath = @"D:\LIBS\ffmpeg-6.1\bin\swscale-7.dll";

    public static SWScaleNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
