namespace AverageAggregator
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Application class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        public static void Main()
        {
            AverageAggregator temp = new AverageAggregator();

            temp.PropertyChanged += (o, e) => { Console.WriteLine("Average property changed"); };
            temp.AddNumber(5);
            temp.AddNumber(7);
            temp.AddNumber(9);
            Console.WriteLine(temp.Average);
        }
    }
}
