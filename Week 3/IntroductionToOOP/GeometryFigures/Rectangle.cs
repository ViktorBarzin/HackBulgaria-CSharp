namespace GeometryFigures
{
    using System;

    public class Rectangle
    {
        private readonly LineSegment ab;
        private readonly LineSegment bc;
        private Point c;

        public Rectangle(Point p1, Point p2)
        {
            this.PointA = new Point(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            this.PointC = new Point(Math.Max(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
            this.PointB = new Point(Math.Max(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            this.PointD = new Point(Math.Min(p1.X, p2.X), Math.Max(p1.Y, p2.Y));

            this.ab = new LineSegment(this.PointA, this.PointB);
            this.bc = new LineSegment(this.PointB, this.c);
        }

        public Point PointA { get; }

        public Point PointB { get; }

        public Point PointC
        {
            get
            {
                return this.c;
            }

            set
            {
                if (value.X != this.PointA.X && value.Y != this.PointA.Y)
                {
                    this.c = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Point");
                }
            }
        }

        public Point PointD { get; }

        public Point DisplayA
        {
            get { return this.PointA; }
        }

        public Point DisplayB
        {
            get { return this.PointB; }
        }

        public Point DisplayC
        {
            get { return this.c; }
        }

        public Point DisplayD
        {
            get { return this.PointD; }
        }

        public double Width
        {
            get { return Math.Max(this.PointA.X, this.PointC.X) - Math.Min(this.PointA.X, this.PointC.X); }
        }

        public double Height
        {
            get { return Math.Max(this.PointA.Y, this.PointC.Y) - Math.Min(this.PointA.Y, this.PointC.Y); }
        }

        public Point Center
        {
            get { return new Point((this.Width / 2) + this.PointA.X, (this.Height / 2) + this.PointA.Y); }
        }
        
        public static bool operator ==(Rectangle rect1, Rectangle rect2)
        {
            return rect2 != null && (rect1 != null && (Math.Abs(rect1.Width - rect2.Width) < 0.001 && Math.Abs(rect1.Height - rect2.Height) < 0.001 && Math.Abs(rect1.GetArea() - rect2.GetArea()) < 0.001 && Math.Abs(rect1.GetPerimeter() - rect2.GetPerimeter()) < 0.001));
        }

        public static bool operator !=(Rectangle rect1, Rectangle rect2)
        {
            return rect2 != null && (rect1 != null && (Math.Abs(rect1.Width - rect2.Width) > 0.001 || !(Math.Abs(rect1.Height - rect2.Height) < 0.001) || !(Math.Abs(rect1.GetArea() - rect2.GetArea()) < 0.001) || !(Math.Abs(rect1.GetPerimeter() - rect2.GetPerimeter()) < 0.001)));
        }

        public double GetPerimeter()
        {
            return 2 * (this.ab.GetLength() + this.bc.GetLength());
        }

        public double GetArea()
        {
            return this.ab.GetLength() * this.bc.GetLength();
        }

        public override string ToString()
        {
            // Rectangle[(x,y), (height,width)]
            return string.Format("Rectangle[(" + this.PointA + "," + this.PointC + "), (" + this.Height + "," + this.Width + ")]");
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

            return this.Equals((Rectangle)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.PointA?.GetHashCode() ?? 0;
                hashCode = (hashCode * 397) ^ (this.PointB?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (this.c?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (this.PointD?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (this.ab?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (this.bc?.GetHashCode() ?? 0);
                return hashCode;
            }
        }

        protected bool Equals(Rectangle other)
        {
            return Equals(this.PointA, other.PointA) && Equals(this.PointB, other.PointB) && Equals(this.c, other.c) && Equals(this.PointD, other.PointD) && Equals(this.ab, other.ab) && Equals(this.bc, other.bc);
        }
    }
}