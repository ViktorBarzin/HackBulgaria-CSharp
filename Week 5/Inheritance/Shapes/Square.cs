using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Rectangle
    {
        protected double Side { get; set; }

        public Square(double side) : base(side, side)
        {
            this.Height = this.Side;
            this.Width = this.Side;
            this.Side = side;
        }
    }
}
