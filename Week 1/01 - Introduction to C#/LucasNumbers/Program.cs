/*
Because Fibonacci is way too trivial, implement the following functions that work with Lucas series:

NthLucas(n) -> returns the nth Lucas number
FirstNLucas(n) -> returns a list of the first n Lucas numbers
*/

namespace LucasNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static int NthLucasNumbers(int n)
        {
            if (n == 0)
            {
                return 2;
            }

            if (n == 1)
            {
                return 1;
            }
            else
            {
                return NthLucasNumbers(n - 1) + NthLucasNumbers(n - 2);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Lucas number number");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("The {0}th Lucas numbers is : {1}", l, NthLucasNumbers(l));
            
            int a = 2, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);

            for (int i = 2; i < l; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
}