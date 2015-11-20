using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        public static string ReverseMe(string original)
        {
            char[] charArray = original.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse :");
            string input = Console.ReadLine();
            Console.WriteLine("Reversed of \"{0}\" is : \"{1}\"",input,ReverseMe(input));
        }
    }
}
