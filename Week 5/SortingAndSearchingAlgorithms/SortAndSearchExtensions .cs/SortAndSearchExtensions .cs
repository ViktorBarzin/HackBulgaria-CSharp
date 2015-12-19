using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearchExtensions
{
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
                if (list[i].CompareTo(list[i + 1]) > 0)
                {
                    list.Swap(i, i + 1);
                    i = 0;
                }
            }
            return list;
        }

        public static IList<T> SelectionSort<T>(this IList<T> list)
            where T : IComparable
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int iMin = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j].CompareTo(list[iMin]) < 0)
                    {
                        iMin = j;
                    }
                }

                list.Swap(i, iMin);
            }

            return list;
        }

        public static int BinarySearch<T>(this IList<T> list, int search, int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentException("ERROR: List is empty");
            }
            else
            {
                int imid = (min + max) / 2;

                if (search.CompareTo(list[imid]) < 0)
                {
                    return list.BinarySearch(search, min, imid - 1);
                }
                else if (search.CompareTo(list[imid]) > 0)
                {
                    return list.BinarySearch(search, imid + 1, max);
                }
                else
                {
                    return imid;
                }
            }
        }
    }
}
