namespace Time
{
    using System;

    /// <summary>
    /// Main Method Class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            // hh: mm: ss dd.MM.YY
            Console.WriteLine("Enter the date in the following format \" hh:mm:ss dd.MM.YY\"");
            string dateTime = Console.ReadLine();
            Time timeobj = new Time(dateTime);
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            timeobj.ToString();
            timeobj.Now();
        }
    }
}
