/*
Implement a function which takes a string and returns the same in a reversed order.

string ReverseMe(string original)
*/

namespace ReverseAString
{
    using System;

    public class Program
    {
        public static string ReverseMe(string original)
        {
            char[] charArray = original.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse :");
            string input = Console.ReadLine();
            Console.WriteLine("Reversed of \"{0}\" is : \"{1}\"", input, ReverseMe(input));
        }
    }
}
