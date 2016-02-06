namespace ReverseEachWordInASentence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Implement a function which takes a string and returns a string which has the same
    /// words but each word is in a reverse order.
    /// string ReverseEveryWord(string sentence).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Reverses a string input.
        /// </summary>
        /// <param name="original">String input.</param>
        /// <returns>Reversed input.</returns>
        public static string ReverseMe(string original)
        {
            char[] charArray = original.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Reverses every word in an input.
        /// </summary>
        /// <param name="sentence">String input.</param>
        /// <returns>String input with every word reversed.</returns>
        public static string ReverseEveryWord(string sentence)
        {
            string[] separators = new string[] { ",", ".", "!", "\'", " ", "\'s" };
            List<string> reversedWords = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(ReverseMe).ToList();

            return reversedWords.Aggregate(string.Empty, (current, reversedWord) => current + reversedWord + " ");
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.Write("Enter your sentence ro reverse :");
            Console.WriteLine(ReverseEveryWord(Console.ReadLine()));
        }
    }
}
