/*
A hack number is an integer, that matches the following criteria:

The number, represented in binary, is a palindrome
The number, represented in binary, has an odd number of 1's in it
Example of hack numbers:

1 is 1 in binary
7 is 111 in binary
7919 is 1111011101111 in binary
Implement the following functions:

IsHack(n) -> checks if n is a hack number
NextHack(n) -> returns the next hack number, that is bigger than n
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hack_Numbers
{
    class Program
    {
        public static bool isHack(int number)
        {
            string numberAsBinary = Convert.ToString(number, 2);
            for (int i = 0, q = numberAsBinary.Length - 1; i < numberAsBinary.Length; i++, q--)
            {
                if (numberAsBinary[i] != numberAsBinary[q])
                {
                    return false;
                }
            }
            return true;
        }

        public static int NextHack(int number)
        {
            for (int i = number + 1; i < number * number; i++)
            {
                if (isHack(i))
                {
                    return i;
                }
            }
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to see if it is \"hacked\": ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} is hacked : {1}", input, isHack(input));
            Console.WriteLine("The next \"Hacked\" number is : {0}",NextHack(input));
        }
    }
}
