namespace FibonacciWithMemoization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        private static long[] memo = new long[1000000];

        public static long Fib(int n)
        {
            if (memo[n] != 0)
            {
                return memo[n];
            }

            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            memo[n] = Fib(n - 1) + Fib(n - 2);

            return memo[n];
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Fib(500));
        }
    }
}
