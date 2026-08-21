using System;

namespace InheritanceOverrideDerivedClass;

/// <summary>
/// Override Properties and Methods in a Derived Class
/// <br /><br />
/// Demonstrates how virtual and abstract members can be overridden in a
/// derived class, how the override keyword differs from new member hiding,
/// how abstract base classes work, and how inherited Object members such
/// as ToString, Equals, and GetHashCode can be overridden.
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create instances of the derived classes.
        DerivedClass1 derivedClass1 = new DerivedClass1();

        DerivedClass2 derivedClass2a = new DerivedClass2
        {
            Property1 = "Value1",
            Property2 = "Value2"
        };

        DerivedClass2 derivedClass2b = new DerivedClass2
        {
            Property1 = "Value1",
            Property2 = "Value2"
        };

        DerivedClass2 derivedClass2c = new DerivedClass2
        {
            Property1 = "Value3",
            Property2 = "Value4"
        };

        // Demonstrate overridden virtual and hidden members
        // using a derived class reference.
        Console.WriteLine("\nDemonstrating DerivedClass1:");
        Console.WriteLine(derivedClass1.Property1);
        Console.WriteLine(derivedClass1.Property2);
        derivedClass1.Method1();
        derivedClass1.Method2();

        // Demonstrate overridden Object class methods.
        Console.WriteLine("\nDemonstrating Object class methods for DerivedClass2:");
        Console.WriteLine($"ToString: {derivedClass2a.ToString()}");
        Console.WriteLine(
            $"Equals (derivedClass2a vs derivedClass2b): " +
            $"{derivedClass2a.Equals(derivedClass2b)}");
        Console.WriteLine(
            $"Equals (derivedClass2a vs derivedClass2c): " +
            $"{derivedClass2a.Equals(derivedClass2c)}");
        Console.WriteLine(
            $"GetHashCode (derivedClass2a): " +
            $"{derivedClass2a.GetHashCode()}");
        Console.WriteLine(
            $"GetHashCode (derivedClass2b): " +
            $"{derivedClass2b.GetHashCode()}");
        Console.WriteLine(
            $"GetHashCode (derivedClass2c): " +
            $"{derivedClass2c.GetHashCode()}");

        // Demonstrate polymorphism with a base class reference.
        BaseClass baseClassReferencingDerivedClass = new DerivedClass2
        {
            Property1 = "Value1",
            Property2 = "Value2"
        };

        Console.WriteLine("\nDemonstrating a base class reference:");
        Console.WriteLine(baseClassReferencingDerivedClass.Property1);
        Console.WriteLine(baseClassReferencingDerivedClass.Property2);
        baseClassReferencingDerivedClass.Method1();
        baseClassReferencingDerivedClass.Method2();
    }
}

/// <summary>
/// Represents an abstract base class that defines abstract and virtual
/// members that can be implemented or overridden by derived classes.
/// </summary>
public abstract class BaseClass
{
    public abstract string Property1 { get; set; }

    public virtual string Property2 { get; set; } = "Base - Property2";

    public abstract void Method1();

    public void Method2()
    {
        Console.WriteLine("Base - Method2");
    }
}

/// <summary>
/// Represents a derived class that overrides abstract members and hides
/// non-virtual members inherited from the base class.
/// </summary>
public class DerivedClass1 : BaseClass
{
    public override string Property1 { get; set; } = "Derived1 - Property1";

    public new string Property2 { get; set; } = "Derived1 - Property2";

    public override void Method1()
    {
        Console.WriteLine("Derived1 - Method1");
    }

    public new void Method2()
    {
        Console.WriteLine("Derived1 - Method2");
    }
}

/// <summary>
/// Represents a derived class that overrides inherited members and
/// provides custom implementations of Object class members.
/// </summary>
public class DerivedClass2 : BaseClass
{
    public override string Property1 { get; set; } = "Derived2 - Property1";

    public new string Property2 { get; set; } = "Derived2 - Property2";

    public override void Method1()
    {
        Console.WriteLine("Derived2 - Method1");
    }

    public new void Method2()
    {
        Console.WriteLine("Derived2 - Method2");
    }

    /// <summary>
    /// Returns a string representation of the current object.
    /// </summary>
    public override string ToString()
    {
        return $"DerivedClass2: Property1 = {Property1}, Property2 = {Property2}";
    }

    /// <summary>
    /// Determines whether another object has the same property values.
    /// </summary>
    public override bool Equals(object? obj)
    {
        if (obj is DerivedClass2 other)
        {
            return Property1 == other.Property1 &&
                   Property2 == other.Property2;
        }

        return false;
    }

    /// <summary>
    /// Returns a hash code based on Property1 and Property2.
    /// </summary>
    public override int GetHashCode()
    {
        return HashCode.Combine(Property1, Property2);
    }
}
