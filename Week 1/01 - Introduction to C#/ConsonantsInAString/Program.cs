namespace ConsonantsInAString
{
    using System;
    using System.Linq;

    /// <summary>
    /// Implement a function, called CountConsonants(string),
    /// which returns the count of all consonants in the string.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Counts consonants in a string.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>The number of consonants in the input.</returns>
        public static int CountConsonants(string input)
        {
            char[] consonants = { 'b', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
            int consonantCounter = input.Count(x => consonants.Contains(char.ToLower(x)));
            return consonantCounter;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter a string to count the consonants :");
            string input = Console.ReadLine();
            Console.WriteLine("The number of consonants in \"{0}\" is : {1}", input, CountConsonants(input));
        }
    }
}
