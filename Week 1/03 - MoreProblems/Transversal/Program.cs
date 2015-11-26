using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transversal
{
    class Program
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
        static void Main(string[] args)
        {
            List<int> transversal = new List<int>();
            //transversal.Add(4);
            //transversal.Add(5);
            //transversal.Add(6);

            //transversal.Add(1);
            //transversal.Add(2);

            transversal.Add(2);
            transversal.Add(3);
            transversal.Add(4);

            List<List<int>> family = new List<List<int>>();
            //family.Add(new List<int> { 5, 7, 9 });
            //family.Add(new List<int> { 1, 4, 3 });
            //family.Add(new List<int> { 2, 6 });

            //family.Add(new List<int> { 1, 5 });
            //family.Add(new List<int> { 2, 3 });
            //family.Add(new List<int> { 4, 7 });

            family.Add(new List<int> { 1, 7 });
            family.Add(new List<int> { 2, 3, 5 });
            family.Add(new List<int> { 4, 8 });

            Console.WriteLine(IsTransversal(transversal, family));


            //>>> IsTransversal({ 1, 2}, { { 1, 5}, { 2, 3}, { 4, 7} })
            //false
            //>>> IsTransversal({ 2, 3, 4}, { { 1, 7}, { 2, 3, 5}, { 4, 8} })
            //false
        }
    }
}
