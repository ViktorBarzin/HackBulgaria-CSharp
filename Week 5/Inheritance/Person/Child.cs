using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Child : Person
    {
        protected Toy Toy = new Toy();
        public Child(string gender) : base(gender)
        {
            this.DayiyStuff = "play";
        }
        public Child(string gender,Toy toy) : base(gender)
        {
            this.DayiyStuff = "play";
            this.Toy = toy;
        }
    }
}
