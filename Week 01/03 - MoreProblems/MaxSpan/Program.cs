﻿namespace MaxSpan
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// You are given a list of <![CDATA[ints]]>.Lets say a span is the numbers between the occurrence of
    /// the same number.
    /// For example the span in this list : {1,2,4,22,4,1}
    /// is 6(between the two 1s inclusive).
    /// Your task is to find the biggest span of numbers.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Finds the biggest span between 2 equal integers in a list.
        /// </summary>
        /// <param name="numbers">List input.</param>
        /// <returns>The biggest span between 2 equal integers.</returns>
        public static int MaxSpan(List<int> numbers)
        {
            int spanCounter = 0;
            List<int> spanCounters = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int k = i + 1; k < numbers.Count; k++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        spanCounter = 0;
                        break;
                    }
                    else if (numbers[i] == numbers[k])
                    {
                        spanCounters.Add(spanCounter);
                        Console.WriteLine("Counter to add :{0}, i:{1}, K: {2}", spanCounter, i, k);
                        spanCounter = 0;
                        break;
                    }
                    else
                    {
                        spanCounter++;
                    }

                    if (k == numbers.Count - 1)
                    {
                        spanCounter = 0;
                    }
                }
            }

            spanCounters.Sort((a, b) => -1 * a.CompareTo(b));
            return spanCounters[0];
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 1, 1, 1, 1, 2, 4, 2 };
            Console.WriteLine("Max Span is : {0}", MaxSpan(numbers));
        }
    }
}
