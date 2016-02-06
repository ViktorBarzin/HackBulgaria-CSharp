namespace Calendar
{
    using System;
    using System.Globalization;

    /// <summary>
    /// Write a method which prints on the console the calendar for and specified month and year.
    /// The calendar should be localized according to a certain culture.
    /// void PrintCalendar(<![CDATA[int]]> month, <![CDATA[int]]> year, CultureInfo culture)
    /// The first line should contain the name of the month, the second line the names of the weekdays space-separated, 
    /// and the next lines should the month day numbers, each right-aligned to the column of its week.
    /// Example:
    /// PrintCalendar(11,2015, new CultureInfo("<![CDATA[bg-BG]]>")).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Prints the calendar for a month and year.
        /// </summary>
        /// <param name="month">Month to print.</param>
        /// <param name="year">Year to specify the month.</param>
        /// <param name="culture">Given Culture info.</param>
        public static void PrintCalendar(int month, int year, CultureInfo culture)
        {
            Console.WriteLine(new CultureInfo(culture.ToString()).DateTimeFormat.GetMonthName(month));
            for (int i = 0; i < 7; i++)
            {
                Console.Write(new CultureInfo(culture.ToString()).DateTimeFormat.GetDayName((DayOfWeek)i) + " ");
            }
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            PrintCalendar(11, 2015, new CultureInfo("bg-BG"));

            // TODO : finish later
        }
    }
}