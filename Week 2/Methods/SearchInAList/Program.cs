/*
Write a method which takes a list of strings as an argument and a string to search for.
If any of the strings in the list contains the searched string (as a substring), 
the method should return true. Otherwise it should return false. 
The first index of a string which contains the searched one should be stored in the out parameter.

bool TryFindSubstring(List<string> list, string searched, out foundIndex)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInAList
{
    class Program
    {
        public static bool TryFindSubstring(List<string> list, string searched, out int foundIndex)
        {
            foundIndex = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(searched))
                {
                    foundIndex = i;
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            List<string> input = new List<string>() { "abc", "bca", "cab", "cba" };
            string searched = "cba";
            int index;
            Console.WriteLine(TryFindSubstring(input, searched, out index));
            Console.WriteLine(index);
        }
    }
}
