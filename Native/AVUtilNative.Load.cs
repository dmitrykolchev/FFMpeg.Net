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

    [return: NativeTypeName("char *")]
    public unsafe sbyte* av_make_error_string([NativeTypeName("char *")] sbyte* errbuf, [NativeTypeName("size_t")] nuint errbuf_size, int errnum)
    {
        _ = av_strerror(errnum, errbuf, errbuf_size);
        return errbuf;
    }

    public unsafe void av_image_copy2([NativeTypeName("uint8_t *const[4]")] byte** dst_data, [NativeTypeName("const int[4]")] int* dst_linesizes, [NativeTypeName("uint8_t *const[4]")] byte** src_data, [NativeTypeName("const int[4]")] int* src_linesizes, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width, int height)
    {
        av_image_copy(dst_data, dst_linesizes, unchecked((byte**)(src_data)), src_linesizes, pix_fmt, width, height);
    }
}
