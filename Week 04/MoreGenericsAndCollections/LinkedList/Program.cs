namespace DataStructures
{
    using System;

    /// <summary>
    /// Application class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        public static void Main()
        {
            // TODO : linked list indexer
            // TODO : potential bugfixing required

            // TODO : check dynamic array item deletion
            // TODO : bugfix dynamic array item insertion for more than 10 elements

            // TODO : implement remove / clear operations
            int?[] arr = new int?[5];
            arr[1] = 5;
            Console.WriteLine(arr[1]);
            arr[1] = null;
            Console.WriteLine(arr[1]);
        }
    }
}
