using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEachWordInASentence
{
    class Program
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

            string result = "";
            foreach (var reversedWord in reversedWords)
            {
                result = result + reversedWord + " ";
            }
            return result;
        }
        static void Main(string[] args)
        {
            string input = "Ab Cd Ef Gh";
            Console.WriteLine(ReverseEveryWord(input));
        }
    }
}
