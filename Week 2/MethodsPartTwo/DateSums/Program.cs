/*
Find all dates in a given whose digits of the month number and 
the day number sum up to a given value. Print each of them on the console in the format dd/mm/yyyy: d+d+m+m=sum.

void PrintDatesWithGivenSum(int year, int sum)
*/

namespace DateSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
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

        public static void Main(string[] args)
        {
            PrintDatesWithGivenSum(2000, 10);
        }
    }
}
