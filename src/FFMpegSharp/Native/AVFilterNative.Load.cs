namespace FFMpegSharp.Native;

public partial class AVFilterNative : AVNative<AVFilterNative>
{
    private const string _LibraryPath = @".\avfilter-9.dll";

    public static AVFilterNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
