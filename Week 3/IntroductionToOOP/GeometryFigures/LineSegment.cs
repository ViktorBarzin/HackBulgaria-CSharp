namespace GeometryFigures
{
    using System;

    /// <summary>
    /// Class LineSegment
    /// </summary>
    public class LineSegment
    {
        /// <summary>
        /// Length of the LineSegment object.
        /// </summary>
        private double length;

        /// <summary>
        /// Initializes a new instance of the <see cref="LineSegment"/> class.
        /// </summary>
        /// <param name="start">Start points.</param>
        /// <param name="end">End point.</param>
        public LineSegment(Point start, Point end)
        {
            this.Start = start;
            this.End = end;
            this.length = this.GetLength();
        }

        /// <summary>
        /// Gets the LineSegment object's start point.
        /// </summary>
        public Point Start { get; }

        /// <summary>
        /// Gets or sets the LineSegment object's end point.
        /// </summary>
        public Point End
        {
            get
            {
                return this.End;
            }

            set
            {
                if (value == this.Start)
                {
                    throw new ArgumentException("Cannot have a line with 0 lenght");
                }

                this.End = value;
            }
        }

        /// <summary>
        ///  The == operator for two LineSegment objects.
        /// </summary>
        /// <param name="line1">LineSegment object one.</param>
        /// <param name="line2">LineSegment object two.</param>
        /// <returns>Returns true if both objects' length is the same</returns>
        public static bool operator ==(LineSegment line1, LineSegment line2)
        {
            return line1 != null && (line2 != null && Math.Abs(line1.length - line2.length) < 0.001);
        }

        /// <summary>
        /// The != operator for two LineSegment objects.
        /// </summary>
        /// <param name="line1">LineSegment object one.</param>
        /// <param name="line2">LineSegment object two.</param>
        /// <returns>Returns true if both objects' length is not the same</returns>
        public static bool operator !=(LineSegment line1, LineSegment line2)
        {
            return line2 != null && (line1 != null && Math.Abs(line1.length - line2.length) > 0.001);
        }

        /// <summary>
        /// The <![CDATA[<]]> operator for two LineSegment objects.
        /// </summary>
        /// <param name="line1">LineSegment object one.</param>
        /// <param name="line2">LineSegment object two.</param>
        /// <returns>Returns true if the first object's length is smaller than the second object's length.</returns>
        public static bool operator <(LineSegment line1, LineSegment line2)
        {
            return line1.length < line2.length;
        }

        /// <summary>
        /// The <![CDATA[<=]]> operator for two LineSegment objects.
        /// </summary>
        /// <param name="line1">LineSegment object one.</param>
        /// <param name="line2">LineSegment object two.</param>
        /// <returns>Returns true if the first object's length is smaller than or equal the second object's length.</returns>
        public static bool operator <=(LineSegment line1, LineSegment line2)
        {
            return line1.length <= line2.length;
        }

        /// <summary>
        /// The <![CDATA[>]]> operator for two LineSegment objects.
        /// </summary>
        /// <param name="line1">LineSegment object one.</param>
        /// <param name="line2">LineSegment object two.</param>
        /// <returns>Returns true if the first object's length is bigger than the second object's length.</returns>
        public static bool operator >(LineSegment line1, LineSegment line2)
        {
            return line1.length > line2.length;
        }

        /// <summary>
        /// The <![CDATA[>=]]> operator for two LineSegment objects.
        /// </summary>
        /// <param name="line1">LineSegment object one.</param>
        /// <param name="line2">LineSegment object two.</param>
        /// <returns>Returns true if the first object's length is bigger than or equal the second object's length.</returns>
        public static bool operator >=(LineSegment line1, LineSegment line2)
        {
            return line1.length >= line2.length;
        }

        /// <summary>
        /// The operator <![CDATA[<]]> for a LineSegment object and a double.
        /// </summary>
        /// <param name="line1">LineSegment object.</param>
        /// <param name="len">Double to compare with.</param>
        /// <returns>True if LineSegment object's length is bigger than the double.</returns>
        public static bool operator <(LineSegment line1, double len)
        {
            return line1.length < len;
        }

        /// <summary>
        /// The operator <![CDATA[<=]]> for a LineSegment object and a double.
        /// </summary>
        /// <param name="line1">LineSegment object.</param>
        /// <param name="len">Double to compare with.</param>
        /// <returns>True if LineSegment object's length is smaller than or equal the double.</returns>
        public static bool operator <=(LineSegment line1, double len)
        {
            return line1.length <= len;
        }

        /// <summary>
        /// The operator <![CDATA[>]]> for a LineSegment object and a double.
        /// </summary>
        /// <param name="line1">LineSegment object.</param>
        /// <param name="len">Double to compare with.</param>
        /// <returns>True if LineSegment object's length is smaller than the double.</returns>
        public static bool operator >(LineSegment line1, double len)
        {
            return line1.length > len;
        }

        /// <summary>
        /// The operator <![CDATA[>=]]> for a LineSegment object and a double.
        /// </summary>
        /// <param name="line1">LineSegment object.</param>
        /// <param name="len">Double to compare with.</param>
        /// <returns>True if LineSegment object's length is bigger than or equal the double.</returns>
        public static bool operator >=(LineSegment line1, double len)
        {
            return line1.length >= len;
        }

        /// <summary>
        /// Gets the distance between the start point and end point for a LineSegment object.
        /// </summary>
        /// <returns>Distance between start point and end point for a LineSegment object.</returns>
        public double GetLength()
        {
            this.length = Math.Pow(Math.Max(this.Start.X, this.End.X) - Math.Min(this.Start.X, this.End.X), 2)
                + Math.Pow(Math.Max(this.Start.Y, this.End.Y) - Math.Min(this.Start.Y, this.End.Y), 2);
            return Math.Sqrt(this.length);
        }

        /// <summary>
        /// Overrides ToString() method for LineSegment object.
        /// </summary>
        /// <returns>LineSegment object as String.</returns>
        public override string ToString()
        {
            return string.Format("Line[(" + this.Start.X + ", " + this.Start.Y + "), (" + this.End.X + ", " + this.End.Y + ")]");
        }

        /// <summary>
        /// Overrides Equals() method for LineSegment object.
        /// </summary>
        /// <param name="obj">Object to compare a LineSegment with.</param>
        /// <returns>True if both objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return this.Equals((LineSegment)obj);
        }

        /// <summary>
        /// Overrides GetHashCode() for LineSegment object.
        /// </summary>
        /// <returns>Hash code for a LineSegment object.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.End.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Start.GetHashCode();
                return hashCode;
            }
        }
    }
}
