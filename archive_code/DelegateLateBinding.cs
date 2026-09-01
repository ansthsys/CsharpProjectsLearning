using System;

namespace DelegateLateBinding
{
  /// <summary>
  /// Examine Late Binding with Delegates
  /// <br /><br />
  /// Demonstrates how delegates enable late binding, dynamic method invocation,
  /// callback mechanisms, and type-safe method encapsulation in C#. Covers declaring
  /// delegates both at namespace level and nested within classes.
  /// </summary>
  public delegate int PerformCalculation(int x, int y);

  public class Calculator
  {
    public int Add(int x, int y)
    {
      return x + y;
    }

    public int Subtract(int x, int y)
    {
      return x - y;
    }

    public int Multiply(int x, int y)
    {
      return x * y;
    }

    public int Divide(int x, int y)
    {
      if (y == 0)
        throw new DivideByZeroException();
      return x / y;
    }
  }

  public delegate void MyNamespaceDelegate(string message);

  public class Publisher
  {
    public delegate void MyNestedDelegate(string message);

    public void PublishMessage(MyNamespaceDelegate del)
    {
      del("Hello from Publisher using Namespace Delegate!");
    }

    public void PublishMessage(MyNestedDelegate del)
    {
      del("Hello from Publisher using Nested Delegate!");
    }
  }

  public class Subscriber
  {
    public void Subscribe()
    {
      Publisher publisher = new Publisher();

      MyNamespaceDelegate nsDel = new MyNamespaceDelegate(PrintMessage);
      publisher.PublishMessage(nsDel);

      Publisher.MyNestedDelegate nestedDel = new Publisher.MyNestedDelegate(PrintMessage);
      publisher.PublishMessage(nestedDel);
    }

    public void PrintMessage(string message)
    {
      Console.WriteLine(message);
    }
  }

  public class Program
  {
    public static void Main()
    {
      Calculator calculator = new Calculator();

      PerformCalculation add = new PerformCalculation(calculator.Add);
      PerformCalculation subtract = new PerformCalculation(calculator.Subtract);
      PerformCalculation multiply = new PerformCalculation(calculator.Multiply);
      PerformCalculation divide = new PerformCalculation(calculator.Divide);

      Console.WriteLine("Addition: " + add(5, 3));
      Console.WriteLine("Subtraction: " + subtract(5, 3));
      Console.WriteLine("Multiplication: " + multiply(5, 3));
      Console.WriteLine("Division: " + divide(5, 3));

      Subscriber subscriber = new Subscriber();
      subscriber.Subscribe();
    }
  }
}
