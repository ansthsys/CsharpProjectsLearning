using System;

namespace ImplementPolymorphicBehaviorInheritance
{
    /// <summary>
    /// Implement Polymorphic Behavior - Inheritance-Based Polymorphism
    /// <br /><br />
    /// Demonstrates inheritance-based polymorphism, implicit and explicit
    /// casting, safe casting with is and as, and common pitfalls when
    /// implementing polymorphic behavior in C#.
    /// </summary>

    // Base class
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    // Derived class
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    // Derived class
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat meows.");
        }
    }

    // Derived class
    public class Cow : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cow moos.");
        }
    }

    // Base class for casting examples
    public class BankAccount
    {
    }

    // Derived class for casting examples
    public class CheckingAccount : BankAccount
    {
    }

    public class Program
    {
        public static void Main()
        {
            // Inheritance-based polymorphism

            Animal[] animals = new Animal[3];

            Animal animal1 = new Dog();
            Animal animal2 = new Cat();
            Animal animal3 = new Cow();

            animals[0] = animal1;
            animals[1] = animal2;
            animals[2] = animal3;

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }

            // Implicit casting: derived class to base class

            CheckingAccount checkingAccount = new CheckingAccount();
            BankAccount account = checkingAccount;

            // Explicit casting: base class to derived class

            CheckingAccount convertedAccount = (CheckingAccount)account;

            // Using the is keyword with pattern matching

            if (account is CheckingAccount checkingAccountFromPattern)
            {
                Console.WriteLine("The account is a CheckingAccount.");
            }

            // Using the is keyword followed by explicit casting

            if (account is CheckingAccount)
            {
                CheckingAccount checkingAccountFromCast =
                    (CheckingAccount)account;

                Console.WriteLine("The account was explicitly cast.");
            }

            // Using the as keyword

            CheckingAccount? checkingAccountFromAs =
                account as CheckingAccount;

            if (checkingAccountFromAs != null)
            {
                Console.WriteLine("The account was successfully cast using as.");
            }
        }
    }
}
