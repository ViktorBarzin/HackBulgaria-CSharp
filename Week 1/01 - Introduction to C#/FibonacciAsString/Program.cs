/*
Implement a function, called FibNumber(n), which takes an integer n and returns a number,
which is formed by concatenating the first n Fibonacci numbers.
*/

namespace FibonacciAsString
{
    using System;

    public class Program
    {
        public static string FibonacciIterative(int len)
        {
            string fibAsString = "1";
            int a = 0, b = 1, c = 0;

            for (int i = 2; i <= len; i++)
            {
                c = a + b;
                fibAsString += c;
                a = b;
                b = c;
            }

            return fibAsString;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the nth fibobacci number you want to see the list up to : ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciIterative(input));
        }
    }
}
