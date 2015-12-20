/*
Implement the following functions:

bool IsIncreasing(int[] sequence) which returns true if for every two consecutive elements a and b, a < b holds.
bool IsDecreasing(int[] sequence) which returns true if for every two consecutive elements a and b, a > b holds.
*/

namespace IncreasingAndDecreasingSequences
{
    using System;

    public class Program
    {
        public static bool IsIncreasing(int[] sequence)
        {
            bool isIncreasingVar = false;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] < sequence[i + 1])
                {
                    isIncreasingVar = true;
                }
                else
                {
                    return false;
                }
            }

            return isIncreasingVar;
        }

        public static bool IsDecreasing(int[] sequence)
        {
            bool isDecreasingVar = false;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] > sequence[i + 1])
                {
                    isDecreasingVar = true;
                }
                else
                {
                    return false;
                }
            }

            return isDecreasingVar;
        }

        public static void Main(string[] args)
        {
            int[] increasing = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] decreasing = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine("Sequence is increasing : {0}", IsIncreasing(increasing));

            Console.WriteLine("Sequence is decreasing : {0}", IsDecreasing(decreasing));
        }
    }
}
