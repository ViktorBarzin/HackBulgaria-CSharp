namespace GeometryFigures
{
    using System;

    /// <summary>
    /// Class Point
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class with no given parameters..
        /// </summary>
        public Point()
        {
            this.X = 0;
            this.Y = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class with given parameters..
        /// </summary>
        /// <param name="xCoor">Sets x coordinate for the point</param>
        /// <param name="yCoor">Sets y coordinate for the point</param>
        /// <param name="xOrig">Sets x coordinate for the origin</param>
        /// <param name="yOrig">Sets y coordinate for the origin</param>
        public Point(double xCoor, double yCoor, double xOrig = 0, double yOrig = 0)
        {
            this.X = xCoor;
            this.Y = yCoor;
            this.XOrigin = xOrig;
            this.YOrigin = yOrig;
        }

        /// <summary>
        /// Gets or sets the XOrigin.
        /// </summary>
        public double XOrigin { get; set; }

        /// <summary>
        /// Gets or sets the YOrigin.
        /// </summary>
        public double YOrigin { get; set; }

        /// <summary>
        /// Gets X.
        /// </summary>
        public double X { get; }

        /// <summary>
        /// Gets Y.
        /// </summary>
        public double Y { get; }

        /// <summary>
        /// Operator == for two Point objects.
        /// </summary>
        /// <param name="point1">Point object one.</param>
        /// <param name="point2">Point object two.</param>
        /// <returns>True if both Point objects are equal.</returns>
        public static bool operator ==(Point point1, Point point2)
        {
            return point2 != null && (point1 != null && (Math.Abs(point1.X - point2.X) < 0.001 && Math.Abs(point1.Y - point2.Y) < 0.001));
        }

        /// <summary>
        /// Operator != for two Point objects.
        /// </summary>
        /// <param name="point1">Point object one.</param>
        /// <param name="point2">Point object two.</param>
        /// <returns>True if both Point objects are not equal.</returns>
        public static bool operator !=(Point point1, Point point2)
        {
            return point2 != null && (point1 != null && Math.Abs(point1.X - point2.X) < 0.001 ^ Math.Abs(point1.Y - point2.Y) < 0.001);
        }

        /// <summary>
        /// Operator + for two Point objects.
        /// </summary>
        /// <param name="point1">Point object one.</param>
        /// <param name="point2">Point object two.</param>
        /// <returns>An instance of a LineSegment class.</returns>
        public static LineSegment operator +(Point point1, Point point2)
        {
            LineSegment newLine = new LineSegment(point1, point2);
            return newLine;
        }

        /// <summary>
        /// Displays Point class object.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("{0}:{1}", this.X, this.Y);
        }

        /// <summary>
        /// Overrides the GetHashCode() method for a Point object.
        /// </summary>
        /// <returns>Hash code for a Point object.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 23) + this.X.GetHashCode();
                hash = (hash * 23) + this.Y.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// Overrides ToString() method for Point object.
        /// </summary>
        /// <returns>Point object as String.</returns>
        public override string ToString()
        {
            return string.Format(this.X + ":" + this.Y);
        }

        /// <summary>
        /// Overrides Equals() method for Point object.
        /// </summary>
        /// <param name="point">Object to compare with.</param>
        /// <returns>True if the Point and the object are equal.</returns>
        public override bool Equals(object point)
        {
            if (this.X == (point as Point).X && this.Y == (point as Point).Y)
            {
                return true;
            }

            return false;
        }
    }
}
