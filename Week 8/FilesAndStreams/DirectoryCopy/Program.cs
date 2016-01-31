namespace DirectoryCopy
{
    using System;
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
            // DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp\Week 1");
            // DirectoryCopy(dir, new DirectoryInfo(@"C:\Users\Viktor\Desktop\TEST"), true);
        }

        /// <summary>
        /// Copies a directory and its contents.
        /// </summary>
        /// <param name="original">Directory to copy.</param>
        /// <param name="destination">Destination to the new folder.</param>
        /// <param name="isRecursive">Shows if copying should be recursive.</param>
        private static void DirectoryCopy(DirectoryInfo original, DirectoryInfo destination, bool isRecursive)
        {
            if (!original.Exists)
            {
                throw new ArgumentException("Directory does not exist!");
            }

            DirectoryInfo[] dirs = original.GetDirectories();
            DirectoryInfo newDir = Directory.CreateDirectory(Path.Combine(destination.FullName, original.Name));
            FileInfo[] files = original.GetFiles();
            foreach (var file in files)
            {
                string temppath = Path.Combine(newDir.FullName, file.Name);
                file.CopyTo(temppath, true);
            }

            if (isRecursive)
            {
                foreach (var dir in dirs)
                {
                    DirectoryCopy(dir, newDir, true);
                }
            }
        }
    }
}
