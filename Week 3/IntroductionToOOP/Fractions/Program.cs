using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Fractions fractions = new Fractions(9, 2);
            Fractions fractions1 = new Fractions(10, 3);
            //Console.WriteLine(fractions.Equals(fractions1));
            //fractions.ToString();
            //Console.WriteLine(fractions == fractions1);
            //Console.WriteLine(fractions1.GetHashCode());
            //Console.WriteLine(fractions + fractions1);
            Console.WriteLine(fractions + 5.8);

            //TODO : add explicit cast 
			//TODO : add operators - / * between 2 fractions and fraction and double
        }
    }
}
