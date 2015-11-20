/*
Sum all numbers in a given string

You are given a string, where there can be numbers.
Return the sum of all numbers in that string (not digits, numbers)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SumAllNumbersInAGivenString
{
    class Program
    {
        public static int ExtractNumbers(string input)
        {
            string inputAsInt = Regex.Replace(input, "[^0-9 _]", "");
            return int.Parse(inputAsInt);
        }
        public static List<int> NumbersToAdd(string input)
        {
            List<int> Numbers = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {

                    for (int k = i+1; k < input.Length; k++)
                    {
                        if (Char.IsDigit(input[k]))
                        {
                            //Numbers.Add(input[k]);
                        }
                    
                    }
                    //Numbers.Add(input[i]);
                }
            }

            return Numbers;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string input = Console.ReadLine();

            Console.WriteLine(ExtractNumbers(input));

            foreach (var item in NumbersToAdd(input))
            {
                Console.WriteLine(item);
            }
            //TODO: finish later
        }
    }
}
