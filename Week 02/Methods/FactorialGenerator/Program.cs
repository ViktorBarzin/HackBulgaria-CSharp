namespace FactorialGenerator
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a method which generates all the factorials of the integers up to n. Use the yield operator.
    /// IEnumerable<![CDATA[<int>]]> GenerateFactorials(<![CDATA[int]]> n).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Generates factorial using yield operator.
        /// </summary>
        /// <param name="n">Integer factorial of this number.</param>
        /// <returns>The factorial of n.</returns>
        public static int FactorialGenerator(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }

        /// <summary>
        /// Generates all the factorials of the numbers smaller than n.
        /// </summary>
        /// <param name="n">Upper bound for numbers.</param>
        /// <returns>IEnumerable of <![CDATA[ints]]> which are the factorials of the numbers.</returns>
        public static IEnumerable<int> GenerateFactorials(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                yield return FactorialGenerator(i);
            }
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            foreach (var item in GenerateFactorials(input))
            {
                Console.WriteLine(item);
            }
        }
    }
}