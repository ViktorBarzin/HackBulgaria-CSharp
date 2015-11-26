/*
Implement the two functions:

List<int> NumberToList(int n) which takes an integer and returns a list of its digits
int ListToNumber(string digits) which takes a list of digits and returns the number from those digits
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToListandListToNumber
{
    class Program
    {
        public static List<int> GetListOfDigits(int number)
        {
            List<int> listOgDigits = new List<int>();
            while (number > 0)
            {
                listOgDigits.Add(number % 10);
                number = number / 10;
            }
            listOgDigits.Reverse();
            return listOgDigits;
        }
        public static int ListToNumber(string digits)
        {
            int digitCounter = 0;
            foreach (var digit in digits)
            {
                digitCounter++;
            }
            return digitCounter;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("List of digits of the number {0} : ", input);
            foreach (var digits in GetListOfDigits(input))
            {
                Console.Write(digits);
            }
            Console.WriteLine();
            Console.WriteLine(ListToNumber(input.ToString()));
        }
    }
}
