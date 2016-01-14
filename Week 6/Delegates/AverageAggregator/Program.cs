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
            temp.PropertyChanged += TempPropertyChanged;
            temp.AddNumber(5);
            temp.AddNumber(7);
            temp.AddNumber(9);
            Console.WriteLine(temp.Average);
        }

        /// <summary>
        /// Invoked method when average property changes.
        /// </summary>
        /// <param name="sender">Sender to the object.</param>
        /// <param name="e">Property changed arguments.</param>
        private static void TempPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("Average property changed");
        }
    }
}
