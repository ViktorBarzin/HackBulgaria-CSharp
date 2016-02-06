namespace Shapes
{
    using System;

    /// <summary>
    /// Class Ellipse.
    /// </summary>
    public class Ellipse : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse"/> class.
        /// </summary>
        /// <param name="axesX">X axes for the ellipse.</param>
        /// <param name="axesY">Y axes for the ellipse.</param>
        public Ellipse(double axesX, double axesY)
        {
            this.SemiAxesX = axesX;
            this.SemiAxesY = axesY;
            this.Center = new Point(this.SemiAxesX, this.SemiAxesY);
            this.Area = Math.PI * this.SemiAxesX * this.SemiAxesY;
            this.Perimeter = Math.PI * ((3 * (this.SemiAxesX + this.SemiAxesY)) - Math.Sqrt(((3 * this.SemiAxesX) + this.SemiAxesY) * (this.SemiAxesX + (3 * this.SemiAxesY))));
        }

        /// <summary>
        /// Gets or sets the Semi axes X.
        /// </summary>
        /// <value>Setter in constructor.</value>
        public double SemiAxesX { get; protected set; }

        /// <summary>
        /// Gets or sets the Semi axes Y.
        /// </summary>
        /// <value>Setter in constructor.</value>
        public double SemiAxesY { get; protected set; }

        /// <summary>
        /// Overrides GetArea() method.
        /// </summary>
        /// <returns>Ellipse area.</returns>
        public override double GetArea()
        {
            return this.Area;
        }

        /// <summary>
        /// Overrides GetPerimeter() method.
        /// </summary>
        /// <returns>Ellipse perimeter.</returns>
        public override double GetPerimeter()
        {
            return this.Perimeter;
        }
    }
}
