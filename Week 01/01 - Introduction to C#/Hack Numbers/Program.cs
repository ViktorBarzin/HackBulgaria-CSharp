namespace Hack_Numbers
{
    using System;

    /// <summary>
    /// A hack number is an integer, that matches the following criteria:
    /// The number, represented in binary, is a palindrome
    /// The number, represented in binary, has an odd number of 1's in it
    /// Example of hack numbers:
    /// 1 is 1 in binary
    /// 7 is 111 in binary
    /// 7919 is 1111011101111 in binary
    /// Implement the following functions:
    /// IsHack(n) -> checks if n is a hack number
    /// NextHack(n) -> returns the next hack number, that is bigger than n.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Checks if a number is hack number.
        /// </summary>
        /// <param name="number">Number to check.</param>
        /// <returns>Returns true if the number is hack and false otherwise.</returns>
        public static bool IsHack(int number)
        {
            string numberAsBinary = Convert.ToString(number, 2);
            for (int i = 0, q = numberAsBinary.Length - 1; i < numberAsBinary.Length; i++, q--)
            {
                if (numberAsBinary[i] != numberAsBinary[q])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Returns next hack number.
        /// </summary>
        /// <param name="number">Starting number.</param>
        /// <returns>Returns next hack number after input "number".</returns>
        public static int NextHack(int number)
        {
            for (int i = number + 1; i < number * number; i++)
            {
                if (IsHack(i))
                {
                    return i;
                }
            }

            return 1;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter a number to see if it is \"hacked\": ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} is hacked : {1}", input, IsHack(input));
            Console.WriteLine("The next \"Hacked\" number is : {0}", NextHack(input));
        }
    }
}
