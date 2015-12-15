/*
Implement a function, called CountConsonants(str),
which returns the count of all consonants in the string str.
*/

namespace ConsonantsInAString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static int CountConsonants(string input)
        {
            char[] consonants = { 'b', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
            int consonantCounter = input.Count(x => consonants.Contains(char.ToLower(x)));
            return consonantCounter;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to count the consonants :");
            string input = Console.ReadLine();
            Console.WriteLine("The number of consonants in \"{0}\" is : {1}", input, CountConsonants(input));
        }
    }
}
