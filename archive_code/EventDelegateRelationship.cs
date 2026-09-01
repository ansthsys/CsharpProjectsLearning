using System;

namespace EventDelegateRelationship
{
  /// <summary>
  /// Explore Delegates and Events Relationship in C#
  /// <br /><br />
  /// Demonstrates using EventHandler<T> with custom event args, 
  /// multicast event notifications, and correct unsubscription handling.
  /// </summary>

  // 1. Custom EventArgs class to hold event metadata
  public class OrderEventArgs : EventArgs
  {
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
  }

  // 2. Publisher class using Generic EventHandler<T>
  public class OrderProcessor
  {
    public event EventHandler<OrderEventArgs>? OrderProcessed;

    protected virtual void OnOrderProcessed(OrderEventArgs e)
    {
      OrderProcessed?.Invoke(this, e);
    }

    public void ProcessOrder(int orderId)
    {
      Console.WriteLine($"[OrderProcessor] Processing order {orderId}...");
      OnOrderProcessed(new OrderEventArgs
      {
        OrderId = orderId,
        OrderDate = DateTime.Now
      });
    }
  }

  // 3. Publisher class demonstrating Multicast Delegates
  public class NotificationService
  {
    public event EventHandler? NotificationSent;

    public void SendNotification()
    {
      Console.WriteLine("[NotificationService] Raising NotificationSent event...");
      NotificationSent?.Invoke(this, EventArgs.Empty);
    }
  }

  public class CustomDataDemo
  {
    public static void Run()
    {
      OrderProcessor processor = new OrderProcessor();

      // Subscribing to EventHandler<OrderEventArgs>
      processor.OrderProcessed += (sender, e) =>
      {
        Console.WriteLine($"-> [Subscriber] Order #{e.OrderId} processed successfully at {e.OrderDate:HH:mm:ss}.");
      };

      processor.ProcessOrder(101);
    }
  }

  public class MulticastDemo
  {
    public static void Run()
    {
      NotificationService service = new NotificationService();

      // Multicast: Registering multiple handlers via +=
      service.NotificationSent += (sender, e) => Console.WriteLine("-> [Email System] Email sent!");
      service.NotificationSent += (sender, e) => Console.WriteLine("-> [SMS System] SMS sent!");

      service.SendNotification();
    }
  }

  public class CorrectUnsubscribeDemo : IDisposable
  {
    private readonly NotificationService _service;
    private readonly EventHandler _handler;

    public CorrectUnsubscribeDemo(NotificationService service)
    {
      _service = service;

      // Storing the delegate instance to enable proper unsubscription (-=)
      _handler = (sender, e) => Console.WriteLine("-> [Managed Subscriber] Notification received!");
      _service.NotificationSent += _handler;
    }

    public void Dispose()
    {
      // Proper unsubscription using stored delegate reference
      _service.NotificationSent -= _handler;
      Console.WriteLine("Successfully unsubscribed handler from NotificationService.");
    }

    public static void Run()
    {
      NotificationService service = new NotificationService();

      using (var subscriber = new CorrectUnsubscribeDemo(service))
      {
        service.SendNotification();
      }

      Console.WriteLine("Triggering notification after disposal:");
      service.SendNotification(); // No output from subscriber
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("=== Custom Event Data Demo (EventHandler<T>) ===");
      CustomDataDemo.Run();

      Console.WriteLine("\n=== Multicast Delegate Demo ===");
      MulticastDemo.Run();

      Console.WriteLine("\n=== Proper Unsubscribe Demo ===");
      CorrectUnsubscribeDemo.Run();
    }
  }
}
