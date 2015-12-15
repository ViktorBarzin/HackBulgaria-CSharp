/*
Implement a function, called CountVowels(str),
which returns the count of all vowels in the string str.

Count uppercase vowels aswell!
*/

namespace VowelsInAString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static int CountVowels(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int vowelCounter = input.Count(x => vowels.Contains(char.ToLower(x)));
            return vowelCounter;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to count the vowels :");
            string input = Console.ReadLine();
            Console.WriteLine("The number of vowels in \"{0}\" is : {1}", input, CountVowels(input));
        }
    }
}
