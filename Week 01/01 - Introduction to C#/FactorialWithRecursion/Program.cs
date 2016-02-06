namespace FactorialWithRecursion
{
    using System;

    /// <summary>
    /// Implement the factorial function n!.
    /// Implement it using recursion.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Functions that finds the factorial of an input number.
        /// </summary>
        /// <param name="n">Factorial this number.</param>
        /// <returns>The factorial of the input number.</returns>
        public static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter the factorial number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The factorial of {0} is : {1}", n, Factorial(n));
        }
    }
}
