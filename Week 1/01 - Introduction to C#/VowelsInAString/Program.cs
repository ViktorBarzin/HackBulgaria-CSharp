namespace VowelsInAString
{
    using System;
    using System.Linq;

    /// <summary>
    /// Implement a function, called CountVowels(string),
    /// which returns the count of all vowels in the string.
    /// Count uppercase vowels as well.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Counts vowels in a string.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>The count of vowels in a string.</returns>
        public static int CountVowels(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int vowelCounter = input.Count(x => vowels.Contains(char.ToLower(x)));
            return vowelCounter;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter a string to count the vowels :");
            string input = Console.ReadLine();
            Console.WriteLine("The number of vowels in \"{0}\" is : {1}", input, CountVowels(input));
        }
    }
}
