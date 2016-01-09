using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortWithAPredicate
{
    public delegate bool ReturnBigger<T>(T a, T b);
    class Program
    {
        public static List<T> Swap<T>(List<T> list, int indexA, int indexB)
        {
            T temp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = temp;
            return list;
        }

        public static List<T> BubbleSort<T>(List<T> list, ReturnBigger<T> del)
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

        public static bool GetBigger<T>(T a, T b)
            where T : IComparable
        {
            return a.CompareTo(b) < 0;
        }

        static void Main(string[] args)
        {
            List<decimal> numbers = new List<decimal> { 5, 4, 2, 7, 1 };
            BubbleSort(numbers, GetBigger);
            Console.WriteLine(string.Join(",", numbers));
        }
    }
}
