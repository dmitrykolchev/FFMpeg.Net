// <copyright file="AVCodecNative.Load.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace FFMpegSharp.Native;

public partial class AVCodecNative : AVNative<AVCodecNative>
{
    private const string _LibraryPath = @".\avcodec-60.dll";

    public static AVCodecNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
