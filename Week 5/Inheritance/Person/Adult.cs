using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Adult : Person
    {
        private Child _child;
        public Adult(string gender) : base(gender)
        {
            this.DayiyStuff = "go to work";
        }
        public Adult(string gender,Child child) : base(gender)
        {
            this._child = child;
            this.DayiyStuff = "go to work";
        }
    }
}
