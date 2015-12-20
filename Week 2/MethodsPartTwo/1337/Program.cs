/*
When the clock hits 13:37 on December 21st, this is a special time for hackers.
Write a method which prints how many days, hours, and minutes remain until the next such time comes.

void HackerTime()

The result should be printed on the console in the format dd:hh:mm
*/

namespace _1337
{
    using System;

    public class Program
    {
        public static void HackerTime()
        {
            DateTime now = DateTime.Now;
            DateTime hackerTime = new DateTime(now.Year, 12, 21, 13, 37, 0);
            if (now < hackerTime)
            {
                TimeSpan span = hackerTime - now;
                Console.WriteLine("{0} days, {1} hours, {2} minutes", span.Days, span.Hours, span.Minutes);
            }
            else
            {
                hackerTime = hackerTime.AddYears(1);
                TimeSpan span = hackerTime - now;
                Console.WriteLine("{0} days, {1} hours, {2} minutes", span.Days, span.Hours, span.Minutes);
            }
        }

        public static void Main(string[] args)
        {
            HackerTime();
        }
    }
}
