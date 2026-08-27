using System;
using System.Globalization;

namespace DateTimeZoneApply
{
    /// <summary>
    /// Apply DayOfWeek, CultureInfo, Calendar, and CalendarWeekRule
    /// <br /><br />
    /// Demonstrates retrieving day of week information, working with
    /// culture-specific settings, performing calendar operations, and
    /// determining the week of the year using CalendarWeekRule.
    /// </summary>

    public class Program
    {
        public static void Main()
        {
            // DayOfWeek

            DateTime today = DateTime.Now;

            DayOfWeek day = today.DayOfWeek;

            Console.WriteLine("Today is: " + day);

            DateTime nextSunday =
                today.AddDays(7 - (int)day);

            Console.WriteLine(
                "Next Sunday is on: " +
                nextSunday.ToShortDateString()
            );

            bool isWeekend =
                day == DayOfWeek.Saturday ||
                day == DayOfWeek.Sunday;

            Console.WriteLine(
                "Is today a weekend? " +
                isWeekend
            );

            // CultureInfo

            CultureInfo currentCulture =
                CultureInfo.CurrentCulture;

            CultureInfo currentUICulture =
                CultureInfo.CurrentUICulture;

            Console.WriteLine(
                "Current Culture: " +
                currentCulture.Name
            );

            Console.WriteLine(
                "Current UI Culture: " +
                currentUICulture.Name
            );

            CultureInfo newCulture =
                new CultureInfo("fr-FR");

            CultureInfo.CurrentCulture = newCulture;
            CultureInfo.CurrentUICulture = newCulture;

            Console.WriteLine(
                "New Culture: " +
                CultureInfo.CurrentCulture.Name
            );

            Console.WriteLine(
                "New UI Culture: " +
                CultureInfo.CurrentUICulture.Name
            );

            // Calendar

            Calendar calendar =
                CultureInfo.InvariantCulture.Calendar;

            int daysInMonth =
                calendar.GetDaysInMonth(2023, 2);

            Console.WriteLine(
                "Days in February 2023: " +
                daysInMonth
            );

            DateTime date =
                new DateTime(2023, 12, 31);

            CalendarWeekRule rule =
                CalendarWeekRule.FirstDay;

            DayOfWeek firstDayOfWeek =
                DayOfWeek.Sunday;

            int weekOfYear =
                calendar.GetWeekOfYear(
                    date,
                    rule,
                    firstDayOfWeek
                );

            Console.WriteLine(
                "Week of the year for December 31, 2023: " +
                weekOfYear
            );

            // CalendarWeekRule

            date = new DateTime(2023, 1, 5);

            rule =
                CalendarWeekRule.FirstFourDayWeek;

            firstDayOfWeek =
                DayOfWeek.Sunday;

            weekOfYear =
                calendar.GetWeekOfYear(
                    date,
                    rule,
                    firstDayOfWeek
                );

            Console.WriteLine(
                "Week of the year: " +
                weekOfYear
            );
        }
    }
}