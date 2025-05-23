// <copyright file="AVDeviceNative.Load.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace FFMpegSharp.Native;

public partial class AVDeviceNative : AVNative<AVDeviceNative>
{
    private const string _LibraryPath = @".\avdevice-60.dll";

    public static AVDeviceNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
