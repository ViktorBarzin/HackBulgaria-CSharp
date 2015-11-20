﻿/*
Integer palindomes

Check if given integer n is palindrome -> IsIntPalindrome(n)
Largets palindrome, smaller than given N -> GetLargestPalindrome(N)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerPalinDromes
{
    class Program
    {
        public static bool IsIntPalindrome(int number)
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

        public static int GetLargestPalindromeSmallerThanN(int number)
        {
            for (int i = number; i > 0; i--)
            {
                if (IsIntPalindrome(i))
                {
                    return i;
                }
            }
            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is a palindrome");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} is palindrome : {1}",input, IsIntPalindrome(input));
            Console.WriteLine("The largest palindrome number smaller than {0} is : {1}",input,GetLargestPalindromeSmallerThanN(input));

        }
    }
}
