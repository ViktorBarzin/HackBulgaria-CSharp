/*
Write a method which takes an arbitrary number of strings and joins them using the specified separator.

string JoinStrings(string separator, params string[] strings)
*/

namespace JoiningStrings
{
    using System;
    using System.Text;

    public class Program
    {
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

        public static void Main(string[] args)
        {
            const string SEPARATOR = ",";
            string[] strings = { "a", "b", "c" };
            Console.WriteLine(JoinStrings(SEPARATOR, strings));
        }
    }
}