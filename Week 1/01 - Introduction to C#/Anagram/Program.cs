namespace Anagram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Task - IsAnagram(A, B) - returns true, if the string A is an anagram of B.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Checks if string a is Anagram of string b.
        /// </summary>
        /// <param name="a">First input string.</param>
        /// <param name="b">Second input string.</param>
        /// <returns>Returns if both strings are anagrams.</returns>
        public static bool IsAnagram(string a, string b)
        {
            Dictionary<char, int> dictA = new Dictionary<char, int>();
            foreach (var letter in a)
            {
                if (dictA.ContainsKey(letter))
                {
                    dictA[letter] += 1;
                }
                else
                {
                    dictA.Add(letter, 1);
                }
            }

            Dictionary<char, int> dictB = new Dictionary<char, int>();
            foreach (var letter in b)
            {
                if (dictB.ContainsKey(letter))
                {
                    dictB[letter] += 1;
                }
                else
                {
                    dictB.Add(letter, 1);
                }
            }

            bool isEqual = dictA.OrderBy(r => r.Key).SequenceEqual(dictB.OrderBy(r => r.Key));
            return isEqual;
        }

        /// <summary>
        /// Main function.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter first string :");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Enter second string :");
            string secondInput = Console.ReadLine();
            Console.WriteLine("String \"{0}\" and string \"{1}\" are anagrams : {2}  ", firstInput, secondInput, IsAnagram(firstInput, secondInput));
        }
    }
}
