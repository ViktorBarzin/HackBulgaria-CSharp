namespace DungeonsAndLizards
{
    using System;

    /// <summary>
    /// Abstract class Stats.
    /// </summary>
    public abstract class Stats
    {
        /// <summary>
        /// Value of the stat.
        /// </summary>
        private int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Stats"/> class.
        /// </summary>
        /// <param name="value">Sets the value.</param>
        protected Stats(int value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets or sets the value of the stat.
        /// </summary>
        /// <value>Must be positive.</value>
        public int Value
        {
            get
            {
                return this.value;
            }

            set
            {
                if (value > 0 && value < int.MaxValue)
                {
                    this.value = value;
                }
                else
                {
                    Console.WriteLine("ERROR: Health value is invalid!");
                }
            }
        }
    }
}
