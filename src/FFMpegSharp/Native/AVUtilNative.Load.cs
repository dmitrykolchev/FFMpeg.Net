// <copyright file="AVUtilNative.Load.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace FFMpegSharp.Native;

public partial class AVUtilNative : AVNative<AVUtilNative>
{
    private const string _LibraryPath = @".\avutil-58.dll";

    public static AVUtilNative Initialize()
    {
        return Initialize(_LibraryPath);
    }

    [return: NativeTypeName("char *")]
    public unsafe sbyte* av_make_error_string([NativeTypeName("char *")] sbyte* errbuf, [NativeTypeName("size_t")] nuint errbuf_size, int errnum)
    {
        _ = av_strerror(errnum, errbuf, errbuf_size);
        return errbuf;
    }

    public unsafe void av_image_copy2([NativeTypeName("uint8_t *const[4]")] byte** dst_data, [NativeTypeName("const int[4]")] int* dst_linesizes, [NativeTypeName("uint8_t *const[4]")] byte** src_data, [NativeTypeName("const int[4]")] int* src_linesizes, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width, int height)
    {
        av_image_copy(dst_data, dst_linesizes, unchecked(src_data), src_linesizes, pix_fmt, width, height);
    }
}
