/*
Working with digits

Those are classic problems for using module division:

Given an integer n, return the number of digits in n -> CountDigits(n)
Given an integer n, return the sum of all digits in n -> SumDigits(n)
FactorialDigits(n) -> for example, if we have 145, we need to calculate 1! + 4! + 5!
*/

namespace WorkingWithDigits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static int CountDigits(int number)
        {
            string stringNumber = number.ToString();
            return stringNumber.Length;
        }

        public static int SumOfDigits(int number)
        {
            string stringNumber = number.ToString();

            return stringNumber.Sum(t => int.Parse(t.ToString()));
        }

        public static int SumOfDigitsWithoutString(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }

            return sum;
        }

        public static int FactorialOfDigits(int number)
        {
            List<int> listNumbers = new List<int>();
            while (number > 0)
            {
                listNumbers.Add(number % 10);
                number = number / 10;
            }

            return listNumbers.Sum(t => Factorial(t));
        }

        public static int Factorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer :");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of digits in {0} is : {1}", input, CountDigits(input));

            Console.WriteLine("Sums of the digits of the number {0} is : {1}", input, SumOfDigits(input));
            Console.WriteLine("Sums of the digits of the number {0} (without using String) is : {1}", input, SumOfDigitsWithoutString(input));
            Console.WriteLine("Factorial of the digits of the number {0} is : {1}", input, FactorialOfDigits(input));
        }
    }
}
