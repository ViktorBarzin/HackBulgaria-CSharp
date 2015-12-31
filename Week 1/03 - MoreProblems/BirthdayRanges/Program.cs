namespace BirthdayRanges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Implement a function List<![CDATA[int]]> BirthdayRanges(List<![CDATA[<int>]]> birthdays, List<![CDATA[KeyValuePair<int,int>]]> ranges)
    /// We have a list birthdays and list of ranges.birthdays - range from 0 to 365, ranges - 
    /// one range is a pair of two numbers - start and end.
    /// We want to calculate, for each range, how many people are born in it(between start and end inclusive).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Counts how many integers are in between the given ranges.
        /// </summary>
        /// <param name="birthdays">Integers to check.</param>
        /// <param name="ranges">List of <![CDATA[KeyvaluePairs]]> where to check each "birthday".</param>
        /// <returns>Returns a list of integers corresponding to how many "birthdays" are in each "range".</returns>
        public static List<int> BirthdayRanges(List<int> birthdays, List<KeyValuePair<int, int>> ranges)
        {
            return ranges.Select(range => birthdays.Count(t => t >= range.Key && t <= range.Value)).ToList();
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            List<int> birthdays = new List<int> { 5, 10, 6, 7, 3, 4, 5, 11, 21, 300, 15 };
            List<KeyValuePair<int, int>> ranges = new List<KeyValuePair<int, int>>
            {
                new KeyValuePair<int, int>(4, 9),
                new KeyValuePair<int, int>(6, 7),
                new KeyValuePair<int, int>(200, 225),
                new KeyValuePair<int, int>(300, 365)
            };

            foreach (var item in BirthdayRanges(birthdays, ranges))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
