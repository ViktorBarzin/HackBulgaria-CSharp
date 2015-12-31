namespace IsAnAnagramOfStringAASUBSEQUENCEInB
{
    using System;

    /// <summary>
    /// Is an anagram of String A a SUBSEQUENCE in B?
    /// Return whether an anagram of String A can be found in String B.
    /// bool HasAnagramOf(string A, string B).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Checks if parameter "strToCheck" has anagram of parameter "substr".
        /// </summary>
        /// <param name="substr">String parameter.</param>
        /// <param name="strToCheck">String parameter.</param>
        /// <returns></returns>
        public static bool HasAnagramOf(string substr, string strToCheck)
        {
            return strToCheck.Contains(substr);
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter substring to check if exeist :");
            string subStr = Console.ReadLine();
            Console.WriteLine("Enter string to be checked :");
            string strToCheck = Console.ReadLine();
            Console.WriteLine(HasAnagramOf(subStr, strToCheck));
        }
    }
}
