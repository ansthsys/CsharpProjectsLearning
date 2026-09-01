using System;

namespace DelegateInstantiateAndInvoke
{
  /// <summary>
  /// Instantiate and Invoke Delegate Types
  /// <br /><br />
  /// Demonstrates the four ways to instantiate delegates in C# (named methods,
  /// method group conversion, anonymous methods, and lambda expressions),
  /// as well as combining and removing delegates using multicast operators (+ and -).
  /// </summary>
  public delegate void Notify(string message);

  public delegate void CustomCallback(string s);

  public static class NotificationService
  {
    public static void SendNotification(string message)
    {
      Console.WriteLine("Notification sent: " + message);
    }
  }

  public class DelegateInstantiationDemo
  {
    public static void Run()
    {
      // 1. Named Method instantiation
      Notify notifyNamed = new Notify(NotificationService.SendNotification);
      notifyNamed("Hello, World!");

      // 2. Method Group Conversion
      Notify notifyMethodGroup = NotificationService.SendNotification;
      notifyMethodGroup("Hello from Method Group!");

      // 3. Anonymous Method
      Notify notifyAnonymous = delegate (string message)
      {
        Console.WriteLine("Anonymous notification: " + message);
      };
      notifyAnonymous("Hello from Anonymous Method!");

      // 4. Lambda Expression
      Notify notifyLambda = (message) => Console.WriteLine("Lambda notification: " + message);
      notifyLambda("Hello from Lambda!");
    }
  }

  public class MulticastDelegateDemo
  {
    private static void Hello(string s)
    {
      Console.WriteLine($"  Hello, {s}!");
    }

    private static void Goodbye(string s)
    {
      Console.WriteLine($"  Goodbye, {s}!");
    }

    public static void Run()
    {
      CustomCallback hiDel = Hello;
      CustomCallback byeDel = Goodbye;

      // Combine delegates (+)
      CustomCallback multiDel = hiDel + byeDel;

      // Remove a delegate (-)
      CustomCallback multiMinusHiDel = (multiDel - hiDel)!;

      Console.WriteLine("Invoking delegate hiDel:");
      hiDel("Elize Harmsen");

      Console.WriteLine("Invoking delegate byeDel:");
      byeDel("Mattia Trentini");

      Console.WriteLine("Invoking delegate multiDel:");
      multiDel("Peter Zammit");

      Console.WriteLine("Invoking delegate multiMinusHiDel:");
      multiMinusHiDel("Lennart Kangur");
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("=== Delegate Instantiation Methods ===");
      DelegateInstantiationDemo.Run();

      Console.WriteLine("\n=== Multicast Delegate Demo ===");
      MulticastDelegateDemo.Run();
    }
  }
}
