namespace SimpleFileEditor
{
    using System;
    using System.Text;

    /// <summary>
    /// Application class.
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Main method.
        /// </summary>
        public static void Main()
        {
            // TODO : separate logic
            // TODO : documentation
            // TODO : validation
            // TODO : TDD
            char[] splitChars = new[] { ' ', '.', '!', '?', ':', '\n', '"' };

            // string filePath = @"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp\Week 8\TEST\test.txt";
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();
            FileEditor fe1 = new FileEditor(filePath);

            // if (!File.Exists(filePath))
            // {
            //    throw new ArgumentNullException("File with such name does not exist!");
            // }
            do
            {
                Console.Write("Enter action:");
                string input = Console.ReadLine();
                string[] commands = input.Split(splitChars);

                switch (commands[0])
                {
                    case "list":
                        Console.WriteLine(fe1.List());
                        break;
                    case "clear":
                        fe1.Clear();
                        Console.WriteLine("SUCCES: File content cleared.");
                        break;
                    case "append":
                        StringBuilder appendText = new StringBuilder();
                        for (int i = 1; i < commands.Length; i++)
                        {
                            appendText.Append(string.Format(commands[i] + " "));
                        }

                        fe1.Append(appendText.ToString());
                        break;
                    case "appendline":
                    case "appendLine":
                        fe1.AppendLine();
                        Console.WriteLine("SUCCES: Added a new line.");
                        break;
                    case "linecount":
                    case "lineCount":
                        Console.WriteLine(string.Format("Number of lines :{0}", fe1.LinesCount()));
                        break;
                    case "exit":
                    case "quit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("ERROR:Invalid command!");
                        break;
                }
            }
            while (true);
        }
    }
}
