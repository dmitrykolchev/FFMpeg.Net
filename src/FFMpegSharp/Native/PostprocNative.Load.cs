// <copyright file="PostprocNative.Load.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace FFMpegSharp.Native;

public partial class PostprocNative : AVNative<PostprocNative>
{
    private const string _LibraryPath = @".\postproc-57.dll";

    public static PostprocNative Initialize()
    {
        return Initialize(_LibraryPath);
    }
}
