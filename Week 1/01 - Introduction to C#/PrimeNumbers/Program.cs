/*
Prime numbers

The usual deal:

Check if number is prime -> IsPrime(n)
List the first n prime numbers -> ListFirstPrimes(n)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int ReturnPrime(int number)
        {
            int i;
            for (i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            return i;
        }
        public static List<int> ListFirstPrimes(int number)
        {
            List<int> PrimesList = new List<int>();
            for (int i = 0; i < number; i++)
            {
                if (IsPrime(i))
                {
                    PrimesList.Add(i);
                    //Console.WriteLine(i);
                }
            }
            return PrimesList;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check and the list of prime numbers smaller than yours :");
            int input = int.Parse(Console.ReadLine());
            ListFirstPrimes(input);

            foreach (int number in ListFirstPrimes(input))
            {
                Console.Write(number + " ");

            }
            Console.WriteLine();
        }
    }
}
