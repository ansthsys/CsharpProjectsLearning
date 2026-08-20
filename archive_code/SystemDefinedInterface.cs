/// <summary>
/// System-Defined Interfaces
/// <br /><br />
/// Demonstrates common system-defined interfaces in C#, including
/// IEquatable, IEnumerable, IDisposable, and IComparable.
/// </summary>

using System;
using System.Collections;

namespace SystemDefinedInterface
{
    /// <summary>
    /// IEquatable Implementation
    /// <br /><br />
    /// Demonstrates how a class implements IEquatable to define
    /// equality comparison between objects of the same type.
    /// </summary>
    public class Car : IEquatable<Car>
    {
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;

        public bool Equals(Car? other)
        {
            if (other == null)
            {
                return false;
            }

            return Make == other.Make && Model == other.Model;
        }
    }

    /// <summary>
    /// Interface Property Access
    /// <br /><br />
    /// Demonstrates that a class can implement an interface property
    /// with additional accessors.
    /// </summary>
    public class ExampleClass : IExampleInterface
    {
        public string Name { get; set; } = string.Empty;
    }

    public interface IExampleInterface
    {
        string Name { get; }
    }

    /// <summary>
    /// IEnumerable Implementation
    /// <br /><br />
    /// Demonstrates how a class implements IEnumerable to provide
    /// a mechanism for enumerating its elements.
    /// </summary>
    public class MyCollection : IEnumerable
    {
        private int[] _items = { 1, 2, 3, 4, 5 };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                yield return _items[i];
            }
        }
    }

    /// <summary>
    /// IDisposable Implementation
    /// <br /><br />
    /// Demonstrates how a class implements IDisposable to release
    /// resources deterministically and uses a finalizer as a safety net.
    /// </summary>
    public class ResourceHolder : IDisposable
    {
        private bool _disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Free managed resources.
                }

                // Free unmanaged resources.
                _disposed = true;
            }
        }

        ~ResourceHolder()
        {
            Dispose(false);
        }
    }

    /// <summary>
    /// IComparable Implementation
    /// <br /><br />
    /// Demonstrates how a class implements IComparable to compare
    /// instances based on a selected value.
    /// </summary>
    public class Person : IComparable<Person>
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public int CompareTo(Person? other)
        {
            if (other == null)
            {
                return 1;
            }

            return Age.CompareTo(other.Age);
        }
    }

    /// <summary>
    /// Demonstrates the system-defined interface implementations
    /// used in this chapter.
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            Car car1 = new Car
            {
                Make = "Toyota",
                Model = "Corolla"
            };

            Car car2 = new Car
            {
                Make = "Toyota",
                Model = "Corolla"
            };

            Console.WriteLine(car1.Equals(car2));

            ExampleClass example = new ExampleClass
            {
                Name = "Example"
            };

            Console.WriteLine(example.Name);

            MyCollection collection = new MyCollection();

            foreach (int item in collection)
            {
                Console.WriteLine(item);
            }

            using (ResourceHolder resource = new ResourceHolder())
            {
                Console.WriteLine("Resource is in use.");
            }

            Person person1 = new Person
            {
                Name = "Lisa",
                Age = 40
            };

            Person person2 = new Person
            {
                Name = "Sandy",
                Age = 35
            };

            Console.WriteLine(person1.CompareTo(person2));
        }
    }
}
