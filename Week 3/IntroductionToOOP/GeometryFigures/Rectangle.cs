namespace GeometryFigures
{
    using System;

    public class Rectangle
    {
        private readonly LineSegment _ab;
        private readonly LineSegment _bc;
        private Point _c;

        public Rectangle(Point p1, Point p2)
        {
            this.PointA = new Point(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            this.PointC = new Point(Math.Max(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
            this.PointB = new Point(Math.Max(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            this.PointD = new Point(Math.Min(p1.X, p2.X), Math.Max(p1.Y, p2.Y));

            this._ab = new LineSegment(this.PointA, this.PointB);
            this._bc = new LineSegment(this.PointB, this._c);
        }

        public Point PointA { get; }

        public Point PointB { get; }

        public Point PointC
        {
            get
            {
                return this._c;
            }

            set
            {
                if (value.X != this.PointA.X && value.Y != this.PointA.Y)
                {
                    this._c = value;
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
            get { return this._c; }
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
            if (rect1.Width == rect2.Width && rect1.Height == rect2.Height && rect1.GetArea() == rect2.GetArea() && rect1.GetPerimeter() == rect2.GetPerimeter())
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Rectangle rect1, Rectangle rect2)
        {
            if (rect1.Width == rect2.Width && rect1.Height == rect2.Height && rect1.GetArea() == rect2.GetArea() && rect1.GetPerimeter() == rect2.GetPerimeter())
            {
                return false;
            }

            return true;
        }

        public double GetPerimeter()
        {
            return 2 * (this._ab.GetLength() + this._bc.GetLength());
        }

        public double GetArea()
        {
            return this._ab.GetLength() * this._bc.GetLength();
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
                hashCode = (hashCode * 397) ^ (this._c?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (this.PointD?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (this._ab?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (this._bc?.GetHashCode() ?? 0);
                return hashCode;
            }
        }

        protected bool Equals(Rectangle other)
        {
            return Equals(this.PointA, other.PointA) && Equals(this.PointB, other.PointB) && Equals(this._c, other._c) && Equals(this.PointD, other.PointD) && Equals(this._ab, other._ab) && Equals(this._bc, other._bc);
        }
    }
}