namespace Application
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Remoting.Metadata.W3cXsd2001;

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
            int[] arr = { 5, 2, 4, 6, 1, 3,0 };
            char[] charArr = { 'q', 'b', 'e', 'a' };
            //arr.(0,arr.Length);
            SortAndSearchExtensions.Mergesort(arr,0,arr.Length-1);
            Console.WriteLine(string.Join(", ", arr));

            // Console.WriteLine(arr.BinarySearch(6, 0, arr.Length));

            // TODO : Implement IComparer<T>
            // TODO : Binary search - not in list bugfix
        }
    }
}
