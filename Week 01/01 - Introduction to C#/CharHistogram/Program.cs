namespace CharHistogram
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Implement a function, called CharHistogram(string),
    ///  which takes a string and returns a dictionary, 
    /// where each key is a character from string and 
    /// its value is the number of occurrences of that char in string.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Calculates occurrences of a letter in a string input.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>A dictionary of letters and their count.</returns>
        public static Dictionary<char, int> CharHistogram(string input)
        {
            Dictionary<char, int> charHistogramDic = new Dictionary<char, int>();
            foreach (var letter in input)
            {
                if (charHistogramDic.ContainsKey(letter))
                {
                    charHistogramDic[letter] += 1;
                }
                else
                {
                    charHistogramDic.Add(letter, 1);
                }
            }

            foreach (var letter in charHistogramDic)
            {
                Console.WriteLine("Letter {0} : {1} occurences", letter.Key, letter.Value);
            }

            return charHistogramDic;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter a string to see the occurences of the letter in it :");
            string input = Console.ReadLine();
            CharHistogram(input);
        }
    }
}
