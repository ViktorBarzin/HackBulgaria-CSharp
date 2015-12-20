namespace Time
{
    using System;

    public class Time
    {
        private readonly int _year;
        private readonly int _month;
        private readonly int _day;
        private readonly int _hour;
        private readonly int _minute;
        private readonly int _second;

        public Time(string time)
        {
            string[] splitedTime = time.Split(':', ' ', '.');
            this._hour = int.Parse(splitedTime[0]);
            this._minute = int.Parse(splitedTime[1]);
            this._second = int.Parse(splitedTime[2]);
            this._day = int.Parse(splitedTime[3]);
            this._month = int.Parse(splitedTime[4]);
            this._year = int.Parse(splitedTime[5]);
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}:{2} {3}.{4}.{5}", this._hour, this._minute, this._second, this._day, this._month, this._year);
        }

        public void Now()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
