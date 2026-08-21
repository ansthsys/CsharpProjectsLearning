using System;

namespace InheritanceAccessBaseClassMembers;

/// <summary>
/// Access Base Class Members from a Derived Class
/// <br /><br />
/// Demonstrates how the base keyword is used to access base class
/// methods and properties, call base class constructors, and reuse
/// base class behavior from overridden members in a derived class.
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create an instance of the derived class.
        DerivedClass derivedClass = new DerivedClass(
            "Derived1 - Property1",
            "Derived1 - Property2");

        // Demonstrate the overridden methods of the derived class.
        Console.WriteLine("Calling the methods of DerivedClass...\n");
        Console.WriteLine(
            $"Method1 in the derived class returns: {derivedClass.Method1()}");

        derivedClass.Method2();

        // Demonstrate the Vehicle and Car example.
        Car car = new Car(100, 50, 4);

        Console.WriteLine(
            $"\nSpeed: {car.Speed}, " +
            $"Fuel: {car.Fuel}, " +
            $"NumberOfDoors: {car.NumberOfDoors}, " +
            $"TrunkCapacity: {car.TrunkCapacity}");

        car.Drive();
    }
}

/// <summary>
/// Represents an abstract base class that provides common properties,
/// a constructor, and virtual methods that can be accessed by derived classes.
/// </summary>
public abstract class BaseClass
{
    public abstract string Property1 { get; set; }

    public virtual string Property2 { get; set; }

    public BaseClass(string property1, string property2)
    {
        Property1 = property1;
        Property2 = property2;
    }

    public virtual string Method1()
    {
        return "base.Method1 results";
    }

    public virtual bool Method2()
    {
        Console.WriteLine(
            "Method2 in the base class implements common behavior and returns true/false");

        return true;
    }
}

/// <summary>
/// Represents a derived class that uses the base keyword to access
/// base class properties, methods, and constructor behavior.
/// </summary>
public class DerivedClass : BaseClass
{
    public override string Property1 { get; set; }

    public new string Property2 { get; set; }

    public DerivedClass(string property1, string property2)
        : base(property1, "Base - Property2")
    {
        Property1 = property1;
        Property2 = property2;
    }

    public override string Method1()
    {
        // Call the base class implementation and extend its result.
        Console.WriteLine(
            $"Method1 in the derived class calls base.Method1. " +
            $"base.Method1 returns: {base.Method1()}");

        return $"{base.Method1()} - plus information specific to DerivedClass";
    }

    public override bool Method2()
    {
        // Call the base class method to reuse common behavior.
        Console.WriteLine(
            "\nMethod2 in the derived class calls base.Method2 " +
            "(reuses the base class implementation)");

        bool baseMethod2Success = base.Method2();

        // Access the base class property explicitly.
        string baseProperty2Value = base.Property2;

        Console.WriteLine(
            $"Method2 in the derived class accesses base class Property2: " +
            $"{baseProperty2Value}");

        // Extend the base class behavior with derived class logic.
        if (baseMethod2Success &&
            baseProperty2Value == "Base - Property2")
        {
            Console.WriteLine(
                "\nMethod2 in the derived class uses base class members " +
                "to modify and extend functionality");

            return true;
        }

        Console.WriteLine(
            "Method2 in the derived class can implement alternate behavior");

        return false;
    }
}

/// <summary>
/// Represents an abstract base class for a vehicle and demonstrates
/// how a derived class can initialize and extend base class behavior.
/// </summary>
public abstract class Vehicle
{
    public virtual int Speed { get; set; }

    public virtual int Fuel { get; set; }

    public Vehicle(int speed, int fuel)
    {
        Speed = speed;
        Fuel = fuel;
    }

    public virtual void Drive()
    {
        Console.WriteLine("Vehicle is driving");
    }
}

/// <summary>
/// Represents a car that initializes the Vehicle base class by using
/// the base constructor and extends the base Drive behavior.
/// </summary>
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public int TrunkCapacity { get; set; }

    public Car(int speed, int fuel, int numberOfDoors)
        : base(speed, fuel)
    {
        NumberOfDoors = numberOfDoors;

        // Initialize TrunkCapacity using properties initialized by
        // the Vehicle base class.
        TrunkCapacity = CalculateTrunkCapacity(Speed, Fuel);
    }

    private int CalculateTrunkCapacity(int speed, int fuel)
    {
        return (speed + fuel) / 2;
    }

    public override void Drive()
    {
        // Reuse the base class implementation first.
        base.Drive();

        // Add behavior specific to the derived class.
        Console.WriteLine("Car is driving with additional features");
    }
}
