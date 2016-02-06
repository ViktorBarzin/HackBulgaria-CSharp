namespace CopyEveryCharacterKTimes
{
    using System;
    using System.Text;

    /// <summary>
    /// String CopyEveryChar(string input, integer number)
    /// Example: CopyEveryChar(<![CDATA["tldr"]]>, 3) => <![CDATA["tttllldddrrr"]]>.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Copies every character "k" times.
        /// </summary>
        /// <param name="input">String input.</param>
        /// <param name="k">Integer input.</param>
        /// <returns>Returns string with each character copied integer input times.</returns>
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

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter the string and the times you want to copy every char :");
            string input = Console.ReadLine();
            int copyTimes = int.Parse(Console.ReadLine());
            Console.WriteLine(CopyEveryChar(input, copyTimes));
        }
    }
}
