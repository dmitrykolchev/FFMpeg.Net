namespace FFMpegSharp.Native;

public partial class PostprocNative : AVNative<PostprocNative>
{
    private const string _LibraryPath = @".\postproc-57.dll";

    public static PostprocNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
