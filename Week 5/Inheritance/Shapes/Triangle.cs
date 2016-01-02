namespace Shapes
{
    using System;

    /// <summary>
    /// Class Triangle.
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="vertex1">Point one.</param>
        /// <param name="vertex2">Point two.</param>
        /// <param name="vertex3">Point three.</param>
        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.Vertex1 = vertex1;
            this.Vertex2 = vertex2;
            this.Vertex3 = vertex3;
            this.Perimeter = this.GetPerimeter();
            this.Area = this.GetArea();
            this.Center = new Point(0, 0);
        }

        /// <summary>
        /// Gets or sets Vertex one.
        /// </summary>
        /// <value>Protected setter.</value>
        public Point Vertex1 { get; protected set; }

        /// <summary>
        /// Gets or sets Vertex two.
        /// </summary>
        /// <value>Protected setter.</value>
        public Point Vertex2 { get; protected set; }

        /// <summary>
        /// Gets or sets Vertex three.
        /// </summary>
        /// <value>Protected setter.</value>
        public Point Vertex3 { get; protected set; }

        /// <summary>
        /// Overrides GetArea() method.
        /// </summary>
        /// <returns>Area of Triangle.</returns>
        public override double GetArea()
        {
            // Works with positive numbers only, i hate geometry anyway
            return ((this.Vertex1.X * (Math.Max(this.Vertex2.Y, this.Vertex3.Y) - Math.Min(this.Vertex2.Y, this.Vertex3.Y)))
                + (this.Vertex2.X * (Math.Max(this.Vertex1.Y, this.Vertex3.Y) - Math.Min(this.Vertex1.Y, this.Vertex3.Y)))
                + (this.Vertex3.X * (Math.Max(this.Vertex1.Y, this.Vertex2.Y) - Math.Min(this.Vertex1.Y, this.Vertex2.Y)))) / 2;
        }

        /// <summary>
        /// Overrides GetPerimeter().
        /// </summary>
        /// <returns>Triangle Perimeter.</returns>
        public override double GetPerimeter()
        {
            double c = Math.Sqrt(Math.Pow(Math.Max(this.Vertex1.X, this.Vertex2.X) - Math.Min(this.Vertex1.X, this.Vertex2.X), 2) + Math.Pow(Math.Max(this.Vertex1.Y, this.Vertex2.Y) - Math.Max(this.Vertex1.Y, this.Vertex2.Y), 2));
            double b = Math.Sqrt(Math.Pow(Math.Max(this.Vertex1.X, this.Vertex3.X) - Math.Min(this.Vertex1.X, this.Vertex3.X), 2) + Math.Pow(Math.Max(this.Vertex1.Y, this.Vertex3.Y) - Math.Max(this.Vertex1.Y, this.Vertex3.Y), 2));
            double a = Math.Sqrt(Math.Pow(Math.Max(this.Vertex3.X, this.Vertex2.X) - Math.Min(this.Vertex3.X, this.Vertex2.X), 2) + Math.Pow(Math.Max(this.Vertex3.Y, this.Vertex2.Y) - Math.Max(this.Vertex3.Y, this.Vertex2.Y), 2));
            return a + b + c;
        }
    }
}
