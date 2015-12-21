namespace Time
{
    using System;

    public class Time
    {
        private readonly int year;
        private readonly int month;
        private readonly int day;
        private readonly int hour;
        private readonly int minute;
        private readonly int second;

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

        public override string ToString()
        {
            return string.Format("{0}:{1}:{2} {3}.{4}.{5}", this.hour, this.minute, this.second, this.day, this.month, this.year);
        }

        public void Now()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
