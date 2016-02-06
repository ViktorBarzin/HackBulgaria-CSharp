namespace IsStringAAnAnagramOfStringB
{
    using System;

    /// <summary>
    /// <![CDATA[bool]]> Anagram(string A, string B) See http://en.wikipedia.org/wiki/Anagram
    /// No HashMaps, hashSets, or such stuff allowed.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Sorts the characters in input string.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>Sorted string of characters.</returns>
        public static string StringSort(string input)
        {
            char [] inputAsCharArr = input.ToCharArray();
            Array.Sort(inputAsCharArr);
            return new string(inputAsCharArr);
        }

        /// <summary>
        /// Checks if string a is anagram of string b.
        /// </summary>
        /// <param name="a">Input string a.</param>
        /// <param name="b">Input string b.</param>
        /// <returns>True if string a is anagram of string b.</returns>
        public static bool Anagram(string a, string b)
        {
            string sortedA = StringSort(a);
            string sortedB = StringSort(b);
            if (a.Length != b.Length)
            {
                return false;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (sortedA[i] != sortedB[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter the tow strings you want to check :");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.WriteLine(Anagram(input1,input2));
        }
    }
}
