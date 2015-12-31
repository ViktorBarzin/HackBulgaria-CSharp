namespace FactorialWithLoop
{
    using System;

    /// <summary>
    /// In the given language, implement the factorial function n!.
    /// Implement it using a simple loop.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter the factorial number");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial of {0} is : {1}", n, factorial);
        }
    }
}
