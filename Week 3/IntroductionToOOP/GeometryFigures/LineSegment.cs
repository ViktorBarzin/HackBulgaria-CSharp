namespace GeometryFigures
{
    using System;

    public class LineSegment
    {
        private Point end;
        private double length;

        public LineSegment(Point start, Point end)
        {
            this.Start = start;
            this.End = end;
            this.length = this.GetLength();
        }

        public Point Start { get; }

        public Point End
        {
            get
            {
                return this.end;
            }

            set
            {
                if (value == this.Start)
                {
                    throw new ArgumentException("Cannot have a line with 0 lenght");
                }

                this.end = value;
            }
        }

        public static bool operator ==(LineSegment line1, LineSegment line2)
        {
            return line1 != null && (line2 != null && Math.Abs(line1.length - line2.length) < 0.001);
        }

        public static bool operator !=(LineSegment line1, LineSegment line2)
        {
            return line2 != null && (line1 != null && Math.Abs(line1.length - line2.length) > 0.001);
        }

        public static bool operator <(LineSegment line1, LineSegment line2)
        {
            return line1.length < line2.length;
        }

        public static bool operator <=(LineSegment line1, LineSegment line2)
        {
            return line1.length <= line2.length;
        }

        public static bool operator >(LineSegment line1, LineSegment line2)
        {
            return line1.length > line2.length;
        }

        public static bool operator >=(LineSegment line1, LineSegment line2)
        {
            return line1.length >= line2.length;
        }

        public static bool operator <(LineSegment line1, double len)
        {
            return line1.length < len;
        }

        public static bool operator <=(LineSegment line1, double len)
        {
            return line1.length <= len;
        }

        public static bool operator >(LineSegment line1, double len)
        {
            return line1.length > len;
        }

        public static bool operator >=(LineSegment line1, double len)
        {
            return line1.length >= len;
        }

        public double GetLength()
        {
            this.length = Math.Pow(Math.Max(this.Start.X, this.end.X) - Math.Min(this.Start.X, this.end.X), 2)
                + Math.Pow(Math.Max(this.Start.Y, this.end.Y) - Math.Min(this.Start.Y, this.end.Y), 2);
            return Math.Sqrt(this.length);
        }

        public override string ToString()
        {
            return string.Format("Line[(" + this.Start.X + ", " + this.Start.Y + "), (" + this.end.X + ", " + this.end.Y + ")]");
        }

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

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.end != null ? this.end.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ this.length.GetHashCode();
                hashCode = (hashCode * 397) ^ (this.Start?.GetHashCode() ?? 0);
                return hashCode;
            }
        }
    }
}
