namespace IntegerPalinDromes
{
    using System;

    /// <summary>
    /// Check if given integer n is palindrome -> "IsIntegerPalindrome(n)
    /// Largest palindrome, smaller than given N -> "GetLargestPalindrome(N)".
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Checks if an integer is palindrome.
        /// </summary>
        /// <param name="number">Integer to check.</param>
        /// <returns>Returns true if input integer is palindrome.</returns>
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

        /// <summary>
        /// Function that finds the biggest palindrome number smaller than input integer.
        /// </summary>
        /// <param name="number">Input integer.</param>
        /// <returns>The biggest palindrome number smaller than the input integer.</returns>
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

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter a number to check if it is a palindrome");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} is palindrome : {1}", input, IsIntPalindrome(input));
            Console.WriteLine("The largest palindrome number smaller than {0} is : {1}", input, GetLargestPalindromeSmallerThanN(input));
        }
    }
}
