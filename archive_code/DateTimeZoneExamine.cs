using System;
using System.Globalization;

namespace DateTimeZone
{
  /// <summary>
  /// Examine C# Classes for Date, Time, and Time Zones
  /// <br /><br />
  /// Demonstrates the C# types used to represent dates, times, time zones,
  /// durations, days of the week, culture-specific data, and calendar rules.
  /// </summary>
  public class Program
  {
    public static void Main()
    {
      // DateOnly represents a date without a time of day.

      DateOnly eventDate = new DateOnly(2026, 8, 27);

      Console.WriteLine($"Event Date: {eventDate}");

      // TimeOnly represents a time of day without a date.

      TimeOnly meetingTime = new TimeOnly(14, 30);

      Console.WriteLine($"Meeting Time: {meetingTime}");

      // DateTime represents both a date and a time.

      DateTime meetingDateTime = new DateTime(
          2026,
          8,
          27,
          14,
          30,
          0
      );

      Console.WriteLine($"Meeting Date and Time: {meetingDateTime}");

      // DateTimeOffset represents a date and time with an offset from UTC.

      DateTimeOffset meetingWithOffset = new DateTimeOffset(
          2026,
          8,
          27,
          14,
          30,
          0,
          TimeSpan.FromHours(7)
      );

      Console.WriteLine(
          $"Meeting with Offset: {meetingWithOffset}"
      );

      // TimeZoneInfo provides information about time zones.

      TimeZoneInfo localTimeZone = TimeZoneInfo.Local;

      Console.WriteLine(
          $"Local Time Zone: {localTimeZone.DisplayName}"
      );

      // TimeSpan represents a duration or time interval.

      TimeSpan duration = new TimeSpan(2, 0, 0);

      Console.WriteLine($"Event Duration: {duration}");

      // DayOfWeek represents a day of the week.

      DayOfWeek today = DateTime.Now.DayOfWeek;

      Console.WriteLine($"Today is: {today}");

      // CultureInfo provides culture-specific information
      // for formatting and parsing data.

      CultureInfo culture = CultureInfo.CurrentCulture;

      Console.WriteLine($"Current Culture: {culture.Name}");

      // Calendar represents a calendar system.

      Calendar calendar = culture.Calendar;

      int currentYear = calendar.GetYear(DateTime.Now);

      Console.WriteLine($"Current Calendar Year: {currentYear}");

      // CalendarWeekRule defines how the first week of the year
      // is determined.

      CalendarWeekRule weekRule = CalendarWeekRule.FirstDay;

      Console.WriteLine($"Calendar Week Rule: {weekRule}");
    }
  }
}