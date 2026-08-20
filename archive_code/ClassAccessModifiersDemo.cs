using System;

/// <summary>
/// Demonstrates access modifiers, private constructors,
/// static classes, static members, and nested classes.
/// </summary>
public class ClassAccessModifiersDemo
{
    /// <summary>
    /// Entry point of the program.
    /// </summary>
    public static void Main()
    {
        // Accessing a static member through the class name.
        Counter.IncrementCount();
        Counter.IncrementCount();

        Console.WriteLine($"Counter: {Counter.CurrentCount}");

        // Creating an instance of a normal class.
        Automobile car = new Automobile
        {
            Brand = "Toyota"
        };

        Console.WriteLine($"Car: {car.Brand}");
        Console.WriteLine($"Wheels: {Automobile.NumberOfWheels}");

        // Using a static class.
        double fahrenheit =
            TemperatureConverter.CelsiusToFahrenheit(25);

        Console.WriteLine($"25°C = {fahrenheit}°F");

        // Creating a nested class.
        Container.Nested nested = new Container.Nested();

        nested.Show();
    }
}

/// <summary>
/// Demonstrates a class with a private constructor
/// and static members.
/// </summary>
public class Counter
{
    /// <summary>
    /// Prevents external code from creating Counter objects.
    /// </summary>
    private Counter()
    {
    }

    /// <summary>
    /// Stores the shared counter value.
    /// </summary>
    public static int CurrentCount;

    /// <summary>
    /// Increments and returns the counter value.
    /// </summary>
    public static int IncrementCount()
    {
        return ++CurrentCount;
    }
}

/// <summary>
/// Demonstrates a normal class containing
/// both static and instance members.
/// </summary>
public class Automobile
{
    /// <summary>
    /// A static member shared by all Automobile objects.
    /// </summary>
    public static int NumberOfWheels = 4;

    /// <summary>
    /// An instance property belonging to each Automobile object.
    /// </summary>
    public string Brand { get; set; } = string.Empty;
}

/// <summary>
/// Provides temperature conversion methods.
/// The class cannot be instantiated.
/// </summary>
public static class TemperatureConverter
{
    /// <summary>
    /// Converts Celsius to Fahrenheit.
    /// </summary>
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    /// <summary>
    /// Converts Fahrenheit to Celsius.
    /// </summary>
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}

/// <summary>
/// Demonstrates a class containing a nested class.
/// </summary>
public class Container
{
    /// <summary>
    /// A class defined inside Container.
    /// </summary>
    public class Nested
    {
        /// <summary>
        /// Displays a message from the nested class.
        /// </summary>
        public void Show()
        {
            Console.WriteLine("Hello from Container.Nested.");
        }
    }
}
