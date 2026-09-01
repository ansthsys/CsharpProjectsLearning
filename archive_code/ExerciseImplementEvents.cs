using System;

namespace ExerciseImplementEvents
{
  /// <summary>
  /// Exercise: Implement events in C#
  /// <br /><br />
  /// Demonstrates creating custom event argument classes, declaring generic events 
  /// using EventHandler&lt;T&gt;, raising events safely, and managing subscriptions 
  /// dynamically in a console user interaction loop.
  /// </summary>

  // Task 3: Custom Event Data Class
  public class ThresholdReachedEventArgs : EventArgs
  {
    public int Threshold { get; set; }
    public DateTime TimeReached { get; set; }
  }

  // Task 1 & Task 2: Counter Class Definition
  public class Counter
  {
    public int Total { get; private set; }
    public int Threshold { get; set; }

    // Generic event declaration with nullable support
    public event EventHandler<ThresholdReachedEventArgs>? ThresholdReached;

    public Counter(int threshold)
    {
      Threshold = threshold;
      Total = 0;
    }

    public void Add(int value)
    {
      Total += value;
      Console.WriteLine($"Current Total: {Total}");

      if (Total >= Threshold)
      {
        var args = new ThresholdReachedEventArgs
        {
          Threshold = Threshold,
          TimeReached = DateTime.Now
        };
        OnThresholdReached(args);
      }
    }

    protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
    {
      ThresholdReached?.Invoke(this, e);
    }
  }

  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("=== Task 2: Basic Event Subscription Demo ===");
      var counter1 = new Counter(5);

      // Anonymous Lambda Subscription
      counter1.ThresholdReached += (sender, e) =>
      {
        Console.WriteLine($"[Lambda Handler] Threshold of {e.Threshold} reached!");
      };

      counter1.Add(3);
      counter1.Add(2); // Triggers event at total 5

      Console.WriteLine("\n=== Task 4 & 5: Interactive Counter with Unsubscribe ===");
      var counter2 = new Counter(10);

      // Subscribe using named method handler
      counter2.ThresholdReached += Counter_ThresholdReached;

      Console.WriteLine("Press 'a' to add 1 to the counter or 'q' to quit.");
      while (true)
      {
        var key = Console.ReadKey(true).KeyChar;
        if (key == 'a')
        {
          counter2.Add(1);
        }
        else if (key == 'q')
        {
          break;
        }
      }

      // Unsubscribe before program completion
      counter2.ThresholdReached -= Counter_ThresholdReached;
      Console.WriteLine("Successfully unsubscribed from ThresholdReached event.");
    }

    // Task 4: Named Event Handler Method
    private static void Counter_ThresholdReached(object? sender, ThresholdReachedEventArgs e)
    {
      Console.WriteLine($"Threshold of {e.Threshold} reached at {e.TimeReached}.");
    }
  }
}
