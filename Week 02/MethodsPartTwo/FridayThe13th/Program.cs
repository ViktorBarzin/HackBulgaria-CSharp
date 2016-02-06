namespace FridayThe13th
{
    using System;

    /// <summary>
    /// Write a method which given a year range, returns how many Fridays <![CDATA[13th]]> there are in that range
    /// <![CDATA[int]]> UnfortunateFridays(<![CDATA[int]]> startYear, <![CDATA[int]]> endYear).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Gets all the fridays <![CDATA[13th]]> in a give interval.
        /// </summary>
        /// <param name="startYear">Lower end year.</param>
        /// <param name="endYear">Upper end year..</param>
        /// <returns>The count of friday 13s.</returns>
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

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine(UnfortunateFridays(2014, 2020));
        }
    }
}