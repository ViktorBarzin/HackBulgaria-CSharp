using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAnAnagramOfStringAASUBSEQUENCEInB
{
    class Program
    {
        public static bool HasAnagramOf(string substr, string strToCheck)
        {
            bool hasAnagram = true;
            for (int i = 0; i < strToCheck.Length; i++)
            {
                if (strToCheck[i] == substr[0])
                {
                    for (int k = 1; k < substr.Length; k++)
                    {
                        if (substr[k] != strToCheck[k + i])
                        {
                            hasAnagram = false;
                        }
                    }
                    hasAnagram = true;
                }
            }
            return hasAnagram;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter substring to check if exeist :");
            string subStr = Console.ReadLine();
            Console.WriteLine("Enter string to be checked :");
            string strToCheck = Console.ReadLine();
            Console.WriteLine(HasAnagramOf(subStr, strToCheck));
        }
    }
}
