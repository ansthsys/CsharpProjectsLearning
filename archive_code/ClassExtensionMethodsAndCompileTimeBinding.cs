using ExtensionMethodDemo.PersonExtensionsNamespace;
using ExtensionMethodDemo.PersonNamespace;

namespace ExtensionMethodDemo.PersonNamespace
{
    /// <summary>
    /// Defines the type that will be extended by extension methods.<br /><br />
    /// The class contains its own instance method and properties.
    /// </summary>
    public class Person
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine(
                $"Hi, I'm {FirstName} {LastName}, and I'm {Age} years old.");
        }
    }
}

namespace ExtensionMethodDemo.PersonExtensionsNamespace
{
    using ExtensionMethodDemo.PersonNamespace;

    /// <summary>
    /// Defines extension methods for the Person class.<br /><br />
    /// Extension methods are static methods called like instance methods.
    /// </summary>
    public static class PersonExtensions
    {
        /// <summary>
        /// Adds a method to display the person's full name.
        /// </summary>
        public static void DisplayFullName(this Person person)
        {
            Console.WriteLine(
                $"Full Name: {person.FirstName} {person.LastName}");
        }

        /// <summary>
        /// Adds a method to check whether the person is an adult.
        /// </summary>
        public static bool IsAdult(this Person person)
        {
            return person.Age >= 18;
        }

        /// <summary>
        /// This method is not an extension method because it has no
        /// extension receiver parameter.
        /// </summary>
        public static void Introduce()
        {
            Console.WriteLine("Extension - Hi, it's nice to meet you.");
        }

        /// <summary>
        /// Adds an overloaded Introduce method with a custom greeting.
        /// </summary>
        public static void Introduce(
            this Person person,
            string greeting)
        {
            Console.WriteLine(
                $"{greeting}, I'm {person.FirstName} {person.LastName}, and I'm {person.Age} years old.");
        }
    }
}

namespace ExtensionMethodDemo
{
    using ExtensionMethodDemo.PersonExtensionsNamespace;
    using ExtensionMethodDemo.PersonNamespace;

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the Person class.
            Person person1 = new Person
            {
                FirstName = "FName1",
                LastName = "LName1",
                Age = 25
            };

            Person person2 = new Person
            {
                FirstName = "FName2",
                LastName = "LName2",
                Age = 16
            };

            // The instance method has priority over an extension method.
            person1.Introduce();
            person2.Introduce();

            // Call extension methods as if they were instance methods.
            person1.DisplayFullName();
            Console.WriteLine(
                $"Is {person1.FirstName} an adult? {person1.IsAdult()}");

            person2.DisplayFullName();
            Console.WriteLine(
                $"Is {person2.FirstName} an adult? {person2.IsAdult()}");

            // The extension method is selected because the argument matches
            // its signature and the instance class has no matching method.
            person1.Introduce("Hello");
            person2.Introduce("Greetings");
        }
    }
}

/*
Output:
Hi, I'm FName1 LName1, and I'm 25 years old.
Hi, I'm FName2 LName2, and I'm 16 years old.
Full Name: FName1 LName1
Is FName1 an adult? True
Full Name: FName2 LName2
Is FName2 an adult? False
Hello, I'm FName1 LName1, and I'm 25 years old.
Greetings, I'm FName2 LName2, and I'm 16 years old.
*/
