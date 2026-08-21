using System;

namespace InheritanceExtendDerivedClass;

/// <summary>
/// Extend a Derived Class with New Members
/// <br /><br />
/// Demonstrates how a derived class inherits members from a base class,
/// adds new members, handles naming conflicts, and intentionally hides
/// inherited members by using the new keyword.
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create instances of the base class and the derived class.
        BaseClass baseClass = new BaseClass();
        DerivedClass derivedClass = new DerivedClass();
        BaseClass baseClassReferencingDerivedClass = new DerivedClass();

        // Access properties and methods of the base class.
        Console.WriteLine($"\n{baseClass.Property1}");
        Console.WriteLine($"{baseClass.Property2}");
        baseClass.Method1();
        baseClass.Method2();

        // Access properties and methods of the derived class.
        Console.WriteLine($"\n{derivedClass.Property1}");
        Console.WriteLine($"{derivedClass.Property2}");
        derivedClass.Method1();
        derivedClass.Method2();

        // Access properties and methods through a base class reference
        // that references a derived class instance.
        Console.WriteLine($"\n{baseClassReferencingDerivedClass.Property1}");
        Console.WriteLine($"{baseClassReferencingDerivedClass.Property2}");
        baseClassReferencingDerivedClass.Method1();
        baseClassReferencingDerivedClass.Method2();

        // The following would cause a compile-time error because
        // Method2 is not defined by BaseClass as a separate derived-only member.
        // baseClassReferencingDerivedClass.Method2();
    }
}

/// <summary>
/// Represents the base class that provides inherited members.
/// </summary>
public class BaseClass
{
    public string Property1 { get; set; } = "Base - Property1";

    public string Property2 { get; set; } = "Base - Property2";

    public void Method1()
    {
        Console.WriteLine("Base - Method1");
    }

    public void Method2()
    {
        Console.WriteLine("Base - Method2");
    }
}

/// <summary>
/// Represents a derived class that extends BaseClass and intentionally
/// hides members inherited from the base class by using the new keyword.
/// </summary>
public class DerivedClass : BaseClass
{
    public new string Property2 { get; set; } = "Derived - Property2";

    public new void Method2()
    {
        Console.WriteLine("Derived - Method2");
    }
}
