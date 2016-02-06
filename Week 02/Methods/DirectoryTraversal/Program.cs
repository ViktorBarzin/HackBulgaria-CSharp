namespace DirectoryTraversal
{
    using System;
    using System.IO;

    /// <summary>
    /// Write a method which iterates through the contents of a directory and the contents of all its subdirectories. 
    /// Use the yield operator to return the name of each entry and sub-entry.
    /// IEnumerable<![CDATA[<string>]]> IterateDirectory(DirectoryInfo directory).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Iterates through each directory and its subdirectories.
        /// </summary>
        /// <param name="dir">String input where to start the search.</param>
        public static void IterateDirectory(string dir)
        {
            DirectoryInfo directory = new DirectoryInfo(dir);
            foreach (FileInfo file in directory.GetFiles())
            {
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo item in directory.GetDirectories())
            {
                Console.WriteLine(item.Name);
                IterateDirectory(item.FullName);
            }
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
        }
    }
}
