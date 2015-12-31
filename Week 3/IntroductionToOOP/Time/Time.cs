namespace Time
{
    using System;

    /// <summary>
    /// Class Time.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Integer year field.
        /// </summary>
        private readonly int year;

        /// <summary>
        /// Integer month field.
        /// </summary>
        private readonly int month;

        /// <summary>
        /// Integer day field.
        /// </summary>
        private readonly int day;

        /// <summary>
        /// Integer hour field.
        /// </summary>
        private readonly int hour;

        /// <summary>
        /// Integer minute field.
        /// </summary>
        private readonly int minute;

        /// <summary>
        /// Integer second field.
        /// </summary>
        private readonly int second;

        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        /// <param name="time">String input which is split to set time.</param>
        public Time(string time)
        {
            string[] splitedTime = time.Split(':', ' ', '.');
            this.hour = int.Parse(splitedTime[0]);
            this.minute = int.Parse(splitedTime[1]);
            this.second = int.Parse(splitedTime[2]);
            this.day = int.Parse(splitedTime[3]);
            this.month = int.Parse(splitedTime[4]);
            this.year = int.Parse(splitedTime[5]);
        }

        /// <summary>
        /// Overrides ToString() method for Time class.
        /// </summary>
        /// <returns>Current instance of Time class as String.</returns>
        public override string ToString()
        {
            return string.Format("{0}:{1}:{2} {3}.{4}.{5}", this.hour, this.minute, this.second, this.day, this.month, this.year);
        }

        /// <summary>
        /// Prints the current Time.
        /// </summary>
        public void Now()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
