/*
Find all dates in a given whose digits of the month number and 
the day number sum up to a given value. Print each of them on the console in the format dd/mm/yyyy: d+d+m+m=sum.

void PrintDatesWithGivenSum(int year, int sum)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSums
{
    class Program
    {
        public static int digitsSum(int number)
        {
            List<int> currDayDigits = new List<int>();
            int sum = 0;
            while (number > 0)
            {
                currDayDigits.Add(number % 10);
                number = number / 10;
            }
            for (int i = 0; i < currDayDigits.Count; i++)
            {
                sum += (int)currDayDigits[i];
            }
            return sum;
        }
        public static void PrintDatesWithGivenSum(int year, int sum)
        {
            DateTime currDate = new DateTime(year, 1, 1);
            while (currDate.Year == year)
            {
                int currDateDay = currDate.Day;
                int currDateMonth = currDate.Month;
                int sumOfdigits = digitsSum(currDateDay) + digitsSum(currDateMonth) + digitsSum(year);
                if (sumOfdigits == sum)
                {
                    Console.WriteLine(currDate.ToString("dd MM yyyy = ") + sum.ToString());
                }
                currDate = currDate.AddDays(1);
            }
        }
        static void Main(string[] args)
        {
            PrintDatesWithGivenSum(2000, 10);
        }
    }
}
