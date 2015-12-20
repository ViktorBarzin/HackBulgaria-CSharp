/*
Implement a function which takes a string and returns a string which has the same
words but each word is in a reverse order.

string ReverseEveryWord(string sentence)
*/

using System.Linq;

namespace ReverseEachWordInASentence
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static string ReverseMe(string original)
        {
            char[] charArray = original.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ReverseEveryWord(string sentence)
        {
            string[] separators = new string[] { ",", ".", "!", "\'", " ", "\'s" };
            List<string> reversedWords = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(ReverseMe).ToList();

            return reversedWords.Aggregate(string.Empty, (current, reversedWord) => current + reversedWord + " ");
        }

        public static void Main(string[] args)
        {
        }
    }
}
