/*
bool Anagram(string A, string B) See http://en.wikipedia.org/wiki/Anagram

No HashMaps, hashSets, or such stuff allowed : )
*/

namespace IsStringAAnAnagramOfStringB
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static string StringSort(string input)
        {
            char [] inputAsCharArr = input.ToCharArray();
            Array.Sort(inputAsCharArr);
            return new string(inputAsCharArr);
        }

        public static bool Anagram(string a, string b)
        {
            string sortedA = StringSort(a);
            string sortedB = StringSort(b);
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (sortedA[i] != sortedB[i])
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the tow strings you want to check :");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.WriteLine(Anagram(input1,input2));
        }
    }
}
