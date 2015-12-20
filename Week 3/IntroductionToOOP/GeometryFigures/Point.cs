namespace GeometryFigures
{
    using System;

    public class Point
    {
        public Point()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Point(double xCoor, double yCoor, double xOrig = 0, double yOrig = 0)
        {
            this.X = xCoor;
            this.Y = yCoor;
            this.XOrigin = xOrig;
            this.YOrigin = yOrig;
        }

        public double XOrigin { get; set; }

        public double YOrigin { get; set; }

        public double X { get; }

        public double Y { get; }

        public static bool operator ==(Point point1, Point point2)
        {
            return point1.X == point2.X && point1.Y == point2.Y;
        }

        public static bool operator !=(Point point1, Point point2)
        {
            return point1.X == point2.X ^ point1.Y == point2.Y;
        }

        public static LineSegment operator +(Point p1, Point p2)
        {
            LineSegment newLine = new LineSegment(p1, p2);
            return newLine;
        }

        public void Display()
        {
            Console.WriteLine("{0}:{1}", this.X, this.Y);
        }

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

        public override string ToString()
        {
            return string.Format(this.X + ":" + this.Y);
        }

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
