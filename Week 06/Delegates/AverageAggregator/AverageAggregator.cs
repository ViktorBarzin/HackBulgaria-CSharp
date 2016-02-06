namespace AverageAggregator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Average aggregator.
    /// </summary>
    public class AverageAggregator : INotifyPropertyChanged
    {
       /// <summary>
        /// Number count.
        /// </summary>
        private readonly List<int> numbers = new List<int>();

        /// <summary>
        /// Current average.
        /// </summary>
        private double average;

        /// <summary>
        /// Property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the average for the current instance.
        /// </summary>
        public double Average
        {
            get
            {
                return this.average;
            }

            private set
            {
                if (this.average != value && this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Average"));
                }

                this.average = value;
            }
        }

        /// <summary>
        /// Adds new number to the current instance.
        /// </summary>
        /// <param name="number">Number to add.</param>
        public void AddNumber(int number)
        {
            this.numbers.Add(number);
            this.Average = this.numbers.Average();
        }
    }
}
