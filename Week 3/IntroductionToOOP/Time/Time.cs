using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Time
    {
        private int year;
        private int month;
        private int day;
        private int hour;
        private int minute;
        private int second;
        //hh:mm:ss dd.MM.YY
        public Time(string time)
        {
        // char [] timeAsCharArr = time.ToCharArray();
            string[] splitedTime = time.Split(':',' ','.');
            hour = int.Parse(splitedTime[0]);
            minute = int.Parse(splitedTime[1]);
            second = int.Parse(splitedTime[2]);
            day = int.Parse(splitedTime[3]);
            month = int.Parse(splitedTime[4]);
            year = int.Parse(splitedTime[5]);
        }
        public override string ToString()
        {
            string res = "";
            Console.WriteLine("{0}:{1}:{2} {3}.{4}.{5}",hour,minute,second,day,month,year);
            return res;
        }
        public void Now()
        {
            Console.WriteLine(DateTime.Now);
        }

    }
}
