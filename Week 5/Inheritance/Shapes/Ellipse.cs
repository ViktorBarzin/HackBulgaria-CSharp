﻿namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Ellipse : Shape
    {
        public Ellipse(double axesX, double axesY)
        {
            this.SemiAxesX = axesX;
            this.SemiAxesY = axesY;
            this.Center = new Point(SemiAxesX, SemiAxesY);
            this.Area = (Math.PI * SemiAxesX * SemiAxesY);
            this.Perimeter = Math.PI * (3 * (SemiAxesX + SemiAxesY) - Math.Sqrt((3 * SemiAxesX + SemiAxesY) * (SemiAxesX + 3 * SemiAxesY)));
        }

        protected double SemiAxesX { get; set; }

        protected double SemiAxesY { get; set; }

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
