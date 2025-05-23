namespace FFMpegSharp.Native;

public partial class PostprocNative : AVNative<PostprocNative>
{
    private const string _LibraryPath = @"D:\LIBS\ffmpeg-6.1\bin\postproc-57.dll";

    public static PostprocNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
