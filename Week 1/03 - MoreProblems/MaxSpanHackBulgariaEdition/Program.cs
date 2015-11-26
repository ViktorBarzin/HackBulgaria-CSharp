/*
Implement the following function: int MaxSpan(List<int> numbers) where numbers is a list of numbers.

Consider the leftmost and rightmost appearances of some value in the list.

We'll say that the "span" is the number of elements between the two inclusive.
A single value has a span of 1.

Returns the largest span found in the given array.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSpanHackBulgariaEdition
{
    class Program
    {
        public static int MaxSpan(List<int> numbers)
        {
            List<int> spanCounters = new List<int>();
            //int spanCounter = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                int spanCounter = 0;
                int lastindexof = numbers.LastIndexOf(numbers[i]);
                if (lastindexof != -1)
                {
                    spanCounter = (lastindexof - i) + 1;
                    spanCounters.Add(spanCounter);
                }
            }
            spanCounters.Sort((a, b) => -1 * a.CompareTo(b));
            return spanCounters[0];
        }
        static void Main(string[] args)
        {
            List<int> input = new List<int> { 1, 4, 2, 1, 4, 1, 4 };
            //  { 1, 2, 1, 1, 3} = 4
            //  {1, 4, 2, 1, 4, 1, 4} = 6
            //  {1, 4, 2, 1, 4, 4, 4} = 6
            //  {1,2,3,4,5,6,7,6,4,4,6,1,23,23,2}
            Console.WriteLine("Result : {0}", MaxSpan(input));

        }

    }
}
