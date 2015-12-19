using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Ellipse
    {
        protected double Radius { get; set; }
        public Circle(double axes) : base(axes, axes)
        {
            this.Radius = axes;
            if (this.SemiAxesY > this.SemiAxesX)
            {
                this.SemiAxesX = this.SemiAxesY;
            }
            else
            {
                this.SemiAxesY = this.SemiAxesX;
            }
            this.Area = Math.PI * Math.Pow(Radius, 2);
            this.Perimeter = 2 * Math.PI * this.Radius;
            this.Center = new Point(Radius, Radius);
        }

        public override double GetArea()
        {
            return this.Area;
        }

        public override double GetPerimeter()
        {
            return this.Perimeter;
        }
    }
}
