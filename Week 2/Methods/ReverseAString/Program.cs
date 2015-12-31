namespace ReverseAString
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a method which takes a List as an argument and reverses it internally.
    /// void ReverseList(List<![CDATA[<int>]]> list)
    /// The reversed result should be stored inside the same list instance.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Reverses a list.
        /// </summary>
        /// <param name="list">List to be reversed.</param>
        public static void ReverseList(ref List<int> list)
        {
            list.Reverse();
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            List<int> input = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine("List before : ");
            foreach (var number in input)
            {
                Console.Write(number);
            }

            Console.WriteLine();
            ReverseList(ref input);
            Console.WriteLine("List After : ");
            foreach (var number in input)
            {
                Console.Write("{0}", number);
            }

            Console.WriteLine();
        }
    }
}