namespace ToUpper
{
    using System.IO;

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
            string original = @"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp\Week 8\TEST\test.txt";
            string newFile = @"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp\Week 8\TEST\newFile.txt";
            ToUpper(original, newFile);
        }

        /// <summary>
        /// Converts all characters in na file to upper case.
        /// </summary>
        /// <param name="original">Original file path.</param>
        /// <param name="newFilePath">New file path.</param>
        private static void ToUpper(string original, string newFilePath)
        {
            using (StreamReader str = new StreamReader(original))
            {
                string line = str.ReadLine();
                while (line != null)
                {
                    using (StreamWriter cs = new StreamWriter(newFilePath))
                    {
                        cs.WriteLine(line.ToUpper());
                    }

                    line = str.ReadLine();
                }
            }
        }
    }
}
