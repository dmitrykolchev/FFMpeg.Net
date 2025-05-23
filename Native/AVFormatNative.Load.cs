namespace FFMpegSharp.Native;

public partial class AVFormatNative : AVNative<AVFormatNative>
{
    private const string _LibraryPath = @"D:\LIBS\ffmpeg-6.1\bin\avformat-60.dll";

    public static AVFormatNative Initialize()
    {
        return Initialize(_LibraryPath);
    }

    [return: NativeTypeName("int64_t")]
    public unsafe long avio_tell(AVIOContext* s)
    {
        return avio_seek(s, 0, 1);
    }
}
