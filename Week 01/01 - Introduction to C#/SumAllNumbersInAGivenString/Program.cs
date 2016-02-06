namespace SumAllNumbersInAGivenString
{
    using System;

    /// <summary>
    /// Sum all numbers in a given string
    /// You are given a string, where there can be numbers.
    /// Return the sum of all numbers in that string (not digits, numbers).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Gets all the integers from a string.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>The sum of all integers.</returns>
        public static int NumbersToAdd(string input)
        {
            int temp = 0;
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    int digit = input[i] - '0';
                    temp = (temp * 10) + digit;
                    if (i + 1 == input.Length)
                    {
                        sum += temp;
                    }
                }
                else
                {
                    sum += temp;
                    temp = 0;
                }
            }

            return sum;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter string :");
            string input = Console.ReadLine();

            Console.WriteLine(NumbersToAdd(input));
        }
    }
}
