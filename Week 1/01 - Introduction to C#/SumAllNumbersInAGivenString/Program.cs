/*
Sum all numbers in a given string

You are given a string, where there can be numbers.
Return the sum of all numbers in that string (not digits, numbers)
*/
namespace SumAllNumbersInAGivenString
{
    using System;

    public class Program
    {
        public static int NumbersToAdd(string input)
        {
            int temp = 0;
            int sum = 0;
            foreach (char t in input)
            {
                if (char.IsDigit(t))
                {
                    int digit = t - '0';
                    temp = (temp * 10) + digit;
                }
                else
                {
                    sum += temp;
                    temp = 0;
                }
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string input = Console.ReadLine();

            Console.WriteLine(NumbersToAdd(input));

            // TODO: works if input ends with char
        }
    }
}
