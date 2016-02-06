namespace ExtremeElementsInAList
{
    using System;
    using System.Linq;

    /// <summary>
    /// Implement the following functions:
    /// <![CDATA[int]]> Min(<![CDATA[int]]>[] items) - returns the minimum element in items.
    /// <![CDATA[int]]> Max(<![CDATA[int]]>[] items) - returns the maximum element in items.
    /// <![CDATA[int]]> NthMin(<![CDATA[int]]> n, <![CDATA[int]]>[] items) - returns the nth minimum element in items.
    /// <![CDATA[int]]> NthMax(<![CDATA[int]]> n, <![CDATA[int]]>[] items) - returns the nth maximum element in items.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Returns the minimum element in the array.
        /// </summary>
        /// <param name="items">Input integer array.</param>
        /// <returns>The minimum integer.</returns>
        public static int Min(int[] items)
        {
            int min = items[0];
            return items.Concat(new[] { min }).Min();
        }

        /// <summary>
        /// Returns the biggest element in the array.
        /// </summary>
        /// <param name="items">Input integer array.</param>
        /// <returns>The biggest integer.</returns>
        public static int Max(int[] items)
        {
            int max = items[0];
            return items.Concat(new[] { max }).Max();
        }

        /// <summary>
        /// Returns the Nth biggest integer in input array.
        /// </summary>
        /// <param name="n">Nth biggest number.</param>
        /// <param name="items">Input integer array.</param>
        /// <returns>The Nth biggest integer.</returns>
        public static int NthMax(int n, int[] items)
        {
            items = items.OrderByDescending(c => c).ToArray();
            return items[n - 1];
        }

        /// <summary>
        /// Returns the Nth smallest integer in input array.
        /// </summary>
        /// <param name="n">Nth smallest number.</param>
        /// <param name="items">Input integer array.</param>
        /// <returns>The Nth smallest integer.</returns>
        public static int NthMin(int n, int[] items)
        {
            items = items.OrderByDescending(c => c).Reverse().ToArray();
            return items[n - 1];
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            int[] input = new int[5] { 1, 2, 3, 4, -3 };
            Console.WriteLine("Min numbers is : {0}", Min(input));
            Console.WriteLine("Max numbers is : {0}", Max(input));
            Console.WriteLine("Enter the nth max and min number you  want to see : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nth min numbers is : {0}", NthMax(n, input));
            Console.WriteLine("Nth min numbers is : {0}", NthMin(n, input));
        }
    }
}
