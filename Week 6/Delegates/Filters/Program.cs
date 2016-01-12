namespace Filters
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number"></param>
    /// <returns></returns>
    public delegate bool FilterDelegate<in T>(T number);

    /// <summary>
    /// Application class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Filters collection
        /// </summary>
        /// <typeparam name="T">Type of elements in the list.</typeparam>
        /// <param name="original">List in the begining.</param>
        /// <param name="filter">How to filter the list.</param>
        /// <returns>New Ilist of filtered elements.</returns>
        public static IList<T> FilterCollection<T>(IList<T> original, FilterDelegate<T> filter)
        {
            List<T> filtered = new List<T>();
            foreach (T item in original)
            {
                if (filter(item))
                {
                    filtered.Add(item);
                }
            }

            return filtered;
        }

        /// <summary>
        /// Filters positive numbers.
        /// </summary>
        /// <param name="number">Number to check.</param>
        /// <returns>True if number is bigger than 0.</returns>
        public static bool PositivieNumberFilter(int number)
        {
            return number > 0;
        }

        /// <summary>
        /// Checks if value length is bigger than 2.
        /// </summary>
        /// <typeparam name="T">Type of value.</typeparam>
        /// <param name="value">Value to check.</param>
        /// <returns>True if value length is bigger than 2.</returns>
        public static bool LenghtLongerThan2<T>(T value)
        {
            return value.ToString().Length >= 2;
        }

        /// <summary>
        /// Main method.
        /// </summary>
        static void Main()
        {
            List<string> numbers = new List<string> { "as","a","tr","a" };
            var filtered = FilterCollection<string>(numbers, LenghtLongerThan2);

            Console.WriteLine(string.Join(",",filtered));
        }
    }
}
