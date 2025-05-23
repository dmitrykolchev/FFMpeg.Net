namespace FFMpegSharp.Native;

public partial class AVCodecNative : AVNative<AVCodecNative>
{
    private const string _LibraryPath = @".\avcodec-60.dll";

    public static AVCodecNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
