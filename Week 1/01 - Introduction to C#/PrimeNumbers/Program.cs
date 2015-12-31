namespace PrimeNumbers
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Prime numbers
    /// The usual deal:
    /// Check if number is prime -> IsPrime(n)
    /// List the first n prime numbers -> ListFirstPrimes(n).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Checks if an integer is prime.
        /// </summary>
        /// <param name="number">Integer to check.</param>
        /// <returns>True if integer is prime.</returns>
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
        
        /// <summary>
        /// Lists the first primes smaller than input integer.
        /// </summary>
        /// <param name="number">Input integer.</param>
        /// <returns>A List of the prime numbers smaller than the input.</returns>
        public static List<int> ListFirstPrimes(int number)
        {
            List<int> primesList = new List<int>();
            for (int i = 0; i < number; i++)
            {
                if (IsPrime(i))
                {
                    primesList.Add(i);
                }
            }

            return primesList;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
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
