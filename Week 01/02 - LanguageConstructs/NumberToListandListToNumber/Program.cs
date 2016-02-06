namespace NumberToListandListToNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Implement the two functions:
    /// List<![CDATA[<int>]]> NumberToList(integer n) which takes an integer and returns a list of its digits
    /// integer ListToNumber(string digits) which takes a list of digits and returns the number from those digits.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Gets list of digits.
        /// </summary>
        /// <param name="number">Input integer.</param>
        /// <returns>List of digits of the input.</returns>
        public static List<int> GetListOfDigits(int number)
        {
            List<int> listOgDigits = new List<int>();
            while (number > 0)
            {
                listOgDigits.Add(number % 10);
                number = number / 10;
            }

            listOgDigits.Reverse();
            return listOgDigits;
        }

        /// <summary>
        /// Gets input's length.
        /// </summary>
        /// <param name="digits">String input.</param>
        /// <returns>Input's length.</returns>
        public static int ListToNumber(string digits)
        {
            return digits.Count();
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter a number :");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("List of digits of the number {0} : ", input);
            foreach (var digits in GetListOfDigits(input))
            {
                Console.Write(digits);
            }

            Console.WriteLine();
            Console.WriteLine(ListToNumber(input.ToString()));
        }
    }
}
