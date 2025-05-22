using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace FFMpegSharp.Native;
partial class AVCodecNative
{
    public static readonly AVCodecNative Instance;

    static AVCodecNative()
    {
        NativeLibrary.SetDllImportResolver(typeof(AVCodecNative).Assembly, ImportResolver);
        Instance = new ();
    }

    private AVCodecNative()
    {
        var fields = typeof(NativeApi).GetFields(BindingFlags.Public | BindingFlags.Instance);
        nint libPtr = NativeLibrary.Load(@"D:\LIBS\ffmpeg-6.1\bin\avcodec-60.dll");
        foreach (var field in fields)
        {
            nint methodPtr = NativeLibrary.GetExport(libPtr, field.Name);
            field.SetValue(this, methodPtr);
        }
    }

    private static nint ImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        if (libraryName == "avcodec")
        {
            return NativeLibrary.Load(@"D:\LIBS\ffmpeg-6.1\bin\avcodec-60.dll");
        }
        throw new InvalidOperationException($"unknown dynamic library {libraryName}");
    }
}
