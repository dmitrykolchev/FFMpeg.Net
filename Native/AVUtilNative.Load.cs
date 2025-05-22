using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace FFMpegSharp.Native;

partial class AVUtilNative
{
    private const string LibraryPath = @"D:\LIBS\ffmpeg-6.1\bin\avutil-58.dll";

    public static readonly AVUtilNative Instance;

    static AVUtilNative()
    {
        Instance = new ();
    }

    private AVUtilNative()
    {
        var fields = typeof(AVUtilNative).GetFields(BindingFlags.Public | BindingFlags.Instance);
        nint libPtr = NativeLibrary.Load(LibraryPath);
        foreach (var field in fields)
        {
            nint methodPtr = NativeLibrary.GetExport(libPtr, field.Name);
            field.SetValue(this, methodPtr);
        }
    }
}
