using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        protected string Gender;
        protected string DayiyStuff;

        public Person(string gender)
        {
            Gender = gender;
            this.DayiyStuff = "person stuff";
        }

        public override string ToString()
        {
            return string.Format("I am {0} and {1} every day!", Gender, DayiyStuff);
        }
    }
}
