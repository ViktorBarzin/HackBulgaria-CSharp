namespace FixSubtitles
{
    using System;
    using System.IO;
    using System.Linq.Expressions;
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
            // TODO : do from scratch
            string file = @"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp\Week 8\TEST\lost.s04e11.hdtv.xvid-2hd.html";

            FixEncoding(file);
        }

        /// <summary>
        /// Fixes CRT file's encoding.
        /// </summary>
        /// <param name="path">Path to the file.</param>
        private static void FixEncoding(string path)
        {
            FileInfo file = new FileInfo(path);
            string backupPath = Path.GetDirectoryName(path);
            FileInfo backupFile = file.CopyTo(string.Format(backupPath + "\\" + Path.GetFileNameWithoutExtension(path) + "BACKUP" + Path.GetExtension(path)));

            Encoding win1251 = Encoding.GetEncoding(1251);
            Encoding utf8 = Encoding.UTF8;

            //var s = Console.In.ReadToEnd();
            //var win1251 = Encoding.GetEncoding("windows-1251");
            //var b = Encoding.Convert(win1251, Encoding.UTF8, Encoding.Unicode.GetBytes(s));
            //File.WriteAllText(backup.FullName, Encoding.UTF8.GetString(b));

            //StringBuilder text = new StringBuilder();
            //StreamReader reader = new StreamReader(path, Encoding.GetEncoding("windows-1251"));
            //using (reader)
            //{
            //    string line = string.Empty;

            //    while (line != null)
            //    {
            //        line = reader.ReadLine();
            //        text.Append(line);
            //    }
            //}
            StreamWriter writer = new StreamWriter(backupPath);
            using (writer)
            {
                writer.WriteLine(
                    
                    
                    
                    
                    );
            }
        }
    }
}
