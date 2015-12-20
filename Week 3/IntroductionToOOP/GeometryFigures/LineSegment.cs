namespace GeometryFigures
{
    using System;

    public class LineSegment
    {
        private Point _end;
        private double _length;

        public LineSegment(Point start, Point end)
        {
            this.Start = start;
            this.End = end;
            this._length = this.GetLength();
        }

        public Point Start { get; }

        public Point End
        {
            get
            {
                return this._end;
            }

            set
            {
                if (value == this.Start)
                {
                    throw new ArgumentException("Cannot have a line with 0 lenght");
                }

                this._end = value;
            }
        }

        public static bool operator ==(LineSegment line1, LineSegment line2)
        {
            return line1._length == line2._length;
        }

        public static bool operator !=(LineSegment line1, LineSegment line2)
        {
            return line1._length != line2._length;
        }

        public static bool operator <(LineSegment line1, LineSegment line2)
        {
            return line1._length < line2._length;
        }

        public static bool operator <=(LineSegment line1, LineSegment line2)
        {
            return line1._length <= line2._length;
        }

        public static bool operator >(LineSegment line1, LineSegment line2)
        {
            return line1._length > line2._length;
        }

        public static bool operator >=(LineSegment line1, LineSegment line2)
        {
            return line1._length >= line2._length;
        }

        public static bool operator <(LineSegment line1, double len)
        {
            return line1._length < len;
        }

        public static bool operator <=(LineSegment line1, double len)
        {
            return line1._length <= len;
        }

        public static bool operator >(LineSegment line1, double len)
        {
            return line1._length > len;
        }

        public static bool operator >=(LineSegment line1, double len)
        {
            return line1._length >= len;
        }

        public double GetLength()
        {
            this._length = Math.Pow(Math.Max(this.Start.X, this._end.X) - Math.Min(this.Start.X, this._end.X), 2)
                + Math.Pow(Math.Max(this.Start.Y, this._end.Y) - Math.Min(this.Start.Y, this._end.Y), 2);
            return Math.Sqrt(this._length);
        }

        public override string ToString()
        {
            return string.Format("Line[(" + this.Start.X + ", " + this.Start.Y + "), (" + this._end.X + ", " + this._end.Y + ")]");
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
                var hashCode = this._end != null ? this._end.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ this._length.GetHashCode();
                hashCode = (hashCode * 397) ^ (this.Start?.GetHashCode() ?? 0);
                return hashCode;
            }
        }
    }
}
