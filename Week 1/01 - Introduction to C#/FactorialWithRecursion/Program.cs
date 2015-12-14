/*
Implement the factorial function n!.
Implement it using recursionn.
*/

namespace FactorialWithRecursion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the factorial number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The factorial of {0} is : {1}", n, Factorial(n));
        }
    }
}
