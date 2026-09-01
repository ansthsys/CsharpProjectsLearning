using System;

namespace DelegateVariance
{
  /// <summary>
  /// Examine Variance in Delegates and Generics
  /// <br /><br />
  /// Demonstrates covariance (returning a more derived type using 'out')
  /// and contravariance (accepting a less derived parameter type using 'in')
  /// across custom delegates, strongly typed delegates (Func and Action),
  /// and generic interfaces.
  /// </summary>

  #region Models
  public class Animal { }
  public class Dog : Animal { }

  public class Person { }
  public class Employee : Person { }
  #endregion

  #region Custom Delegate & Generic Interfaces
  public delegate Animal AnimalDelegate(Dog dog);

  public interface ICovariant<out T>
  {
    T Get();
  }

  public interface IContravariant<in T>
  {
    void Set(T value);
  }

  public class CovariantExample : ICovariant<Dog>
  {
    public Dog Get() => new Dog();
  }

  public class ContravariantExample : IContravariant<Animal>
  {
    public void Set(Animal value)
    {
      Console.WriteLine($"Received animal of type: {value.GetType().Name}");
    }
  }
  #endregion

  public class CustomDelegateVarianceDemo
  {
    public static Animal GetAnimal(Dog dog) => new Animal();
    public static Dog GetDog(Dog dog) => new Dog();
    public static Animal GetAnimalFromAnimal(Animal animal) => new Animal();

    public static void Run()
    {
      AnimalDelegate del;

      // 1. Exact match
      del = GetAnimal;
      Animal a1 = del(new Dog());
      Console.WriteLine("Exact match assigned successfully.");

      // 2. Covariance: GetDog returns Dog (more derived than Animal)
      del = GetDog;
      Animal a2 = del(new Dog());
      Console.WriteLine("Covariant return method assigned successfully.");

      // 3. Contravariance: GetAnimalFromAnimal accepts Animal (less derived than Dog)
      del = GetAnimalFromAnimal;
      Animal a3 = del(new Dog());
      Console.WriteLine("Contravariant parameter method assigned successfully.");
    }
  }

  public class StronglyTypedDelegateVarianceDemo
  {
    public static Employee FindEmployee(string title) => new Employee();
    public static void HandleAnimal(Animal animal) => Console.WriteLine($"Handled animal: {animal.GetType().Name}");

    public static void Run()
    {
      // Func Covariance: Employee is more derived than Person
      Func<string, Person> func = FindEmployee;
      Person person = func("Manager");
      Console.WriteLine($"Func returned object of type: {person.GetType().Name}");

      // Action Contravariance: HandleAnimal accepts Animal, which can process a Dog
      Action<Dog> action = HandleAnimal;
      action(new Dog());
    }
  }

  public class GenericVarianceDemo
  {
    public static void Run()
    {
      // Covariance via interface (out)
      ICovariant<Animal> covariant = new CovariantExample();
      Animal animal = covariant.Get();
      Console.WriteLine($"Covariant interface returned type: {animal.GetType().Name}");

      // Contravariance via interface (in)
      IContravariant<Dog> contravariant = new ContravariantExample();
      contravariant.Set(new Dog());
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("=== Custom Delegate Variance Demo ===");
      CustomDelegateVarianceDemo.Run();

      Console.WriteLine("\n=== Strongly Typed Delegate Variance Demo ===");
      StronglyTypedDelegateVarianceDemo.Run();

      Console.WriteLine("\n=== Generic Interface Variance Demo ===");
      GenericVarianceDemo.Run();
    }
  }
}
