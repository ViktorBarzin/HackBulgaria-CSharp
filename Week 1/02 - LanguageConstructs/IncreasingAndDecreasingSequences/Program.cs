namespace IncreasingAndDecreasingSequences
{
    using System;

    /// <summary>
    /// Implement the following functions:
    /// <![CDATA[bool]]> IsIncreasing(<![CDATA[int]]>[] sequence) which returns true if for every two consecutive elements a and b,<![CDATA[a < b]]>holds.
    /// <![CDATA[bool]]> IsDecreasing(<![CDATA[int]]>[] sequence) which returns true if for every two consecutive elements a and b, a > b holds.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Checks if a sequence is increasing.
        /// </summary>
        /// <param name="sequence">Input integer array.</param>
        /// <returns>True if sequence is increasing.</returns>
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

        /// <summary>
        /// Checks if a sequence is decreasing.
        /// </summary>
        /// <param name="sequence">Input integer array.</param>
        /// <returns>True if sequence is decreasing.</returns>
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

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            int[] increasing = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] decreasing = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine("Sequence is increasing : {0}", IsIncreasing(increasing));

            Console.WriteLine("Sequence is decreasing : {0}", IsDecreasing(decreasing));
        }
    }
}
