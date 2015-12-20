/*
Write a method which given a year range, returns how many Fridays 13ths there are in that range

int UnfortunateFridays(int startYear, int endYear)
*/

namespace FridayThe13th
{
    using System;

    public class Program
    {
        public static int UnfortunateFridays(int startYear, int endYear)
        {
            int fridays = 0;
            DateTime start = new DateTime(startYear, 1, 13);

            while (start.Year <= endYear)
            {
                if (start.DayOfWeek == DayOfWeek.Friday)
                {
                    fridays++;
                }

                start = start.AddMonths(1);
            }

            return fridays;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(UnfortunateFridays(2014, 2020));
        }
    }
}