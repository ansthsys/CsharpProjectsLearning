using System;

namespace EventSubscribeAndUnsubscribe
{
  /// <summary>
  /// Subscribe and Unsubscribe from Events in C#
  /// <br /><br />
  /// Demonstrates how to attach and detach event handlers using the += and -= operators,
  /// manage event handlers dynamically, and prevent memory leaks using the IDisposable pattern.
  /// </summary>

  public class Button
  {
    public event EventHandler? Clicked;

    public void OnClick()
    {
      Clicked?.Invoke(this, EventArgs.Empty);
    }
  }

  public class BasicSubscriptionDemo
  {
    public static void Run()
    {
      Button button = new Button();

      // Subscribing to event
      EventHandler handler = Button_Clicked;
      button.Clicked += handler;

      Console.WriteLine("Triggering event after subscribing:");
      button.OnClick();

      // Unsubscribing from event
      button.Clicked -= handler;

      Console.WriteLine("Triggering event after unsubscribing:");
      button.OnClick(); // No output
    }

    private static void Button_Clicked(object? sender, EventArgs e)
    {
      Console.WriteLine("-> Button was clicked!");
    }
  }

  public class DynamicSubscriptionDemo
  {
    public static void Run()
    {
      Button button = new Button();
      bool isSubscribed = false;

      EventHandler handler = (sender, e) => Console.WriteLine("-> Dynamic handler executed!");

      if (!isSubscribed)
      {
        button.Clicked += handler;
        isSubscribed = true;
      }

      Console.WriteLine("Triggering dynamic event (Subscribed = true):");
      button.OnClick();

      if (isSubscribed)
      {
        button.Clicked -= handler;
        isSubscribed = false;
      }

      Console.WriteLine("Triggering dynamic event (Subscribed = false):");
      button.OnClick();
    }
  }

  public class MemoryLeakPreventionDemo
  {
    public class Subscriber : IDisposable
    {
      private readonly Button _button;

      public Subscriber(Button button)
      {
        _button = button;
        _button.Clicked += Button_Clicked;
        Console.WriteLine("Subscriber connected to Button event.");
      }

      private void Button_Clicked(object? sender, EventArgs e)
      {
        Console.WriteLine("-> Subscriber received Button click!");
      }

      public void Dispose()
      {
        _button.Clicked -= Button_Clicked;
        Console.WriteLine("Subscriber disconnected from Button event via Dispose().");
      }
    }

    public static void Run()
    {
      Button button = new Button();

      using (Subscriber subscriber = new Subscriber(button))
      {
        Console.WriteLine("Triggering event inside using block:");
        button.OnClick();
      } // Dispose() is automatically called here

      Console.WriteLine("Triggering event outside using block:");
      button.OnClick(); // No output because it was detached in Dispose()
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("=== Basic Subscription Demo ===");
      BasicSubscriptionDemo.Run();

      Console.WriteLine("\n=== Dynamic Subscription Demo ===");
      DynamicSubscriptionDemo.Run();

      Console.WriteLine("\n=== Memory Leak Prevention Demo ===");
      MemoryLeakPreventionDemo.Run();
    }
  }
}
