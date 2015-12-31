namespace Transversal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Lets have a set of sets:
    /// A = { {1, 2, 3} , {4, 5, 6}, {7, 8, 9} }
    /// A transversal T for A is a set that contains at least one element from each set of A.
    /// For example: T = {1, 4, 7}
    /// Implement a function <![CDATA[bool]]> IsTransversal(List<![CDATA[<int>]]> transversal, List<![CDATA[<List<int>>]]> family),
    /// which checks if given set is a valid transversal for another family of sets(set of sets).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Checks if at least one of the "transversal" integers exists in all of the "family" integers.
        /// </summary>
        /// <param name="transversal">List of Integer numbers to check.</param>
        /// <param name="family">List of List of integers numbers who are supposed to contain the transversal integers.</param>
        /// <returns>Returns true if the "transversal" List has fulfilled the transversal condition.</returns>
        public static bool IsTransversal(List<int> transversal, List<List<int>> family)
        {
            bool isTrans = false;
            foreach (List<int> sublist in family)
            {
                isTrans = transversal.Any(t => sublist.Contains(t));

                if (!isTrans)
                {
                    return false;
                }
            }

            return isTrans;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            List<int> transversal = new List<int> { 2, 3, 4 };

            List<List<int>> family = new List<List<int>> { new List<int> { 1, 7 }, new List<int> { 2, 3, 5 }, new List<int> { 4, 8 } };

            Console.WriteLine(IsTransversal(transversal, family));
        }
    }
}
