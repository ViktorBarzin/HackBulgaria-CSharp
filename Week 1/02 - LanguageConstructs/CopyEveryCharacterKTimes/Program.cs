/*
string CopyEveryChar(string input, int k)

Example: CopyEveryChar("tldr", 3) => "tttllldddrrr"
*/

namespace CopyEveryCharacterKTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static string CopyEveryChar(string input, int k)
        {
            StringBuilder result = new StringBuilder(string.Empty);
            for (int i = 0; i < input.Length; i++)
            {
                for (int q = 0; q < k; q++)
                {
                    result.Append(input[i]);
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
