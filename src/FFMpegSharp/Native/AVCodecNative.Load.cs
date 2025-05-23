namespace FFMpegSharp.Native;

public partial class AVCodecNative : AVNative<AVCodecNative>
{
    private const string _LibraryPath = @"D:\LIBS\ffmpeg-6.1\bin\avcodec-60.dll";

    public static AVCodecNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
