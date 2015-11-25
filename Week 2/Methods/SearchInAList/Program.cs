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
