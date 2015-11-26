/*
Implement a function List<int> BirthdayRanges(List<int> birthdays, List<KeyValuePair<int, int>> ranges)
We have a list birthdays and list of ranges. birthdays - range from 0 to 365, ranges - 
one range is a pair of two numbers - start and end.

We want to calculate, for each range, how many people are born in it (between start and end inclusive).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayRanges
{
    class Program
    {
        public static List<int> BirthdayRanges(List<int> birthdays, List<KeyValuePair<int, int>> ranges)
        {
            List<int> birthdayCounter = new List<int>();
            foreach (var range in ranges)
            {
                int counter = 0;
                for (int i = 0; i < birthdays.Count; i++)
                {
                    if (birthdays[i] >= range.Key && birthdays[i] <= range.Value)
                    {
                        counter++;
                    }
                }
                birthdayCounter.Add(counter);
            }
            return birthdayCounter;
        }
        static void Main(string[] args)
        {
            List<int> birthdays = new List<int> { 5, 10, 6, 7, 3, 4, 5, 11, 21, 300, 15 };
            List<KeyValuePair<int, int>> ranges = new List<KeyValuePair<int, int>>();
            ranges.Add(new KeyValuePair<int, int>(4, 9));
            ranges.Add(new KeyValuePair<int, int>(6, 7));
            ranges.Add(new KeyValuePair<int, int>(200, 225));
            ranges.Add(new KeyValuePair<int, int>(300, 365));

            foreach (var item in BirthdayRanges(birthdays, ranges))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Birthdays - { 5, 10, 6, 7, 3, 4, 5, 11, 21, 300, 15}
            //Ranges - { (4, 9), (6, 7), (200, 225), (300, 365)}
            // res : {5, 2, 0, 1}
        }
    }
}
