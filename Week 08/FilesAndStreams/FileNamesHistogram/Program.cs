namespace FileNamesHistogram
{
    using System;
    using System.IO;
    using System.Linq;

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
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp");
            var res =
                dir.EnumerateFiles("*", SearchOption.AllDirectories)
                   .GroupBy(x => x.Name)
                   .Select(y => new { Name = y.Key, Count = y.Count() })
                   .ToList()
                   .OrderBy(z => z.Name);
            Console.WriteLine(string.Join("\n", res));
        }
    }
}
