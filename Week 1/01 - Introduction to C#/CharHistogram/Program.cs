/*
Implement a funcion, called CharHistogram(string), which takes a string and returns a dictionary,
where each key is a character from string and
its value is the number of occurrences of that char in string.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharHistogram
{
    class Program
    {
        public static Dictionary<char, int> CharHistogram(string input)
        {
            Dictionary<char, int> CharHistogramDic = new Dictionary<char, int>();
            foreach (var letter in input)
            {
                if (CharHistogramDic.ContainsKey(letter))
                {
                    CharHistogramDic[letter] += 1;
                }
                else
                {
                    CharHistogramDic.Add(letter, 1);
                }
            }
            foreach (var letter in CharHistogramDic)
            {
                Console.WriteLine("Letter {0} : {1} occurences", letter.Key, letter.Value);
            }
            return CharHistogramDic;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to see the occurences of the letter in it :");
            string input = Console.ReadLine();
            CharHistogram(input);
        }
    }
}
