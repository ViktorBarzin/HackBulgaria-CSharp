namespace DecodeAnURL
{
    using System;

    /// <summary>
    /// Write a function which decodes a given URL following these rules:
    /// %20=>' ', %3A=>':', %3D=>'?', %2F=>'/'
    /// Input 'kitten%20pic.jpg' Output 'kitten pic.jpg'
    /// string DecodeUrl(string input).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Decodes a url.
        /// </summary>
        /// <param name="url">String input.</param>
        /// <returns>Decoded URL.</returns>
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

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter URL to decode :");
            string inputUrl = Console.ReadLine();
            Console.WriteLine(DecodeUrl(inputUrl));
        }
    }
}
