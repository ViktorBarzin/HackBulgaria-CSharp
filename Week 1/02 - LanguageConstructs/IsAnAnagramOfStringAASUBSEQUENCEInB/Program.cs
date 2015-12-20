/*
Is an anagram of String A a SUBSEQUENCE in B?

Return whether an anagram of String A can be found in String B.

bool HasAnagramOf(string A,string B)
*/

namespace IsAnAnagramOfStringAASUBSEQUENCEInB
{
    using System;

    public class Program
    {
        public static bool HasAnagramOf(string substr, string strToCheck)
        {
            return strToCheck.Contains(substr); ;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter substring to check if exeist :");
            string subStr = Console.ReadLine();
            Console.WriteLine("Enter string to be checked :");
            string strToCheck = Console.ReadLine();
            Console.WriteLine(HasAnagramOf(subStr, strToCheck));
        }
    }
}
