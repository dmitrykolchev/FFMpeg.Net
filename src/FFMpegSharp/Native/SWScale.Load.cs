namespace FFMpegSharp.Native;

public partial class SWScaleNative : AVNative<SWScaleNative>
{
    private const string _LibraryPath = @".\swscale-7.dll";

    public static SWScaleNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
