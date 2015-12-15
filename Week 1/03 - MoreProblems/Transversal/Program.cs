/*
Lets have a set of sets:

A = { {1, 2, 3} , {4, 5, 6}, {7, 8, 9} }

A transversal T for A is a set that contains at least one element from each set of A.

For example: T = {1, 4, 7}

Implement a function bool IsTransversal(List<int> transversal, List<List<int>> family),
which checks if given set is a valid transerval for another family of sets (set of sets).
*/

namespace Transversal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static bool IsTransversal(List<int> transversal, List<List<int>> family)
        {
            bool isTrans = false;
            foreach (List<int> sublist in family)
            {
                isTrans = false;
                for (int i = 0; i < transversal.Count; i++)
                {
                    if (sublist.Contains(transversal[i]))
                    {
                        isTrans = true;
                        break;
                    }
                }

                if (!isTrans)
                {
                    return false;
                }
            }

            return isTrans;
        }

        public static void Main(string[] args)
        {
            List<int> transversal = new List<int>();
            transversal.Add(2);
            transversal.Add(3);
            transversal.Add(4);
            
            List<List<int>> family = new List<List<int>>();
            family.Add(new List<int> { 1, 7 });
            family.Add(new List<int> { 2, 3, 5 });
            family.Add(new List<int> { 4, 8 });

            Console.WriteLine(IsTransversal(transversal, family));
        }
    }
}
