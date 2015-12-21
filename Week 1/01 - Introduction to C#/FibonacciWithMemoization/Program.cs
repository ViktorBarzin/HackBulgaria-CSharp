namespace FibonacciWithMemoization
{
    using System;

    public class Program
    {
        private static readonly long[] Memo = new long[1000000];

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

        public static void Main(string[] args)
        {
            Console.WriteLine(Fib(500));
        }
    }
}
