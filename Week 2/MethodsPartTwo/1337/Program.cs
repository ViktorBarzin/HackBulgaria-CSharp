using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1337
{
    class Program
    {
        public static void HackerTime()
        {
            DateTime now = DateTime.Now;
            DateTime hackerTime = new DateTime(now.Year, 12, 21, 13, 37, 0);
            if (now < hackerTime)
            {
                TimeSpan span = hackerTime - now;
                Console.WriteLine("{0} days, {1} hours, {2} minutes", span.Days, span.Hours, span.Minutes);
            }
            else
            {
                hackerTime = hackerTime.AddYears(1);
                TimeSpan span = hackerTime - now;
                Console.WriteLine("{0} days, {1} hours, {2} minutes", span.Days, span.Hours, span.Minutes);
            }
        }
        static void Main(string[] args)
        {
            HackerTime();
        }
    }
}
