namespace Shapes
{
    /// <summary>
    /// Class Square.
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        /// <param name="side">Sets side.</param>
        public Square(double side) : base(side, side)
        {
            this.Height = this.Side;
            this.Width = this.Side;
            this.Side = side;
        }

        /// <summary>
        /// Gets the Side property.
        /// </summary>
        /// <value>No setter.</value>
        protected double Side { get; }
    }
}
