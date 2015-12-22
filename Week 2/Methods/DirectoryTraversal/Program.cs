namespace DirectoryTraversal
{
    using System;
    using System.IO;

    public class Program
    {
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

        public static void Main(string[] args)
        {
        }
    }
}
