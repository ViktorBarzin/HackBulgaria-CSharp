using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsStringAAnAnagramOfStringB
{
    class Program
    {
        public static string StringSort(string input)
        {
            char [] inputAsCharArr = input.ToCharArray();
            Array.Sort(inputAsCharArr);
            return new string(inputAsCharArr);
        }
        public static bool Anagram(string A, string B)
        {
            string SortedA = StringSort(A);
            string SortedB = StringSort(B);
            if (A.Length == B.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (SortedA[i] != SortedB[i])
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
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the tow strings you want to check :");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.WriteLine(Anagram(input1,input2));
        }
    }
}
