namespace SortAndSearchExtensions
{
    using System;
    using System.Collections.Generic;

    public static class SortAndSearchExtensions
    {
        public static IList<T> Swap<T>(this IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
            return list;
        }

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
