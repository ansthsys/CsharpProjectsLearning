using System;
using System.Globalization;

namespace DateTimeZoneImplement
{
    /// <summary>
    /// Implement Date and Time Classes
    /// <br /><br />
    /// Demonstrates DateOnly, TimeOnly, DateTime, DateTimeOffset,
    /// TimeZoneInfo, TimeSpan, DayOfWeek, CultureInfo, Calendar,
    /// and CalendarWeekRule in C#.
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            // DateOnly
            // Represents a date without a time of day.

            DateOnly eventDate = new DateOnly(2026, 8, 27);

            Console.WriteLine($"Event Date: {eventDate}");

            // TimeOnly
            // Represents a time of day without a date.

            TimeOnly meetingTime = new TimeOnly(14, 30);

            Console.WriteLine($"Meeting Time: {meetingTime}");

            // DateTime
            // Represents both a date and a time.

            DateTime meetingDateTime =
                new DateTime(2026, 8, 27, 14, 30, 0);

            Console.WriteLine($"Meeting Date and Time: {meetingDateTime}");

            // DateTimeOffset
            // Represents a date and time together with a UTC offset.

            DateTimeOffset meetingWithOffset =
                new DateTimeOffset(2026, 8, 27, 14, 30, 0,
                    TimeSpan.FromHours(7));

            Console.WriteLine(
                $"Meeting with Offset: {meetingWithOffset}");

            // TimeZoneInfo
            // Provides information about a time zone and allows
            // conversion between different time zones.

            TimeZoneInfo localTimeZone =
                TimeZoneInfo.Local;

            Console.WriteLine(
                $"Local Time Zone: {localTimeZone.DisplayName}");

            DateTime utcTime = DateTime.UtcNow;

            DateTime localTime =
                TimeZoneInfo.ConvertTimeFromUtc(
                    utcTime,
                    localTimeZone);

            Console.WriteLine($"UTC Time: {utcTime}");
            Console.WriteLine($"Local Time: {localTime}");

            // TimeSpan
            // Represents a duration or interval of time.

            TimeSpan eventDuration =
                new TimeSpan(2, 30, 0);

            Console.WriteLine(
                $"Event Duration: {eventDuration}");

            TimeSpan breakDuration =
                TimeSpan.FromMinutes(30);

            Console.WriteLine(
                $"Break Duration: {breakDuration}");

            TimeSpan totalDuration =
                eventDuration + breakDuration;

            Console.WriteLine(
                $"Total Duration: {totalDuration}");

            // DayOfWeek
            // Represents the day of the week.

            DayOfWeek today =
                DateTime.Now.DayOfWeek;

            Console.WriteLine($"Today is: {today}");

            // CultureInfo
            // Provides culture-specific information such as
            // date and time formatting.

            CultureInfo usCulture =
                new CultureInfo("en-US");

            CultureInfo indonesiaCulture =
                new CultureInfo("id-ID");

            Console.WriteLine(
                $"US Date: {meetingDateTime.ToString("D", usCulture)}");

            Console.WriteLine(
                $"Indonesian Date: {meetingDateTime.ToString("D", indonesiaCulture)}");

            // Calendar
            // Represents a calendar system used to interpret dates.

            Calendar calendar =
                indonesiaCulture.Calendar;

            int year =
                calendar.GetYear(meetingDateTime);

            int month =
                calendar.GetMonth(meetingDateTime);

            int day =
                calendar.GetDayOfMonth(meetingDateTime);

            Console.WriteLine(
                $"Calendar Date: {year}-{month}-{day}");

            // CalendarWeekRule
            // Defines how the first week of the year is determined.

            CalendarWeekRule weekRule =
                CalendarWeekRule.FirstFourDayWeek;

            DayOfWeek firstDayOfWeek =
                DayOfWeek.Monday;

            int weekNumber =
                calendar.GetWeekOfYear(
                    meetingDateTime,
                    weekRule,
                    firstDayOfWeek);

            Console.WriteLine(
                $"Week Number: {weekNumber}");
        }
    }
}
