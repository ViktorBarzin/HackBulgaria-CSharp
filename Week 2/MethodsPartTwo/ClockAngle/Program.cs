using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngle
{
    class Program
    {
        public static int GetClockHandsAngle(DateTime time)
        {
            var angle = time.Hour * 30 - time.Minute * 6;
            if (angle < 180)
            {
                return angle;
            }
            else
            {
                return 360 - angle;
            }
        }

        public static double GetClockHandsAngleAccurate(DateTime time)
        {
            var hourAngle = time.Hour * 30 + time.Minute * 0.5;
            var minuteAngle = time.Minute * 6;
            var angle = hourAngle - minuteAngle;
            if (angle < 180)
            {
                return Math.Abs(angle);
            }
            else
            {
                return Math.Abs(360 - angle);
            }
        }
        static void Main(string[] args)
        {
            DateTime time = new DateTime(2000, 1, 1, 12, 30, 00);
            Console.WriteLine(GetClockHandsAngleAccurate(time));
            //Console.WriteLine(GetClockHandsAngle(time));
        }
    }
}
