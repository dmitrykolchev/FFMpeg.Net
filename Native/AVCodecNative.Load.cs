using System.Reflection;
using System.Runtime.InteropServices;

namespace FFMpegSharp.Native;

public partial class AVCodecNative
{
    private const string LibraryPath = @"D:\LIBS\ffmpeg-6.1\bin\avcodec-60.dll";

    public static readonly AVCodecNative Instance;

    static AVCodecNative()
    {
        Instance = new();
    }

    private AVCodecNative()
    {
        FieldInfo[] fields = typeof(AVCodecNative).GetFields(BindingFlags.Public | BindingFlags.Instance);
        nint libPtr = NativeLibrary.Load(LibraryPath);
        foreach (FieldInfo field in fields)
        {
            nint methodPtr = NativeLibrary.GetExport(libPtr, field.Name);
            field.SetValue(this, methodPtr);
        }
    }
}
