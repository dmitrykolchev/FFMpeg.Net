// <copyright file="SWScale.Load.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace FFMpegSharp.Native;

public partial class SWScaleNative : AVNative<SWScaleNative>
{
    private const string _LibraryPath = @".\swscale-7.dll";

    public static SWScaleNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
