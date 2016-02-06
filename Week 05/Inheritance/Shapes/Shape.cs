namespace Shapes
{
    /// <summary>
    /// Abstract Class Shape.
    /// </summary>
    public abstract class Shape : IMoveable
    {
        /// <summary>
        /// Gets or sets the Center.
        /// </summary>
        /// <value>Protected setter.</value>
        public Point Center { get; protected set; }

        /// <summary>
        /// Gets or sets the Perimeter.
        /// </summary>
        /// <value>Protected setter.</value>
        public double Perimeter { get; protected set; }

        /// <summary>
        /// Gets or sets the Area property.
        /// </summary>
        /// <value>Protected setter.</value>
        public double Area { get; protected set; }

        /// <summary>
        /// Virtual method GetPerimeter().
        /// </summary>
        /// <returns>The perimeter of the Shape.</returns>
        public virtual double GetPerimeter()
        {
            return this.Perimeter;
        }

        /// <summary>
        /// Virtual method GetArea().
        /// </summary>
        /// <returns>The Area of the Shape.</returns>
        public virtual double GetArea()
        {
            return this.Area;
        }

        /// <summary>
        /// Overrides ToString() method for Shape class.
        /// </summary>
        /// <returns>Shape as a String.</returns>
        public override string ToString()
        {
            return string.Format("{0} with perimeter : {1} and area: {2}", this.GetType(), this.Perimeter, this.Area);
        }

        /// <summary>
        /// Move Method.
        /// </summary>
        /// <param name="x">Move by X coordinate.</param>
        /// <param name="y">Move by Y coordinate.</param>
        public void Move(double x, double y)
        {
            this.Center.X += x;
            this.Center.Y += y;
        }
    }
}
