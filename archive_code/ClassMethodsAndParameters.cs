/// <summary>
/// Method signatures
/// <br /><br />
/// Methods are defined with an access level, modifiers, return type,
/// method name, and parameters.
/// </summary>

namespace MotorCycleExample
{
    abstract class Motorcycle
    {
        // Anyone can call this.
        public void StartEngine() { /* Method statements here */ }

        // Only derived classes can call this.
        protected void AddGas(int gallons) { /* Method statements here */ }

        // Derived classes can override the base class implementation.
        public virtual int Drive(int miles, int speed)
        {
            /* Method statements here */
            return 1;
        }

        // Derived classes can override the base class implementation.
        public virtual int Drive(TimeSpan time, int speed)
        {
            /* Method statements here */
            return 0;
        }

        // Derived classes must implement this.
        public abstract double GetTopSpeed();
    }
}

/// <summary>
/// Method invocation
/// <br /><br />
/// Instance methods are called through an object,
/// while static methods are called through the type.
/// </summary>

public static class SquareExample
{
    public static void Main()
    {
        // Call with an int variable.
        int num = 4;
        int productA = Square(num);

        // Call with an integer literal.
        int productB = Square(12);

        // Call with an expression that evaluates to int.
        int productC = Square(productA * 3);
    }

    static int Square(int i)
    {
        // Store input argument in a local variable.
        int input = i;
        return input * input;
    }
}

/// <summary>
/// Value type parameters
/// <br /><br />
/// Value types passed by value are copied,
/// so changes inside the method don't affect the original value.
/// </summary>

public static class ByValueExample
{
    public static void Run()
    {
        var value = 20;
        Console.WriteLine("In Main, value = {0}", value);

        ModifyValue(value);

        Console.WriteLine("Back in Main, value = {0}", value);
    }

    static void ModifyValue(int i)
    {
        i = 30;
        Console.WriteLine("In ModifyValue, parameter value = {0}", i);
        return;
    }
}

// The example displays:
// In Main, value = 20
// In ModifyValue, parameter value = 30
// Back in Main, value = 20


/// <summary>
/// Reference type parameters passed by value
/// <br /><br />
/// The reference is copied, but both references point to the same object.
/// Changing the object's member affects the original object.
/// </summary>

public class SampleRefType
{
    public int value;
}

public static class ByRefTypeExample
{
    public static void Run()
    {
        var rt = new SampleRefType { value = 44 };

        Console.WriteLine("In Main, rt.value = {0}", rt.value);

        ModifyObject(rt);

        Console.WriteLine("Back in Main, rt.value = {0}", rt.value);
    }

    static void ModifyObject(SampleRefType obj)
    {
        obj.value = 33;

        Console.WriteLine(
            "In ModifyObject, obj.value = {0}",
            obj.value);
    }
}

// The example displays:
// In Main, rt.value = 44
// In ModifyObject, obj.value = 33
// Back in Main, rt.value = 33


/// <summary>
/// Reference parameters
/// <br /><br />
/// ref and out allow a method to work with an argument by reference.
/// The in keyword can pass a value by reference without allowing modification.
/// </summary>

public static class ByRefExample
{
    public static void Run()
    {
        var value = 20;

        Console.WriteLine("In Main, value = {0}", value);

        ModifyValue(ref value);

        Console.WriteLine("Back in Main, value = {0}", value);
    }

    private static void ModifyValue(ref int i)
    {
        i = 30;

        Console.WriteLine(
            "In ModifyValue, parameter value = {0}",
            i);

        return;
    }
}

// The example displays:
// In Main, value = 20
// In ModifyValue, parameter value = 30
// Back in Main, value = 30


/// <summary>
/// ref parameters
/// <br /><br />
/// ref parameters can be used to change the values of variables
/// passed to a method.
/// </summary>

public static class RefSwapExample
{
    public static void Run()
    {
        int i = 2, j = 3;

        Console.WriteLine("i = {0}  j = {1}", i, j);

        Swap(ref i, ref j);

        Console.WriteLine("i = {0}  j = {1}", i, j);
    }

    static void Swap(ref int x, ref int y) =>
        (y, x) = (x, y);
}

// The example displays:
// i = 2  j = 3
// i = 3  j = 2


/// <summary>
/// Parameter collections
/// <br /><br />
/// params allows a method to receive a variable number of arguments.
/// </summary>

static class ParamsExample
{
    public static void Run()
    {
        string fromArray =
            GetVowels(["apple", "banana", "pear"]);

        Console.WriteLine(
            $"Vowels from collection expression: '{fromArray}'");

        string fromMultipleArguments =
            GetVowels("apple", "banana", "pear");

        Console.WriteLine(
            $"Vowels from multiple arguments: '{fromMultipleArguments}'");

        string fromNull = GetVowels(null);

        Console.WriteLine(
            $"Vowels from null: '{fromNull}'");

        string fromNoValue = GetVowels();

        Console.WriteLine(
            $"Vowels from no value: '{fromNoValue}'");
    }

    static string GetVowels(params IEnumerable<string>? input)
    {
        if (input == null || !input.Any())
        {
            return string.Empty;
        }

        char[] vowels = ['A', 'E', 'I', 'O', 'U'];

        return string.Concat(
            input.SelectMany(
                word => word.Where(
                    letter => vowels.Contains(
                        char.ToUpper(letter)))));
    }
}

// The example displays:
// Vowels from collection expression: 'aeaaaea'
// Vowels from multiple arguments: 'aeaaaea'
// Vowels from null: ''
// Vowels from no value: ''

// Before C# 13, params can be used only with a single dimensional array.


/// <summary>
/// Return values
/// <br /><br />
/// A non-void method returns a value using the return keyword.
/// </summary>

class SimpleMath
{
    public int AddTwoNumbers(int number1, int number2) =>
        number1 + number2;

    public int SquareANumber(int number) =>
        number * number;
}


/// <summary>
/// Statement-bodied methods
/// <br /><br />
/// A method can use a code block and return statement
/// instead of an expression-bodied definition.
/// </summary>

class SimpleMathExtnsion
{
    public int DivideTwoNumbers(int number1, int number2)
    {
        return number1 / number2;
    }
}


/// <summary>
/// Using returned values
/// <br /><br />
/// A returned value can be assigned to a variable,
/// passed directly into another method, or used as an expression.
/// </summary>

public static class ReturnValueExample
{
    public static void Run()
    {
        SimpleMath math = new SimpleMath();
        SimpleMathExtnsion mathExtension = new SimpleMathExtnsion();

        int result = math.AddTwoNumbers(1, 2);

        result = math.SquareANumber(result);

        // The result is 9.
        Console.WriteLine(result);

        result = math.SquareANumber(
            math.AddTwoNumbers(1, 2));

        // The result is 9.
        Console.WriteLine(result);

        result = mathExtension.DivideTwoNumbers(6, 2);

        // The result is 3.
        Console.WriteLine(result);
    }
}


/// <summary>
/// Returning multiple values
/// <br /><br />
/// Tuple types allow a method to return multiple values.
/// </summary>

public class PersonInfo
{
    public string FirstName { get; set; } = "";
    public string MiddleName { get; set; } = "";
    public string LastName { get; set; } = "";
    public int Age { get; set; }

    public static PersonInfo RetrieveInfoById(string id)
    {
        return new PersonInfo
        {
            FirstName = "First",
            MiddleName = "Middle",
            LastName = "Last",
            Age = 20
        };
    }
}

public static class TupleExample
{
    public static (string, string, string, int)
        GetPersonalInfo(string id)
    {
        PersonInfo per =
            PersonInfo.RetrieveInfoById(id);

        return (
            per.FirstName,
            per.MiddleName,
            per.LastName,
            per.Age);
    }

    public static (string FName, string MName, string LName, int Age)
        GetNamedPersonalInfo(string id)
    {
        PersonInfo per =
            PersonInfo.RetrieveInfoById(id);

        return (
            per.FirstName,
            per.MiddleName,
            per.LastName,
            per.Age);
    }

    public static void Run()
    {
        var person = GetPersonalInfo("111111111");

        Console.WriteLine(
            $"{person.Item1} {person.Item3}: age = {person.Item4}");

        var namedPerson =
            GetNamedPersonalInfo("111111111");

        Console.WriteLine(
            $"{namedPerson.FName} {namedPerson.LName}: age = {namedPerson.Age}");
    }
}


/// <summary>
/// Expression-bodied members
/// <br /><br />
/// The => syntax is a shorter form for methods
/// that contain a single expression.
/// </summary>

public class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class ExpressionExample
{
    private int x = 10;
    private int y = 20;

    public Point Move(int dx, int dy) =>
        new Point(x + dx, y + dy);

    public void Print() =>
        Console.WriteLine(First + " " + Last);

    public string First = "First";
    public string Last = "Last";

    // Works with operators, properties, and indexers too.
    public string Name => First + " " + Last;
}
