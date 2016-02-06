namespace Validation.cs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Character Validation class containing validation for Hero and Enemy.
    /// </summary>
    public class CharacterValidation
    {
        /// <summary>
        /// Checks if input is specified value words long.
        /// </summary>
        /// <param name="input">Input command to check.</param>
        /// <param name="length">Length to check.</param>
        /// <returns>True if input is "length" words long.</returns>
        public static bool IsLengthWordsLong(string input, int length)
        {
            string[] words = input.Split(' ');
            if (words.Length == length)
            {
                return true;
            }

            // TODO : hacking is bad...
            if (words[0] == "exit" || words[0] == "quit" || words[0] == "help")
            {
                return false;
            }

            Console.WriteLine("ERROR: Your input is not in correct format! Type \"help\" to see the help menu.");
            return false;
        }

        /// <summary>
        /// Checks if words from the input at specified indexes can be parsed to integer.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <param name="indexesToBeParsable">Array of indexes to check.</param>
        /// <returns>True if input is valid.</returns>
        public static bool IsWordParsableToInt(string input, int[] indexesToBeParsable)
        {
            // TODO : magic number for array
            string[] words = input.Split(' ');
            int[] outValues = new int[100];
            for (int i = 0; i < indexesToBeParsable.Length; i++)
            {
                if (!int.TryParse(words[indexesToBeParsable[i]], out outValues[i]))
                {
                    Console.WriteLine("ERROR: Wrong input for hero health, hero mana or hero mana regeneration.");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks if an input string sentence is longer than 2 words.
        /// </summary>
        /// <param name="input">Input sentence to check.</param>
        /// <returns>True if sentence contains 2 or more words.</returns>
        public static bool IsInputLongerThan2Words(string input)
        {
            string[] words = input.Split(' ');
            return words.Length >= 2;
        }
    }
}
