namespace SearchInAList
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a method which takes a list of strings as an argument and a string to search for.
    /// If any of the strings in the list contains the searched string (as a substring), 
    /// the method should return true. Otherwise it should return false. 
    /// The first index of a string which contains the searched one should be stored in the out parameter.
    /// <![CDATA[bool]]> TryFindSubstring(List<![CDATA[<string>]]> list, string searched, out foundIndex).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Read the task above.
        /// </summary>
        /// <param name="list">List of strings to search in.</param>
        /// <param name="searched">String to be searched.</param>
        /// <param name="foundIndex"><![CDATA[int]]> index.</param>
        /// <returns>True if searched is found.</returns>
        public static bool TryFindSubstring(List<string> list, string searched, out int foundIndex)
        {
            foundIndex = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (!list[i].Contains(searched))
                {
                    continue;
                }

                foundIndex = i;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            List<string> input = new List<string>() { "abc", "bca", "cab", "cba" };
            string searched = "cba";
            int index;
            Console.WriteLine(TryFindSubstring(input, searched, out index));
            Console.WriteLine(index);
        }
    }
}
