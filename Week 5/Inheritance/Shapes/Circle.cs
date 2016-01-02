namespace Shapes
{
    using System;

    /// <summary>
    /// Class Circle.
    /// </summary>
    public class Circle : Ellipse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="axes">Sets the axes of the Circle.</param>
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

            this.Area = Math.PI * Math.Pow(this.Radius, 2);
            this.Perimeter = 2 * Math.PI * this.Radius;
            this.Center = new Point(this.Radius, this.Radius);
        }

        /// <summary>
        /// Gets or sets the Radius.
        /// </summary>
        /// <value>Protected setter.</value>
        public double Radius { get; protected set; }

        /// <summary>
        /// Overrides GetArea() method.
        /// </summary>
        /// <returns>Area of the Circle.</returns>
        public override double GetArea()
        {
            return this.Area;
        }

        /// <summary>
        /// Overrides GetPerimeter() method.
        /// </summary>
        /// <returns>Perimeter of Circle.</returns>
        public override double GetPerimeter()
        {
            return this.Perimeter;
        }
    }
}
