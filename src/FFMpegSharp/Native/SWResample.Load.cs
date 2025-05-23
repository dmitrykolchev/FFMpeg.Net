namespace FFMpegSharp.Native;

public partial class SWResampleNative : AVNative<SWResampleNative>
{
    private const string _LibraryPath = @"D:\LIBS\ffmpeg-6.1\bin\swresample-4.dll";

    public static SWResampleNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
