namespace FibonacciWithMemoization
{
    using System;

    /// <summary>
    /// Print Fibonacci numbers via recursion effectively.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// An array to save already calculated numbers.
        /// </summary>
        private static readonly long[] Memo = new long[1000000];

        /// <summary>
        /// Fibonacci number generator.
        /// </summary>
        /// <param name="n">Nth Fibonacci number.</param>
        /// <returns>Returns the nth Fibonacci number.</returns>
        public static long Fib(int n)
        {
            if (Memo[n] != 0)
            {
                return Memo[n];
            }

            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
            }

            Memo[n] = Fib(n - 1) + Fib(n - 2);

            return Memo[n];
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine(Fib(500));
        }
    }
}
