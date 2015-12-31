namespace ReverseAString
{
    using System;

    /// <summary>
    /// Implement a function which takes a string and returns the same in a reversed order.
    /// string ReverseMe(string original).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Reverses an input string.
        /// </summary>
        /// <param name="original">Input string.</param>
        /// <returns>Input string reversed.</returns>
        public static string ReverseMe(string original)
        {
            char[] charArray = original.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter a string to reverse :");
            string input = Console.ReadLine();
            Console.WriteLine("Reversed of \"{0}\" is : \"{1}\"", input, ReverseMe(input));
        }
    }
}
