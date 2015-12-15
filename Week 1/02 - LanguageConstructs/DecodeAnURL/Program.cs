/*
Write a function which decodes a given URL following these rules:

%20=>' ' %3A=>':' %3D=>'?' %2F=>'/'

Input 'kitten%20pic.jpg' Output 'kitten pic.jpg'

string DecodeUrl(string input)
*/

namespace DecodeAnURL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
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

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter URL to decode :");
            string inputUrl = Console.ReadLine();
            Console.WriteLine(DecodeUrl(inputUrl));
        }
    }
}
