using System;

/// <summary>
/// Access modifiers<br /><br />
/// Control which code can access a type or member.
/// </summary>
public class AccessModifierExample
{
    public string PublicValue = "Public";
    protected string ProtectedValue = "Protected";
    internal string InternalValue = "Internal";
    protected internal string ProtectedInternalValue = "Protected Internal";
    private string PrivateValue = "Private";
    private protected string PrivateProtectedValue = "Private Protected";
}


/// <summary>
/// Restrict accessor accessibility<br /><br />
/// Restrict one accessor while keeping the property accessible.
/// </summary>
public class Person
{
    public string? FirstName { get; private set; }

    public Person(string firstName)
    {
        FirstName = firstName;
    }
}


/// <summary>
/// Read-only property<br /><br />
/// A get-only property can be assigned from the type's constructor.
/// </summary>
public class ReadOnlyPerson
{
    public ReadOnlyPerson(string firstName) => FirstName = firstName;

    public string FirstName { get; }
}


/// <summary>
/// Init accessor<br /><br />
/// An init accessor allows assignment during object initialization.
/// </summary>
public class InitPerson
{
    public InitPerson() { }

    public InitPerson(string firstName) => FirstName = firstName;

    public string? FirstName { get; init; }
}


/// <summary>
/// Protected set accessor<br /><br />
/// The set accessor can only be used by the class or derived classes.
/// </summary>
public class ProtectedProperty
{
    private string _name = "Hello";

    public string Name
    {
        get
        {
            return _name;
        }
        protected set
        {
            _name = value;
        }
    }
}


/// <summary>
/// Read-write instance property<br /><br />
/// The property provides public access to an instance field.
/// </summary>
public class Employee
{
    public static int NumberOfEmployees;
    private static int _counter;
    private string _name;

    // A read-write instance property:
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    // A read-only static property:
    public static int Counter => _counter;

    // A Constructor:
    public Employee() => _counter = ++NumberOfEmployees;
}


/// <summary>
/// Static properties and fields<br /><br />
/// Static members belong to the class and are shared by all instances.
/// </summary>
public class EmployeeProgram
{
    static void Main()
    {
        // Create an initial instance of the Employee class
        Employee employee1 = new Employee { Name = "NameOne" };

        // Display the name and counter values
        Console.WriteLine(
            $"Employee 1: Name = {employee1.Name}, Counter = {Employee.Counter}");

        // Create a second instance of the Employee class
        Employee employee2 = new Employee { Name = "NameTwo" };

        // Display the name and counter values
        Console.WriteLine(
            $"Employee 2: Name = {employee2.Name}, Counter = {Employee.Counter}");

        employee2.Name = "NameThree";

        // Display the name and counter values
        Console.WriteLine(
            $"Employee 2: Name = {employee2.Name}, Counter = {Employee.Counter}");

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}


/// <summary>
/// Private accessors<br /><br />
/// A private setter allows the class to change the property internally.
/// </summary>
public class PrivateAccessorPerson
{
    private string _name = "N/A";
    private int _age = 0;

    // Declare a Name property of type string:
    public string Name
    {
        get
        {
            return _name;
        }
        private set
        {
            _name = value;
        }
    }

    // Declare an Age property of type int:
    public int Age
    {
        get
        {
            return _age;
        }
        private set
        {
            _age = value;
        }
    }

    public PrivateAccessorPerson()
    {
        Name = "N/A";
        Age = 0;
    }

    public void ChangeName(string newName)
    {
        Name = newName;
    }

    public void ChangeAge(int newAge)
    {
        Age = newAge;
    }
}


/// <summary>
/// Read-only property with get only<br /><br />
/// Omitting the set accessor makes the property read-only.
/// </summary>
public class ReadOnlyName
{
    private string _name = "Hello";

    public string Name
    {
        get
        {
            return _name;
        }
    }
}


/// <summary>
/// Public get with private set<br /><br />
/// The property can be read publicly but changed only inside the class.
/// </summary>
public class PrivateSetName
{
    private string _name = "Hello";

    public string Name
    {
        get
        {
            return _name;
        }
        private set
        {
            _name = value;
        }
    }

    public void ChangeName(string newName)
    {
        Name = newName;
    }
}
