namespace Aggregates
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Arggregate.
    /// </summary>
    /// <typeparam name="T">Type of parameter.</typeparam>
    /// <param name="sum">Old sum.</param>
    /// <param name="number">Number to be added to the sum.</param>
    /// <returns>New sum.</returns>
    public delegate T AggregationDelegate<T>(T sum, T number);

    /// <summary>
    /// Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Aggregates a collection.
        /// </summary>
        /// <typeparam name="T">Type of param.</typeparam>
        /// <param name="original">Original list to agrregate.</param>
        /// <param name="aggregate">Defines how to aggregate the list.</param>
        /// <returns>Aggregated list.</returns>
        public static T AggregateCollection<T>(IList<T> original, AggregationDelegate<T> aggregate)
        {
            T sum = original[0];
            for (int i = 1; i < original.Count; i++)
            {
                sum = aggregate(sum, original[i]);
            }

            return sum;
        }

        /// <summary>
        /// Sums current sum with new number.
        /// </summary>
        /// <param name="currentSum">Current sum.</param>
        /// <param name="newNumber">Number to add to the current sum.</param>
        /// <returns>The new sum.</returns>
        public static decimal Sum(decimal currentSum, decimal newNumber)
        {
            return currentSum + newNumber;
        }

        /// <summary>
        /// Multiplies current number with new one.
        /// </summary>
        /// <param name="currentProduct">current product.</param>
        /// <param name="newNumber">Number to multiply with.</param>
        /// <returns></returns>
        public static decimal Product(decimal currentProduct, decimal newNumber)
        {
            return currentProduct * newNumber;
        }

        /// <summary>
        /// Main method.
        /// </summary>
        static void Main()
        {
            List<decimal> numbers = new List<decimal> { 1, 2, 6, 3, 2 };
            Console.WriteLine(AggregateCollection(numbers,Sum));
        }
    }
}
