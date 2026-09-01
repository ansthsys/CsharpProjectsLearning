using System;
using System.Collections.Generic;

namespace DelegateStronglyTyped
{
  /// <summary>
  /// Examine Strongly Typed Delegates (Action and Func)
  /// <br /><br />
  /// Demonstrates the usage of built-in generic delegates in .NET:
  /// Action (for methods returning void) and Func (for methods returning a value),
  /// replacing custom delegate declarations to reduce boilerplate code.
  /// </summary>

  public class Customer
  {
    public string CustomerId { get; set; }
    public int Age { get; set; }

    public Customer(string custId, int age)
    {
      CustomerId = custId;
      Age = age;
    }
  }

  public class ActionDelegateDemo
  {
    public static void Run()
    {
      // 1. Action without parameters
      Action sayHello = () => Console.WriteLine("Hello, World!");
      sayHello();

      // 2. Action with single parameter using Lambda Expression
      Action<string> printMessage = (message) => Console.WriteLine(message);
      printMessage("Hello from Action delegate!");

      // 3. Action with reverse string operation
      Action<string> reversePrint = input =>
      {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
      };
      reversePrint("CSharp");

      // 4. Action with two parameters
      Action<int, int> printSum = (a, b) => Console.WriteLine($"Sum: {a + b}");
      printSum(5, 7);
    }
  }

  public class FuncDelegateDemo
  {
    public static void Run()
    {
      Random random = new Random(42); // Fixed seed for reproducible demo output
      List<Customer> customers = new List<Customer>();

      // Generate 5 sample customers
      for (int i = 0; i < 5; i++)
      {
        string customerId = random.Next(10000000, 99999999).ToString();
        int age = random.Next(30, 51);
        customers.Add(new Customer(customerId, age));
      }

      Console.WriteLine("--- Original Customer List ---");
      foreach (var customer in customers)
      {
        Console.WriteLine($"ID: {customer.CustomerId}, Age: {customer.Age}");
      }

      // Define Func delegate for sorting by Age (descending)
      Func<Customer, Customer, int> compareByAge = (c1, c2) => c2.Age.CompareTo(c1.Age);
      customers.Sort((c1, c2) => compareByAge(c1, c2));

      Console.WriteLine("\n--- Sorted by Age (Descending) ---");
      foreach (var customer in customers)
      {
        Console.WriteLine($"ID: {customer.CustomerId}, Age: {customer.Age}");
      }

      // Re-assign Func delegate for sorting by CustomerId (ascending)
      Func<Customer, Customer, int> compareById = (c1, c2) => string.Compare(c1.CustomerId, c2.CustomerId, StringComparison.Ordinal);
      customers.Sort((c1, c2) => compareById(c1, c2));

      Console.WriteLine("\n--- Sorted by Customer ID ---");
      foreach (var customer in customers)
      {
        Console.WriteLine($"ID: {customer.CustomerId}, Age: {customer.Age}");
      }
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("=== Action Delegate Demo ===");
      ActionDelegateDemo.Run();

      Console.WriteLine("\n=== Func Delegate Demo ===");
      FuncDelegateDemo.Run();
    }
  }
}
