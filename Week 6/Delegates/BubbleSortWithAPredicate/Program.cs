namespace BubbleSortWithAPredicate
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// Application class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Swaps 2 elements from a list.
        /// </summary>
        /// <typeparam name="T">Type of the elements in the list.</typeparam>
        /// <param name="list">List in thich to make changes</param>
        /// <param name="indexA">First index to swap.</param>
        /// <param name="indexB">Second index to swap.</param>
        /// <returns></returns>
        public static List<T> Swap<T>(List<T> list, int indexA, int indexB)
        {
            T temp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = temp;
            return list;
        }

        /// <summary>
        /// Implements the Bubble sort algorithm.
        /// </summary>
        /// <typeparam name="T">Type of the elements in the list.</typeparam>
        /// <param name="list">List to sort.</param>
        /// <param name="del">Delegate which shows how to sort the list.</param>
        /// <returns>Sorted list.</returns>
        public static List<T> BubbleSort<T>(List<T> list, Func<T ,T,bool> del)
            where T : IComparable
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (del(list[i], list[i + 1]))
                    {
                        Swap(list, i, i + 1);
                        sorted = false;
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// Gets the bigger of the elements.
        /// </summary>
        /// <typeparam name="T">Type of the variables.</typeparam>
        /// <param name="a">First variable.</param>
        /// <param name="b">Second variable.</param>
        /// <returns></returns>
        public static bool GetBigger<T>(T a, T b)
            where T : IComparable
        {
            return a.CompareTo(b) > 0;
        }

        /// <summary>
        /// Gets the smaller variable.
        /// </summary>
        /// <typeparam name="T">Type of the variables.</typeparam>
        /// <param name="a">First variable.</param>
        /// <param name="b">Second variable.</param>
        /// <returns></returns>
        private static bool GetSmaller<T>(T a, T b)
            where T: IComparable
        {
            return a.CompareTo(b) < 0;
        }

        /// <summary>
        /// Main method.
        /// </summary>
        static void Main()
        {
            List<decimal> numbers = new List<decimal> { 5, 4, 2, 7, 1 };
            BubbleSort(numbers, GetBigger);
            Console.WriteLine(string.Join(",", numbers));
        }
    }
}
