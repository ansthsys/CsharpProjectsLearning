using System;

/// <summary>
/// Implement Polymorphic Behavior - Interface-Based Polymorphism
/// <br /><br />
/// Demonstrates interface-based polymorphism by defining contracts that
/// classes must implement, enabling polymorphic behavior without relying
/// on class inheritance. Also demonstrates classes implementing multiple
/// interfaces to define different aspects of behavior.
/// </summary>
namespace ImplementPolymorphicBehaviorInterface
{
  /// <summary>
  /// Defines a contract for objects that can make a sound.
  /// </summary>
  public interface ISound
  {
    void MakeSound();
  }

  /// <summary>
  /// Defines a contract for objects that can move.
  /// </summary>
  public interface IMovable
  {
    void Move();
  }

  /// <summary>
  /// Represents a dog that implements sound and movement behavior.
  /// </summary>
  public class Dog : ISound, IMovable
  {
    public void MakeSound()
    {
      Console.WriteLine("The dog barks.");
    }

    public void Move()
    {
      Console.WriteLine("The dog runs.");
    }
  }

  /// <summary>
  /// Represents a cat that implements sound and movement behavior.
  /// </summary>
  public class Cat : ISound, IMovable
  {
    public void MakeSound()
    {
      Console.WriteLine("The cat meows.");
    }

    public void Move()
    {
      Console.WriteLine("The cat jumps.");
    }
  }

  /// <summary>
  /// Represents a cow that implements sound and movement behavior.
  /// </summary>
  public class Cow : ISound, IMovable
  {
    public void MakeSound()
    {
      Console.WriteLine("The cow moos.");
    }

    public void Move()
    {
      Console.WriteLine("The cow walks.");
    }
  }

  /// <summary>
  /// Represents a doorbell that implements sound behavior.
  /// </summary>
  public class Doorbell : ISound
  {
    public void MakeSound()
    {
      Console.WriteLine("The doorbell rings.");
    }
  }

  /// <summary>
  /// Represents a car horn that implements sound behavior.
  /// </summary>
  public class CarHorn : ISound
  {
    public void MakeSound()
    {
      Console.WriteLine("The car horn honks.");
    }
  }

  /// <summary>
  /// Demonstrates interface-based polymorphism.
  /// </summary>
  internal class Program
  {
    private static void Main()
    {
      // Create an array of ISound objects.
      ISound[] soundObjects = new ISound[5];

      ISound object1 = new Dog();
      ISound object2 = new Cat();
      ISound object3 = new Cow();
      ISound object4 = new Doorbell();
      ISound object5 = new CarHorn();

      soundObjects[0] = object1;
      soundObjects[1] = object2;
      soundObjects[2] = object3;
      soundObjects[3] = object4;
      soundObjects[4] = object5;

      // Demonstrate polymorphism with ISound.
      Console.WriteLine("Demonstrating ISound polymorphism:");

      foreach (ISound currentObject in soundObjects)
      {
        currentObject.MakeSound();
      }

      // Create an array of IMovable objects.
      IMovable[] movableObjects = new IMovable[3];

      IMovable movableObject1 = new Dog();
      IMovable movableObject2 = new Cat();
      IMovable movableObject3 = new Cow();

      movableObjects[0] = movableObject1;
      movableObjects[1] = movableObject2;
      movableObjects[2] = movableObject3;

      // Demonstrate polymorphism with IMovable.
      Console.WriteLine("\nDemonstrating IMovable polymorphism:");

      foreach (IMovable currentObject in movableObjects)
      {
        currentObject.Move();
      }

      // Demonstrate objects with single and multiple interfaces.
      Console.WriteLine(
          "\nDemonstrating objects with single and multiple interfaces:");

      Dog dog = new Dog();
      Cat cat = new Cat();
      Cow cow = new Cow();
      Doorbell doorbell = new Doorbell();
      CarHorn carHorn = new CarHorn();

      dog.MakeSound();
      dog.Move();

      cat.MakeSound();
      cat.Move();

      cow.MakeSound();
      cow.Move();

      doorbell.MakeSound();

      carHorn.MakeSound();
    }
  }
}
