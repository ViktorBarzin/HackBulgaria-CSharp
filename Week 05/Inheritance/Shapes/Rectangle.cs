namespace Shapes
{
    /// <summary>
    /// Class Rectangle.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">Sets the Width.</param>
        /// <param name="height">Sets the height.</param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
            this.Area = width * height;
            this.Perimeter = 2 * (this.Width + this.Height);
            this.Center = new Point(0.5 * this.Width, 0.5 * this.Height);
        }

        /// <summary>
        /// Gets or sets the Width.
        /// </summary>
        /// <value>Setter in constructor.</value>
        public double Width { get; protected set; }

        /// <summary>
        /// Gets or sets the Height.
        /// </summary>
        /// <value>Setter in constructor.</value>
        public double Height { get; protected set; }
    }
}
