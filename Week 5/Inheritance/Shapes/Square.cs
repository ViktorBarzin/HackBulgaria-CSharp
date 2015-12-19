namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
            this.Height = this.Side;
            this.Width = this.Side;
            this.Side = side;
        }

        protected double Side { get; set; }
    }
}
