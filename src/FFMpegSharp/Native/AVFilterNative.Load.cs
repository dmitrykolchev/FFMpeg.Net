// <copyright file="AVFilterNative.Load.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace FFMpegSharp.Native;

public partial class AVFilterNative : AVNative<AVFilterNative>
{
    private const string _LibraryPath = @".\avfilter-9.dll";

    public static AVFilterNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
