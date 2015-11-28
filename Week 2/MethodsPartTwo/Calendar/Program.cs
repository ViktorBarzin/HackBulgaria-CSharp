/*
Write a method which prints on the console the calendar for and specified month and year.
The calendar should be localized according to a certain culture.

void PrintCalendar(int month, int year, CultureInfo culture)

The first line should contain the name of the month, the second line the names of the weekdays space-separated, and the next lines should the month day numbers, each right-aligned to the column of its week.

Example:

PrintCalendar(11,2015, new CultureInfo("bg-BG")):
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calendar
{
    class Program
    {
        public static void PrintCalendar(int month, int year, CultureInfo culture)
        {
            DateTime date = new DateTime(year, month, 1);

            Console.WriteLine(new CultureInfo(culture.ToString()).DateTimeFormat.GetMonthName(month));
            for (int i = 0; i < 7; i++)
            {
                Console.Write(new CultureInfo(culture.ToString()).DateTimeFormat.GetDayName((DayOfWeek)i ) + " ");
            }
        }
        static void Main(string[] args)
        {
            PrintCalendar(11, 2015, new CultureInfo("bg-BG"));
            //TODO : finish later
        }
    }
}
