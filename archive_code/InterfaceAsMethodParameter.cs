/// <summary>
/// Interface as Method Parameter
/// <br /><br />
/// Demonstrates how interfaces can be used as method parameters to create
/// flexible and reusable code through polymorphism and loose coupling.
/// </summary>

namespace InterfaceAsMethodParameter
{
    /// <summary>
    /// Defines a contract for objects that can make a sound.
    /// </summary>
    public interface IAnimal
    {
        void MakeSound();
    }

    /// <summary>
    /// Implements the IAnimal interface with a dog sound.
    /// </summary>
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    /// <summary>
    /// Implements the IAnimal interface with a cat sound.
    /// </summary>
    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    /// <summary>
    /// Provides a method that accepts an IAnimal interface as a parameter.
    /// </summary>
    public class AnimalSound
    {
        public void MakeAnimalSound(IAnimal animal)
        {
            animal.MakeSound();
        }
    }

    public class Program
    {
        public static void Main()
        {
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();

            AnimalSound animalSound = new AnimalSound();

            animalSound.MakeAnimalSound(dog);
            animalSound.MakeAnimalSound(cat);
        }
    }
}
