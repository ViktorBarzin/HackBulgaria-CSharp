namespace ClockAngle
{
    using System;

    public class Program
    {
        public static int GetClockHandsAngle(DateTime time)
        {
            var angle = (time.Hour * 30) - (time.Minute * 6);
            if (angle < 180)
            {
                return angle;
            }

            return 360 - angle;
        }

        public static double GetClockHandsAngleAccurate(DateTime time)
        {
            var hourAngle = (time.Hour * 30) + (time.Minute * 0.5);
            var minuteAngle = time.Minute * 6;
            var angle = hourAngle - minuteAngle;
            return angle < 180 ? Math.Abs(angle) : Math.Abs(360 - angle);
        }

        public static void Main(string[] args)
        {
            DateTime time = new DateTime(2000, 1, 1, 12, 30, 00);
            Console.WriteLine(GetClockHandsAngleAccurate(time));

            // Console.WriteLine(GetClockHandsAngle(time));
        }
    }
}