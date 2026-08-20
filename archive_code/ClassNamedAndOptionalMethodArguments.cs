using System;

namespace ClassNamedAndOptionalMethodArguments
{
    /// <summary>
    /// Named and Optional Method Arguments
    ///
    /// Demonstrates named arguments, optional parameters, default values,
    /// positional and named argument combinations, optional constructor
    /// parameters, argument evaluation order, and overload resolution.
    ///
    /// Named arguments allow arguments to be matched with parameters by name
    /// instead of position. Optional parameters allow callers to omit
    /// arguments when a default value is defined.
    /// </summary>
    public class ExampleClass
    {
        private string _name;

        /// <summary>
        /// Initializes a new instance of the ExampleClass.
        ///
        /// The name parameter is optional because it has a default value.
        /// </summary>
        /// <param name="name">The name assigned to the object.</param>
        public ExampleClass(string name = "Default name")
        {
            _name = name;
        }

        /// <summary>
        /// Prints order information using one required parameter and two
        /// optional parameters.
        ///
        /// The required parameter must always be supplied. The optional
        /// parameters use their default values when arguments are omitted.
        /// </summary>
        /// <param name="required">A required integer value.</param>
        /// <param name="optionalstr">
        /// An optional string value. The default is "default string".
        /// </param>
        /// <param name="optionalint">
        /// An optional integer value. The default is 10.
        /// </param>
        public void ExampleMethod(
            int required,
            string optionalstr = "default string",
            int optionalint = 10)
        {
            Console.WriteLine(
                $"{_name}: {required}, {optionalstr}, and {optionalint}.");
        }
    }

    public class OrderPrinter
    {
        /// <summary>
        /// Prints order details.
        ///
        /// Named arguments can specify arguments by parameter name instead
        /// of relying on the parameter position.
        /// </summary>
        /// <param name="sellerName">The seller name.</param>
        /// <param name="orderNum">The order number.</param>
        /// <param name="productName">The product name.</param>
        public static void PrintOrderDetails(
            string sellerName,
            int orderNum,
            string productName)
        {
            Console.WriteLine(
                $"Seller: {sellerName}, Order: {orderNum}, Product: {productName}");
        }

        /// <summary>
        /// Demonstrates the order in which arguments are evaluated.
        ///
        /// Arguments are evaluated in the order in which they appear in the
        /// argument list, not in the order of the parameters in the method.
        /// </summary>
        /// <param name="first">The first parameter.</param>
        /// <param name="second">The second parameter.</param>
        /// <param name="third">The third parameter.</param>
        public static void ShowEvaluationOrder(
            int first,
            int second,
            int third)
        {
            Console.WriteLine(
                $"Values: {first}, {second}, {third}");
        }

        /// <summary>
        /// Returns an integer while displaying when the argument is evaluated.
        /// This is used to demonstrate argument evaluation order.
        /// </summary>
        /// <param name="name">The name displayed during evaluation.</param>
        /// <param name="value">The value returned.</param>
        /// <returns>The supplied value.</returns>
        public static int GetValue(string name, int value)
        {
            Console.WriteLine($"Evaluating {name}");
            return value;
        }

        /// <summary>
        /// Demonstrates overload resolution with optional parameters.
        ///
        /// When multiple overloads are candidates, C# selects the best
        /// applicable overload according to overload resolution rules.
        /// A candidate is applicable when its parameters either correspond
        /// to supplied arguments or are optional.
        /// </summary>
        /// <param name="value">The integer value.</param>
        public static void Process(int value)
        {
            Console.WriteLine($"Process(int): {value}");
        }

        /// <summary>
        /// An overloaded method with an optional parameter.
        /// </summary>
        /// <param name="value">The integer value.</param>
        /// <param name="label">An optional label.</param>
        public static void Process(int value, string label = "default")
        {
            Console.WriteLine($"Process(int, string): {value}, {label}");
        }
    }

    /// <summary>
    /// Named and Optional Method Arguments
    ///
    /// Demonstrates how named arguments and optional parameters are used
    /// with constructors and methods.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Runs the examples from the chapter.
        ///
        /// Positional arguments normally follow the parameter order.
        /// Named arguments identify parameters explicitly and can be supplied
        /// in a different order.
        ///
        /// Optional parameters can be omitted because their default values
        /// are used automatically.
        /// </summary>
        public static void Main()
        {
            ExampleClass anExample = new ExampleClass();

            anExample.ExampleMethod(1, "One", 1);
            anExample.ExampleMethod(2, "Two");
            anExample.ExampleMethod(3);

            ExampleClass anotherExample =
                new ExampleClass("Provided name");

            anotherExample.ExampleMethod(1, "One", 1);
            anotherExample.ExampleMethod(2, "Two");
            anotherExample.ExampleMethod(3);

            Console.WriteLine();

            OrderPrinter.PrintOrderDetails(
                "Gift Shop",
                31,
                "Red Mug");

            OrderPrinter.PrintOrderDetails(
                orderNum: 31,
                productName: "Red Mug",
                sellerName: "Gift Shop");

            OrderPrinter.PrintOrderDetails(
                productName: "Red Mug",
                sellerName: "Gift Shop",
                orderNum: 31);

            OrderPrinter.PrintOrderDetails(
                "Gift Shop",
                31,
                productName: "Red Mug");

            Console.WriteLine();

            anExample.ExampleMethod(
                3,
                optionalint: 4);

            Console.WriteLine();

            OrderPrinter.ShowEvaluationOrder(
                first: OrderPrinter.GetValue("first", 1),
                third: OrderPrinter.GetValue("third", 3),
                second: OrderPrinter.GetValue("second", 2));

            Console.WriteLine();

            OrderPrinter.Process(10);
            OrderPrinter.Process(10, "custom");
        }
    }
}
