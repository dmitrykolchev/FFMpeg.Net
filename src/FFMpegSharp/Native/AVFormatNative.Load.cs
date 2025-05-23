// <copyright file="AVFormatNative.Load.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace FFMpegSharp.Native;

public partial class AVFormatNative : AVNative<AVFormatNative>
{
    private const string _LibraryPath = @".\avformat-60.dll";

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
