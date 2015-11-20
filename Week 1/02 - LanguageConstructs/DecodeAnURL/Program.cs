using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAnURL
{
    class Program
    {
        public static string DecodeUrl(string url)
        {
            for (int i = 0; i < url.Length; i++)
            {
                url = url.Replace("%20", " ");
                url = url.Replace("%3A", ":");
                url = url.Replace("%3D", "?");
                url = url.Replace("%2f", "/");
            }
            return url;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter URL to decode :");
            string inputUrl = Console.ReadLine();
            Console.WriteLine(DecodeUrl(inputUrl));
        }
    }
}
