﻿namespace PalindromeScore
{
    using System;
    using System.Linq;

    /// <summary>
    /// We denote the "Palindrome score" of an integer by the following function:
    /// P(n) = 1, if n is palindrome
    /// P(n) = 1 + P(s) where s is the sum of n and the reverse of n
    /// Implement a function, called PScore(n), which finds the palindrome score for n.
    /// Lets see two examples:
    /// PScore(121) = 1, because 121 is a palindrome.
    /// PScore(48) = 3, because:
    /// P(48) = 1 + P(48 + 84) = 132
    /// P(132) = 1 + 1 + P(132 + 321 = 363)
    /// P(363) = 1.
    /// When we return from the recursion, we get 3.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Recursively finds the palindrome score of a number. 
        /// </summary>
        /// <param name="number">Input number.</param>
        /// <returns>Palindrome score of that number.</returns>
        public static int PScore(int number)
        {
            if (IsPalindrom(number))
            {
                return 1;
            }
            else
            {
                return 1 + PScore(number + ReverseNumber(number));
            }
        }

        /// <summary>
        /// Reverses an input integer.
        /// </summary>
        /// <param name="number">Integer to be reversed.</param>
        /// <returns>Reversed input integer.</returns>
        public static int ReverseNumber(int number)
        {
            return number.ToString().Reverse().Aggregate(0, (b, x) => (10 * b) + x - '0');
        }

        /// <summary>
        /// Checks if an integer is palindrome.
        /// </summary>
        /// <param name="number">Integer to check.</param>
        /// <returns>True if integer is palindrome.</returns>
        public static bool IsPalindrom(int number)
        {
            string numberAsString = number.ToString();
            for (int i = 0, q = numberAsString.Length - 1; i < numberAsString.Length; i++, q--)
            {
                if (numberAsString[i] != numberAsString[q])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter a number to find its Palindrome Score :");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Palindrome score of {0} is : {1}", input, PScore(input));
        }
    }
}
