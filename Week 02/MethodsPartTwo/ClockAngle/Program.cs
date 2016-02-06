namespace ClockAngle
{
    using System;

    /// <summary>
    /// Write a method which calculates the angle (degree) between clock hour and minute hands.
    /// <![CDATA[int]]> GetClockHandsAngle(DateTime time)
    /// 1) Calculate the angle if you consider that the hour hand points to exact hour(when the time is 4:34 then the hour hand points exactly to 4 o'clock)
    /// 2) Calculate the angle if the hour hand points doesn't point exactly to the number (when the time is 4:30 then the hour hand points to the middle between 4 and 5 o'clock)
    /// Example : the angle is 90 degrees at 3:00, 15:00, 9:00 and 21:00.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Class documentation task 1).
        /// </summary>
        /// <param name="time">Time to check.</param>
        /// <returns>Angle of the clock hands.</returns>
        public static int GetClockHandsAngle(DateTime time)
        {
            var angle = (time.Hour * 30) - (time.Minute * 6);
            if (angle < 180)
            {
                return angle;
            }

            return 360 - angle;
        }

        /// <summary>
        /// Class documentation task 2).
        /// </summary>
        /// <param name="time">Time to check.</param>
        /// <returns>Angle of the clock hands.</returns>
        public static double GetClockHandsAngleAccurate(DateTime time)
        {
            var hourAngle = (time.Hour * 30) + (time.Minute * 0.5);
            var minuteAngle = time.Minute * 6;
            var angle = hourAngle - minuteAngle;
            return angle < 180 ? Math.Abs(angle) : Math.Abs(360 - angle);
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            DateTime time = new DateTime(2000, 1, 1, 12, 30, 00);
            Console.WriteLine(GetClockHandsAngleAccurate(time));
        }
    }
}