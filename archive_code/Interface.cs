/// <summary>
/// Interface
/// <br /><br />
/// Introduces interfaces as contracts that define required properties
/// and methods, and demonstrates how classes implement those contracts.
/// </summary>

namespace Interface
{
    /// <summary>
    /// Defines a contract for objects that can move.
    /// </summary>
    public interface IMove
    {
        int X { get; set; }
        int Y { get; set; }

        void Move();
    }

    /// <summary>
    /// Implements the IMove interface with its own movement behavior.
    /// </summary>
    public class Person : IMove
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Move()
        {
            Console.WriteLine("Person is moving.");
        }
    }

    /// <summary>
    /// Implements the IMove interface with its own movement behavior.
    /// </summary>
    public class Horse : IMove
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Move()
        {
            Console.WriteLine("Horse is galloping.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Person person = new Person
            {
                X = 10,
                Y = 20
            };

            Horse horse = new Horse
            {
                X = 30,
                Y = 40
            };

            person.Move();
            horse.Move();
        }
    }
}
