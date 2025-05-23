// <copyright file="AVNative.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Reflection;
using System.Runtime.InteropServices;

namespace FFMpegSharp.Native;

public abstract class AVNative<T> where T : AVNative<T>, new()
{
    private static readonly Lock _sync = new();

    protected void Load(string library)
    {
        var rid = RuntimeInformation.RuntimeIdentifier;
        var location = Assembly.GetEntryAssembly()!.Location;
        var directory = Path.GetDirectoryName(location)!;
        var libraryPath = Path.Combine(directory, rid, library);
        var libPtr = NativeLibrary.Load(libraryPath);

        var fields = GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
        foreach (var field in fields)
        {
            var methodPtr = NativeLibrary.GetExport(libPtr, field.Name);
#if DEBUG
            Console.WriteLine($"{Path.GetFileName(library)}::{field.Name} = @{methodPtr}");
#endif
            field.SetValue(this, methodPtr);
        }
    }

    public static T Initialize(string libraryPath)
    {
        if (Instance is null)
        {
            lock (_sync)
            {
                if (Instance is null)
                {
                    Instance = new T
                    {
                        LibraryPath = libraryPath
                    };
                    Instance.Load(libraryPath);
                }
            }
        }
        return Instance;
    }

    public static T Instance { get; private set; } = null!;

    public string LibraryPath { get; private set; } = null!;
}
