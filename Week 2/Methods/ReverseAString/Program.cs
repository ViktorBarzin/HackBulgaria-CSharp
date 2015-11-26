/*
Write a method which takes a List as an argument and reverses it internally.

void ReverseList(List<int> list)

The reversed result should be stored inside the same list instance.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        public static void ReverseList(ref List<int> list)
        {
            list.ToArray();
            list.Reverse();
            
        }
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine("List before : ");
            foreach (var number in input)
            {
                Console.Write(number);
            }
            Console.WriteLine();
            ReverseList(ref input);
            Console.WriteLine("List After : ");
            foreach (var number in input)
            {
                Console.Write("{0}",number);
            }
            Console.WriteLine();
        }
    }
}
