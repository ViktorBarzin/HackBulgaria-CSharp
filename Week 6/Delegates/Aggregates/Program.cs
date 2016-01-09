namespace Aggregates
{
    using System;
    using System.Collections.Generic;

    public delegate T AggregationDelegate<T>(T sum, T number);

    class Program
    {
        public static T AggregateCollection<T>(List<T> original, AggregationDelegate<T> aggregate)
        {
            T sum = original[0];
            for (int i = 1; i < original.Count; i++)
            {
                sum = aggregate(sum, original[i]);
            }

            return sum;
        }

        public static decimal Sum(decimal currentSum, decimal newNumber)
        {
            return currentSum + newNumber;
        }

        public static decimal Product(decimal currentProduct, decimal newNumber)
        {
            return currentProduct * newNumber;
        }

        static void Main()
        {
            List<decimal> numbers = new List<decimal> { 1, 2, 6, 3, 2 };
            Console.WriteLine(AggregateCollection(numbers,Sum));
        }
    }
}
