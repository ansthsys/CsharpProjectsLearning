namespace Counter
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var counter = new Counter(5);

      counter.ThresholdReached += (sender, e) =>
      {
        Console.WriteLine("Threshold reached!");
      };

      counter.Add(3);
      counter.Add(2); // This should trigger the event


      var counter2 = new Counter(10);

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

      counter2.ThresholdReached -= Counter_ThresholdReached;
    }

    public static void Counter_ThresholdReached(object? sender, ThresholdReachedEventArgs e)
    {
      Console.WriteLine($"Threshold of {e.Threshold} reached at {e.TimeReached}.");
    }
  }

  public class Counter
  {
    public int Total { get; private set; }
    public int Threshold { get; set; }

    public event EventHandler<ThresholdReachedEventArgs> ThresholdReached = delegate { };

    public Counter(int threshold)
    {
      Threshold = threshold;
      Total = 0;
    }

    public void Add(int value)
    {
      Total += value;
      Console.WriteLine($"Current Total: {Total}"); // Debugging output

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

  public class ThresholdReachedEventArgs : EventArgs
  {
    public int Threshold { get; set; }
    public DateTime TimeReached { get; set; }
  }
}
