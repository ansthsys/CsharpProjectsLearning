using System;

namespace DateTimeZoneUse
{
  /// <summary>
  /// Use DateTimeOffset, TimeZoneInfo, and TimeSpan
  /// <br /><br />
  /// Demonstrates working with date and time offsets, converting values
  /// between time zones, and calculating and manipulating time intervals
  /// using DateTimeOffset, TimeZoneInfo, and TimeSpan.
  /// </summary>

  public class Program
  {
    public static void Main()
    {
      // DateTimeOffset

      DateTimeOffset now = DateTimeOffset.Now;
      Console.WriteLine($"Current date and time with offset: {now}");

      DateTimeOffset utcNow = DateTimeOffset.UtcNow;
      Console.WriteLine($"Current UTC date and time with offset: {utcNow}");

      DateTimeOffset futureDate = now.AddDays(10);
      Console.WriteLine($"Date 10 days from now: {futureDate}");

      DateTimeOffset pastDate = now.AddHours(-5);
      Console.WriteLine($"Date 5 hours ago: {pastDate}");

      TimeSpan difference = futureDate - now;
      Console.WriteLine(
          $"Difference between now and future date: {difference}"
      );

      // TimeZoneInfo

      DateTime utcTime = DateTime.UtcNow;
      Console.WriteLine($"UTC Now: {utcTime}");

      DateTime estTime =
          TimeZoneInfo.ConvertTimeBySystemTimeZoneId(
              utcTime,
              "Eastern Standard Time"
          );

      Console.WriteLine($"EST Now: {estTime}");

      TimeZoneInfo localZone = TimeZoneInfo.Local;
      Console.WriteLine($"Local Time Zone: {localZone.DisplayName}");

      DateTime localTime =
          TimeZoneInfo.ConvertTimeFromUtc(
              utcTime,
              localZone
          );

      Console.WriteLine($"Local Time: {localTime}");

      TimeZoneInfo pstZone =
          TimeZoneInfo.FindSystemTimeZoneById(
              "Pacific Standard Time"
          );

      DateTime pstTime =
          TimeZoneInfo.ConvertTime(
              utcTime,
              pstZone
          );

      Console.WriteLine($"PST Time: {pstTime}");

      // TimeSpan

      TimeSpan duration = new TimeSpan(2, 14, 18);
      Console.WriteLine($"Duration: {duration}");

      TimeSpan fromDays = TimeSpan.FromDays(1.5);
      Console.WriteLine($"From Days: {fromDays}");

      TimeSpan fromHours = TimeSpan.FromHours(5.75);
      Console.WriteLine($"From Hours: {fromHours}");

      TimeSpan intervalDifference =
          TimeSpan.FromHours(10) -
          TimeSpan.FromMinutes(30);

      Console.WriteLine($"Difference: {intervalDifference}");

      TimeSpan multiplied =
          TimeSpan.FromMinutes(15) * 2;

      Console.WriteLine($"Multiplied: {multiplied}");
    }
  }
}