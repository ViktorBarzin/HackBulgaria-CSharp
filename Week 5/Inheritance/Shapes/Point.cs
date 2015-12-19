using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Point : IMoveable
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(double x, double y)
        {
            this.X += x;
            this.Y += y;
        }

    }
}
