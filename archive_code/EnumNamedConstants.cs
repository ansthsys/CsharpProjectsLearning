using System;

namespace EnumNamedConstants
{
  /// <summary>
  /// Enum Named Constants
  /// <br /><br />
  /// Demonstrates how to define enums, specify underlying types and custom
  /// values, perform conversions and validation, use extension methods,
  /// and represent predefined values such as order statuses.
  /// </summary>
  internal class Program
  {
    private static void Main()
    {
      Season season = Season.Summer;
      Console.WriteLine(season);

      DaysOfWeek day = DaysOfWeek.Wednesday;
      Console.WriteLine(day);

      DaysOfWeek convertedDay = (DaysOfWeek)3;
      Console.WriteLine(convertedDay);

      bool isValid = Enum.IsDefined(typeof(DaysOfWeek), 3);
      Console.WriteLine(isValid);

      DaysOfWeek today = DaysOfWeek.Saturday;
      Console.WriteLine(today.IsWeekend());

      ErrorCode errorCode = ErrorCode.ConnectionLost;
      Console.WriteLine(errorCode);

      var order = new Order
      {
        OrderId = 123,
        Status = OrderStatus.Pending
      };

      order.UpdateStatus(OrderStatus.Shipped);
    }
  }

  enum Season
  {
    Spring,
    Summer,
    Autumn,
    Winter
  }

  public enum DaysOfWeek
  {
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
  }

  enum ErrorCode : ushort
  {
    None = 0,
    Unknown = 1,
    ConnectionLost = 100,
    OutlierReading = 200
  }

  public static class DaysOfWeekExtensions
  {
    public static bool IsWeekend(this DaysOfWeek day)
    {
      return day == DaysOfWeek.Saturday || day == DaysOfWeek.Sunday;
    }
  }

  enum OrderStatus
  {
    Pending,
    Shipped,
    Delivered,
    Cancelled
  }

  class Order
  {
    public int OrderId { get; set; }

    public OrderStatus Status { get; set; }

    public void UpdateStatus(OrderStatus newStatus)
    {
      Status = newStatus;

      Console.WriteLine(
          $"Order {OrderId} status updated to {Status}"
      );
    }
  }
}
