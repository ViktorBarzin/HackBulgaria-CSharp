using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Toy
    {
        protected Color Color;
        protected int Size;

        public Toy(Color color, int size)
        {
            this.Color = color;
            this.Size = size;
        }

        public Toy()
        {
        }

        public override string ToString()
        {
            return string.Format("{0} color, {1} big", this.Color, this.Size);
        }
    }
}
