namespace Shapes
{
    using System;

    public class Ellipse : Shape
    {
        public Ellipse(double axesX, double axesY)
        {
            this.SemiAxesX = axesX;
            this.SemiAxesY = axesY;
            this.Center = new Point(this.SemiAxesX, this.SemiAxesY);
            this.Area = Math.PI * this.SemiAxesX * this.SemiAxesY;
            this.Perimeter = Math.PI * ((3 * (this.SemiAxesX + this.SemiAxesY)) - Math.Sqrt(((3 * this.SemiAxesX) + this.SemiAxesY) * (this.SemiAxesX + (3 * this.SemiAxesY))));
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
