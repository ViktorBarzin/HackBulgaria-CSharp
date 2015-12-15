/*
In the given language, implement the factorial function n!.
Implement it using a simple loop
*/

namespace FactorialWithLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the factorial number");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial of {0} is : {1}", n, factorial);
        }
    }
}
