
using System;
using System.Runtime.InteropServices;

/// <summary>
/// Class Finalizers
/// <br /><br />
/// Demonstrates class finalizers, their relationship with garbage collection,
/// cleanup of unmanaged resources, and the dispose pattern with IDisposable.
/// </summary>
namespace ClassFinalizers
{
    public class Car
    {
        ~Car()
        {
            // Cleanup statements would be placed here.
        }
    }

    public class Destroyer
    {
        public override string ToString() => GetType().Name;

        ~Destroyer() =>
            Console.WriteLine($"The {ToString()} finalizer is executing.");
    }

    public class ResourceHolder
    {
        private IntPtr unmanagedResource;

        public ResourceHolder()
        {
            // Represents an allocated unmanaged resource.
            unmanagedResource = new IntPtr(1);
        }

        ~ResourceHolder()
        {
            if (unmanagedResource != IntPtr.Zero)
            {
                // Represents freeing the unmanaged resource.
                unmanagedResource = IntPtr.Zero;
            }
        }
    }

    public class DisposableResourceHolder : IDisposable
    {
        private IntPtr unmanagedResource;
        private bool disposed = false;

        public DisposableResourceHolder()
        {
            // Represents an allocated unmanaged resource.
            unmanagedResource = new IntPtr(1);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free other managed objects.
                }

                // Free unmanaged resources.
                if (unmanagedResource != IntPtr.Zero)
                {
                    // Represents freeing the unmanaged resource.
                    unmanagedResource = IntPtr.Zero;
                }

                disposed = true;
            }
        }

        ~DisposableResourceHolder()
        {
            Dispose(false);
        }
    }

    public class Program
    {
        public static void Main()
        {
            var destroyer = new Destroyer();

            var resourceHolder = new ResourceHolder();

            using (var disposableResourceHolder = new DisposableResourceHolder())
            {
                Console.WriteLine(
                    "Disposable resource holder is in use.");
            }

            Console.WriteLine(
                "Dispose was called when the using statement completed.");

            GC.KeepAlive(destroyer);
            GC.KeepAlive(resourceHolder);
        }
    }
}
