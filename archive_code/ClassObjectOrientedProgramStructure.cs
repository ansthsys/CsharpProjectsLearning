namespace ExamineStructureObjectOrientedPrograms;

using System;

/// <summary>
/// Examine the structure of object-oriented programs.<br />
/// <br />
/// Demonstrates encapsulation, class structure, object creation,
/// initialization, usage, and the class lifecycle.
/// </summary>
public class Person
{
    /// <summary>
    /// Encapsulated private fields.<br />
    /// <br />
    /// Private fields hide the internal state of the object
    /// from direct access outside the class.
    /// </summary>
    private string firstName = "";
    private string lastName = "";
    private int age;

    /// <summary>
    /// Provides controlled access to the first name.<br />
    /// <br />
    /// The property exposes the private field through get and set accessors.
    /// </summary>
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    /// <summary>
    /// Provides controlled access to the last name.<br />
    /// <br />
    /// The property exposes the private field through get and set accessors.
    /// </summary>
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    /// <summary>
    /// Provides controlled access to the age.<br />
    /// <br />
    /// The setter validates the value to prevent an invalid negative age.
    /// </summary>
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                throw new ArgumentException("Age can't be negative");
            }
        }
    }

    /// <summary>
    /// Defines behavior for the Person object.<br />
    /// <br />
    /// The method uses the object's properties without exposing
    /// its internal fields directly.
    /// </summary>
    public void Introduce()
    {
        Console.WriteLine(
            $"Hi, I'm {FirstName} {LastName}, and I'm {Age} years old."
        );
    }
}

/// <summary>
/// Demonstrates creating and using Person objects.<br />
/// <br />
/// The example shows instantiation, initialization, usage,
/// and encapsulation in an object-oriented program.
/// </summary>
public class Program
{
    /// <summary>
    /// Creates and initializes a Person object.<br />
    /// <br />
    /// The new keyword creates the instance, while the object initializer
    /// assigns values to its properties.
    /// </summary>
    public static void Main()
    {
        Person person1 = new Person
        {
            FirstName = "Tim",
            LastName = "Shao",
            Age = 25
        };

        /// <summary>
        /// Uses the object's method and properties.<br />
        /// <br />
        /// The object interacts with its data through its public interface.
        /// </summary>
        person1.Introduce();

        Console.WriteLine($"Name: {person1.FirstName}");
        Console.WriteLine($"Age: {person1.Age}");

        /// <summary>
        /// Demonstrates controlled modification through encapsulation.<br />
        /// <br />
        /// The Age property validates the assigned value before updating
        /// the private age field.
        /// </summary>
        person1.Age = 26;

        Console.WriteLine($"Updated Age: {person1.Age}");
    }
}
