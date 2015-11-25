using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialGenerator
{
    class Program
    {
        public static int FactorialGenerator(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public static IEnumerable<int> GenerateFactorials(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                yield return FactorialGenerator(i);

            }
        }
        static void Main(string[] args)
        {
            int input = 5;
            foreach (var item in GenerateFactorials(input))
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(string.Join("\n", GenerateFactorials(input)));
        }
    }
}
