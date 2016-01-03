namespace SortAndSearchExtensions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// SortAndSearchExtensions containing extension methods for sorting and searching.
    /// </summary>
    public static class SortAndSearchExtensions
    {
        /// <summary>
        /// IList extension method for swapping 2 elements.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="list">List of generic items.</param>
        /// <param name="indexA">First index to swap.</param>
        /// <param name="indexB">Second index to swap.</param>
        /// <returns>The IList with swapped elements.</returns>
        public static IList<T> Swap<T>(this IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
            return list;
        }

        /// <summary>
        /// Implements the Bubble sort algorithm.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="list">List of generic items.</param>
        /// <returns>The IList sorted in ascending order.</returns>
        public static IList<T> BubbleSort<T>(this IList<T> list)
            where T : IComparable
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].CompareTo(list[i + 1]) <= 0)
                {
                    continue;
                }

                list.Swap(i, i + 1);
                i = 0;
            }

            return list;
        }

        /// <summary>
        /// Implements the Selection sort algorithm.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="list">List to be sorted.</param>
        /// <returns>The IList sorted in ascending order.</returns>
        public static IList<T> SelectionSort<T>(this IList<T> list)
            where T : IComparable
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j].CompareTo(list[min]) < 0)
                    {
                        min = j;
                    }
                }

                list.Swap(i, min);
            }

            return list;
        }

        /// <summary>
        /// Implements the Insertion sort algorithm.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="list">List to be sorted.</param>
        /// <returns>The IList sorted in ascending order.</returns>
        public static IList<T> InsertionSort<T>(this IList<T> list)
            where T : IComparable
        {
            // 5, 2, 4, 6, 1, 3
            for (int j = 1; j < list.Count; j++)
            {
                T key = list[j];
                int i = j - 1;
                while (i >= 0 && list[i].CompareTo(key) > 0)
                {
                    list[i + 1] = list[i];
                    i -= 1;
                }
                list[i + 1] = key;
            }

            return list;
        }

        /// <summary>
        /// Implements binary search algorithm.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="list">List to be searched in.</param>
        /// <param name="search">Integer to search.</param>
        /// <param name="min">Beginning of the list.</param>
        /// <param name="max">End of the list.</param>
        /// <returns>The searched integer.</returns>
        public static int BinarySearch<T>(this IList<T> list, int search, int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentException("ERROR: List is empty");
            }

            int imid = (min + max) / 2;

            if (search.CompareTo(list[imid]) < 0)
            {
                return list.BinarySearch(search, min, imid - 1);
            }

            if (search.CompareTo(list[imid]) > 0)
            {
                return list.BinarySearch(search, imid + 1, max);
            }

            return imid;
        }
    }
}
