using System;

namespace EventExamineEvents
{
  /// <summary>
  /// Examine Events in C#
  /// <br /><br />
  /// Demonstrates the Publisher-Subscriber pattern using C# events, 
  /// nullable event handlers, safe invocation using ?.Invoke(), 
  /// and custom delegate declarations backing an event.
  /// </summary>

  // Custom Delegate definition for event signature
  public delegate void ButtonClickedHandler(object sender, EventArgs e);

  public class StandardButton
  {
    // Standard .NET EventHandler delegate
    public event EventHandler? Selected;

    public void OnClick()
    {
      Console.WriteLine("[StandardButton] Button clicked by user.");
      // Safe invocation using null-conditional operator
      Selected?.Invoke(this, EventArgs.Empty);
    }
  }

  public class CustomButton
  {
    // Event using custom delegate
    public event ButtonClickedHandler? Clicked;

    public void OnClick()
    {
      Console.WriteLine("[CustomButton] Button clicked by user.");
      Clicked?.Invoke(this, EventArgs.Empty);
    }
  }

  public class EventDemo
  {
    public static void Run()
    {
      Console.WriteLine("--- Standard EventHandler Demo ---");
      StandardButton standardButton = new StandardButton();

      // Subscribing using Lambda Expression
      standardButton.Selected += (sender, e) =>
      {
        Console.WriteLine("-> Subscriber 1: Button Selected event received!");
      };

      // Subscribing multiple handlers
      standardButton.Selected += (sender, e) =>
      {
        Console.WriteLine("-> Subscriber 2: Updating UI state...");
      };

      // Triggering event
      standardButton.OnClick();

      Console.WriteLine("\n--- Custom Delegate Event Demo ---");
      CustomButton customButton = new CustomButton();

      // Subscribing to custom delegate event
      customButton.Clicked += OnCustomButtonClicked;

      // Triggering custom event
      customButton.OnClick();
    }

    private static void OnCustomButtonClicked(object sender, EventArgs e)
    {
      Console.WriteLine("-> Custom Event Handler triggered!");
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("=== Examine Events in C# Demo ===");
      EventDemo.Run();
    }
  }
}
