namespace Application
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using SortAndSearchExtensions;

    /// <summary>
    /// Application class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        public static void Main()
        {
            int[] arr = { 5, 2, 4, 6, 1, 3 };
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            arr.InsertionSort();
            Console.WriteLine(string.Join(", ", arr));

            // Console.WriteLine(arr.BinarySearch(6, 0, arr.Length));

            // TODO : Implement IComparer<T>
            // TODO : Binary search - not in list bugfix
        }
    }
}
