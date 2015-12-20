namespace Time
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // hh: mm: ss dd.MM.YY
            Console.WriteLine("Enter the date in the following format \" hh:mm:ss dd.MM.YY\"");
            string dateTime = Console.ReadLine();
            Time timeobj = new Time(dateTime);
            timeobj.ToString();
            timeobj.Now();
        }
    }
}
