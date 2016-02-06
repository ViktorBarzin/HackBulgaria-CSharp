namespace Shapes
{
    /// <summary>
    /// Class Point.
    /// </summary>
    public class Point : IMoveable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="y">Y coordinate.</param>
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or sets the X coordinate.
        /// </summary>
        /// <value>Private setter.</value>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the Y coordinate.
        /// </summary>
        /// <value>Private setter.</value>
        public double Y { get; set; }

        /// <summary>
        /// Move method.
        /// </summary>
        /// <param name="x">Move by X.</param>
        /// <param name="y">Move by Y.</param>
        public void Move(double x, double y)
        {
            this.X += x;
            this.Y += y;
        }
    }
}
