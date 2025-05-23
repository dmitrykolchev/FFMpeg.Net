using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace FFMpegSharp.Native;

partial class AVFormatNative
{
    private const string LibraryPath = @"D:\LIBS\ffmpeg-6.1\bin\avformat-60.dll";

    public static readonly AVFormatNative Instance;

    static AVFormatNative()
    {
        Instance = new ();
    }

    private AVFormatNative()
    {
        var fields = typeof(AVFormatNative).GetFields(BindingFlags.Public | BindingFlags.Instance);
        nint libPtr = NativeLibrary.Load(LibraryPath);
        foreach (var field in fields)
        {
            nint methodPtr = NativeLibrary.GetExport(libPtr, field.Name);
            field.SetValue(this, methodPtr);
        }
    }

    [return: NativeTypeName("int64_t")]
    public unsafe long avio_tell(AVIOContext* s)
    {
        return avio_seek(s, 0, 1);
    }
}
