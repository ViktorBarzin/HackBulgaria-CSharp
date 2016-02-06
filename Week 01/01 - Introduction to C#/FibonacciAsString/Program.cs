namespace FibonacciAsString
{
    using System;

    /// <summary>
    /// Implement a function, called FibNumber(n), which takes an integer n and returns a number,
    /// which is formed by concatenating the first n Fibonacci numbers.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Function to solve the task.
        /// </summary>
        /// <param name="len">Length of the output number.</param>
        /// <returns>A number which has len size and is formed by concatenating first n Fibonacci numbers.</returns>
        public static string FibonacciIterative(int len)
        {
            string fibAsString = "1";
            int a = 0, b = 1;

            for (int i = 2; i <= len; i++)
            {
                var c = a + b;
                fibAsString += c;
                a = b;
                b = c;
            }

            return fibAsString;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter the nth fibobacci number you want to see the list up to : ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciIterative(input));
        }
    }
}
