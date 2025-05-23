// <copyright file="SWResample.Load.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace FFMpegSharp.Native;

public partial class SWResampleNative : AVNative<SWResampleNative>
{
    private const string _LibraryPath = @".\swresample-4.dll";

    public static SWResampleNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
