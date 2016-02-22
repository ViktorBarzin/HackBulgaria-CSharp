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
            // TODO : finish UI
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
                    case "help":
                        HelpMenu();

                        break;
                    case "insert":
                        // Insert Book/Author
                        break;
                    case "create":
                        // Create author, book, user
                        break;
                    case "get":
                        // Get all books contained in the library - sorted in alphabetical order by title.
                        // Get all books contained in the library sorted by author.
                        // Get all books sorted by gendre.
                        // Get all types of genders a given author has written.
                        // Get all books written by a given author
                        // Get the complete information of a book by its ISBN
                        // Get the complete information by Title(part of the title should also be accepted)
                        // get a list of book, author, user? ids
                        break;
                    case "loan":
                        // loan books
                        break;
                    case "exit":
                    case "quit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid command \"{0}\"",input);
                        input = Console.ReadLine();

                        continue;
                }
                input = Console.ReadLine();
            }
            while (true);
        }

        private static void HelpMenu()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("help -> displays this menu");
            Console.WriteLine("create author <first name> <last name> <year born> <year died> <ids of writen books> -> creates new author");
            Console.WriteLine("create book <ISBN> <Title> <description> <publisher> <author id> <genre id> <how many copies are available> -> creates new book");
            Console.WriteLine("create user <first name> <last name> <pseudonim> <email> <phone> <how many books are borrowed> -> creates new user and adds him ot the library");
            Console.WriteLine("insert author <first name> <last name> -> inserts the selected author to the library");
            Console.WriteLine("insert book <ISBN> -> inserts new book with the selected isbn");

            Console.WriteLine("get all books -> returns a list of all books sorted by title");
            Console.WriteLine("get <author id> genres -> returns a list of genres an author has writen");
            Console.WriteLine("get all books by <author id> -> returns a list of books writen by <author id>");
            Console.WriteLine("book <book isbn> -> gets information on book based on <book isbn>");
            Console.WriteLine("book <title/ part of title> -> returns info on book based on title/part of the book title");
            Console.WriteLine("<user id> borrow <book isbn> -> <user id> request borrowing <book isbn>");
            Console.WriteLine("<user id> return <book isbn> -> <user id> returns <book isbn>");
            Console.WriteLine("get users/authors/books -> returns a list of users/authors/book ids/isbns");
            Console.WriteLine("-----------------------------------");
        }
    }
}
