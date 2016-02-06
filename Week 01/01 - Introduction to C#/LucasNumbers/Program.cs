namespace LucasNumbers
{
    using System;

    /// <summary>
    /// Because Fibonacci is way too trivial, implement the following functions that work with Lucas series:
    /// NthLucas(n) -> returns the nth Lucas number
    /// FirstNLucas(n) -> returns a list of the first n Lucas numbers.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Finds the Nth Lucas number.
        /// </summary>
        /// <param name="n">Input integer.</param>
        /// <returns>Returns the Nth Lucas number.</returns>
        public static int NthLucasNumbers(int n)
        {
            switch (n)
            {
                case 0:
                    return 2;
                case 1:
                    return 1;
                default:
                    return NthLucasNumbers(n - 1) + NthLucasNumbers(n - 2);
            }
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter the Lucas number number");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("The {0}th Lucas numbers is : {1}", l, NthLucasNumbers(l));

            int a = 2, b = 1;
            Console.Write("{0} {1}", a, b);

            for (int i = 2; i < l; i++)
            {
                var c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
}