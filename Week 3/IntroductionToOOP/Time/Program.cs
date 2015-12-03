using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //hh: mm: ss dd.MM.YY
            Console.WriteLine("Enter the date in the following format \" hh:mm:ss dd.MM.YY\"");
            string dateTime = Console.ReadLine();
            Time timeobj = new Time(dateTime);
            timeobj.ToString();
            timeobj.Now();
        }
    }
}
