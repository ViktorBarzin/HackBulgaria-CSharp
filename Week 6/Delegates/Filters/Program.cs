namespace Filters
{
    using System;
    using System.Collections.Generic;

    public delegate bool FilterDelegate<T>(T number);

    public class Program
    {
        public static List<T> FilterCollection<T>(List<T> original, FilterDelegate<T> filter)
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

        public static bool PositivieNumberFilter(int number)
        {
            return number > 0;
        }

        public static bool LenghtLongerThan2<T>(T value)
        {
            return value.ToString().Length >= 2;
        }

        static void Main(string[] args)
        {
            List<string> numbers = new List<string> { "as","a","tr","a" };
            var filtered = FilterCollection<string>(numbers, LenghtLongerThan2);

            Console.WriteLine(string.Join(",",filtered));
        }
    }
}
