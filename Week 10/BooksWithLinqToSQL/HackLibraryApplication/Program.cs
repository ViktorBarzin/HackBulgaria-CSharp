using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackLibraryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO : Get all books contained in the library
            string input = Console.ReadLine();
            Application(input);

        }

        private static void Application(string input)
        {
            do
            {
                string[] commands = input.ToLower().Split(' ');
                switch (commands[0])
                {
                    case "insert":
                        // Insert Book/Author
                        break;
                    case "get":
                        // Get all books contained in the library - sorted in alphabetical order by title.
                        // Get all books contained in the library sorted by author.
                        // Get all books sorted by gendre.
                        // Get all types of genders a given author has written.
                        // Get all books written by a given author
                        // Get the complete information of a book by its ISBN
                        // Get the complete information by Title(part of the title should also be accepted)
                        //
                        break;
                    case "loan":
                        // loan books
                        break;
                    case "exit":
                    case "quit":
                        Environment.Exit(0);
                        break;
                }
            }
            while (true);
        }
    }
}
