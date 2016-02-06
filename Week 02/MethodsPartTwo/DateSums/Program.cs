namespace DateSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Find all dates in a given whose digits of the month number and 
    /// the day number sum up to a given value.Print each of them on the console in the format <![CDATA[dd/mm/yyyy: d+d+m+m=sum]]>.
    /// void PrintDatesWithGivenSum(<![CDATA[int]]> year, <![CDATA[int]]> sum).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Calculates the sum of the digits of a given integer.
        /// </summary>
        /// <param name="number">Input Integer.</param>
        /// <returns>The sum of the digits of "number".</returns>
        public static int DigitsSum(int number)
        {
            List<int> currDayDigits = new List<int>();
            while (number > 0)
            {
                currDayDigits.Add(number % 10);
                number = number / 10;
            }

            return currDayDigits.Sum(t => t);
        }

        /// <summary>
        /// Prints the dates whose sum fulfills the class documentation condition.
        /// </summary>
        /// <param name="year">Input year.</param>
        /// <param name="sum">Input sum.</param>
        public static void PrintDatesWithGivenSum(int year, int sum)
        {
            DateTime currDate = new DateTime(year, 1, 1);
            while (currDate.Year == year)
            {
                int currDateDay = currDate.Day;
                int currDateMonth = currDate.Month;
                int sumOfdigits = DigitsSum(currDateDay) + DigitsSum(currDateMonth) + DigitsSum(year);
                if (sumOfdigits == sum)
                {
                    Console.WriteLine(currDate.ToString("dd MM yyyy = ") + sum.ToString());
                }

                currDate = currDate.AddDays(1);
            }
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            PrintDatesWithGivenSum(2000, 10);
        }
    }
}
