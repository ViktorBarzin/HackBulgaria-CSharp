/*
Implement a function which takes a string and returns a string which has the same
words but each word is in a reverse order.

string ReverseEveryWord(string sentence)
*/

namespace ReverseEachWordInASentence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
            List<string> reversedWords = new List<string>();
            foreach (string word in sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries))
            {
                reversedWords.Add(ReverseMe(word));
            }

            string result = string.Empty;
            foreach (var reversedWord in reversedWords)
            {
                result = result + reversedWord + " ";
            }

            return result;
        }

        public static void Main(string[] args)
        {
            string input = "Ab Cd Ef Gh";
            Console.WriteLine(ReverseEveryWord(input));
        }
    }
}
