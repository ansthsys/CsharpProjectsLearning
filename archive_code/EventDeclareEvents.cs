using System;

namespace EventDeclareEvents
{
  /// <summary>
  /// Declare Events in C#
  /// <br /><br />
  /// Demonstrates how to declare events, protect event-raising logic 
  /// using protected virtual methods, and override event handling in derived classes.
  /// </summary>

  // 1. Base Class defining the event and virtual raising method
  public class BaseCounter
  {
    // Declaring the event using standard EventHandler
    public event EventHandler? ThresholdReached;

    // Protected virtual method allows derived classes to override raising logic
    protected virtual void OnThresholdReached(EventArgs e)
    {
      ThresholdReached?.Invoke(this, e);
    }

    public void Increment(int value, int threshold)
    {
      if (value >= threshold)
      {
        OnThresholdReached(EventArgs.Empty);
      }
    }
  }

  // 2. Derived Class overriding the event-raising behavior
  public class AdvancedCounter : BaseCounter
  {
    protected override void OnThresholdReached(EventArgs e)
    {
      Console.WriteLine("[AdvancedCounter Log] Threshold condition met!");
      // Call base method to notify all external subscribers
      base.OnThresholdReached(e);
    }
  }

  public class EventDemo
  {
    public static void Run()
    {
      Console.WriteLine("--- Basic Event Declaration Demo ---");
      BaseCounter basicCounter = new BaseCounter();
      basicCounter.ThresholdReached += (sender, e) =>
          Console.WriteLine("-> Basic Counter Subscriber: Threshold hit!");

      basicCounter.Increment(10, 5);

      Console.WriteLine("\n--- Inheritance Event Demo ---");
      AdvancedCounter advCounter = new AdvancedCounter();
      advCounter.ThresholdReached += (sender, e) =>
          Console.WriteLine("-> Advanced Counter Subscriber: Threshold hit!");

      advCounter.Increment(10, 5);
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("=== Declare Events in C# Demo ===");
      EventDemo.Run();
    }
  }
}
