using System.Reflection;
using System.Runtime.InteropServices;

namespace FFMpegSharp.Native;

public abstract class AVNative<T> where T : AVNative<T>, new()
{
    private static readonly Lock _sync = new();

    protected void Load(string libraryPath)
    {
        FieldInfo[] fields = GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
        nint libPtr = NativeLibrary.Load(libraryPath);
        foreach (FieldInfo field in fields)
        {
            nint methodPtr = NativeLibrary.GetExport(libPtr, field.Name);
#if DEBUG
            Console.WriteLine($"{Path.GetFileName(libraryPath)}::{field.Name} = @{methodPtr}");
#endif
            field.SetValue(this, methodPtr);
        }
    }

    public static T Initialize(string libraryPath)
    {
        if (Instance is null)
        {
            lock(_sync)
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
