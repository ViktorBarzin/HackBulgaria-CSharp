namespace JoiningStrings
{
    using System;
    using System.Text;

    /// <summary>
    /// Write a method which takes an arbitrary number of strings and joins them using the specified separator.
    /// string JoinStrings(string separator, <![CDATA[params]]> string[] strings).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Takes a separator and arbitrary amount of strings and joins them.
        /// </summary>
        /// <param name="separator">Separator to join strings with.</param>
        /// <param name="strings">Strings to join.</param>
        /// <returns>New string of joined "strings" with "separator".</returns>
        public static string JoinStrings(string separator, params string[] strings)
        {
            StringBuilder result = new StringBuilder();
            foreach (string t in strings)
            {
                if (t != strings[strings.Length - 1])
                {
                    result.Append(t);
                    result.Append(separator);
                }
                else
                {
                    result.Append(t);
                }
            }

            return result.ToString();
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            const string SEPARATOR = ",";
            string[] strings = { "a", "b", "c" };
            Console.WriteLine(JoinStrings(SEPARATOR, strings));
        }
    }
}