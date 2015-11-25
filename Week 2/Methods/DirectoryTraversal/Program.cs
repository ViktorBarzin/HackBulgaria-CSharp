using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryTraversal
{
    class Program
    {
        public static void IterateDirectory(string dir)
        {

            DirectoryInfo directory = new DirectoryInfo(dir);
            foreach (var file in directory.GetFiles())
            {
                Console.WriteLine(file.Name);
            }
            foreach (var item in directory.GetDirectories())
            {
                Console.WriteLine(item.Name);
                IterateDirectory(item.FullName);
            }
            

        }
        static void Main(string[] args)
        {
           // IterateDirectory("C:\\Program Files");
            IterateDirectory("C:\\Users\\Viktor\\Desktop\\HQC-Exam-ConsoleWebServer");
        }
    }
}
