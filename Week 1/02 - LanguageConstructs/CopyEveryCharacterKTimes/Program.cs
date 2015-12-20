/*
string CopyEveryChar(string input, int k)

Example: CopyEveryChar("tldr", 3) => "tttllldddrrr"
*/

namespace CopyEveryCharacterKTimes
{
    using System;
    using System.Text;

    public class Program
    {
        public static string CopyEveryChar(string input, int k)
        {
            StringBuilder result = new StringBuilder(string.Empty);
            foreach (char t in input)
            {
                for (int q = 0; q < k; q++)
                {
                    result.Append(t);
                }
            }

            return result.ToString();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string and the times you want to copy every char :");
            string input = Console.ReadLine();
            int copyTimes = int.Parse(Console.ReadLine());
            Console.WriteLine(CopyEveryChar(input, copyTimes));
        }
    }
}
