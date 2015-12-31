namespace GeometryFigures
{
    using System;

    /// <summary>
    /// Class Rectangle.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// LineSegment <![CDATA[ab]]> of Rectangle object.
        /// </summary>
        private readonly LineSegment ab;

        /// <summary>
        /// LineSegment <![CDATA[bc]]> of Rectangle object.
        /// </summary>
        private readonly LineSegment bc;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="p1">Point one.</param>
        /// <param name="p2">Point two.</param>
        public Rectangle(Point p1, Point p2)
        {
            this.PointA = new Point(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            this.PointC = new Point(Math.Max(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
            this.PointB = new Point(Math.Max(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            this.PointD = new Point(Math.Min(p1.X, p2.X), Math.Max(p1.Y, p2.Y));

            this.ab = new LineSegment(this.PointA, this.PointB);
            this.bc = new LineSegment(this.PointB, this.PointC);
        }
        
        /// <summary>
        /// Gets Rectangle's point A
        /// </summary>
        public Point PointA { get; }

        /// <summary>
        /// Gets Rectangle's point B
        /// </summary>
        public Point PointB { get; }

        /// <summary>
        /// Gets or sets Rectangle's point A
        /// </summary>
        public Point PointC
        {
            get
            {
                return this.PointC;
            }

            set
            {
                if (value.X != this.PointA.X && value.Y != this.PointA.Y)
                {
                    this.PointC = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Point");
                }
            }
        }

        /// <summary>
        /// Gets Rectangle's point D
        /// </summary>
        public Point PointD { get; }

        /// <summary>
        /// Gets Rectangle object's width.
        /// </summary>
        public double Width
        {
            get { return Math.Max(this.PointA.X, this.PointC.X) - Math.Min(this.PointA.X, this.PointC.X); }
        }

        /// <summary>
        /// Gets Rectangle object's height.
        /// </summary>
        public double Height
        {
            get { return Math.Max(this.PointA.Y, this.PointC.Y) - Math.Min(this.PointA.Y, this.PointC.Y); }
        }

        /// <summary>
        /// Gets Rectangle object's center Point.
        /// </summary>
        public Point Center
        {
            get { return new Point((this.Width / 2) + this.PointA.X, (this.Height / 2) + this.PointA.Y); }
        }
        
        /// <summary>
        /// Operator == for two objects of type Rectangle.
        /// </summary>
        /// <param name="rect1">Rectangle object one.</param>
        /// <param name="rect2">Rectangle object two.</param>
        /// <returns>True if both Rectangle objects are equal.</returns>
        public static bool operator ==(Rectangle rect1, Rectangle rect2)
        {
            return rect2 != null && (rect1 != null && (Math.Abs(rect1.Width - rect2.Width) < 0.001 && Math.Abs(rect1.Height - rect2.Height) < 0.001 && Math.Abs(rect1.GetArea() - rect2.GetArea()) < 0.001 && Math.Abs(rect1.GetPerimeter() - rect2.GetPerimeter()) < 0.001));
        }

        /// <summary>
        /// Operator != for two objects of type Rectangle.
        /// </summary>
        /// <param name="rect1">Rectangle object one.</param>
        /// <param name="rect2">Rectangle object two.</param>
        /// <returns>True if both Rectangle objects are not equal.</returns>
        public static bool operator !=(Rectangle rect1, Rectangle rect2)
        {
            return rect2 != null && (rect1 != null && (Math.Abs(rect1.Width - rect2.Width) > 0.001 || !(Math.Abs(rect1.Height - rect2.Height) < 0.001) || !(Math.Abs(rect1.GetArea() - rect2.GetArea()) < 0.001) || !(Math.Abs(rect1.GetPerimeter() - rect2.GetPerimeter()) < 0.001)));
        }

        /// <summary>
        /// Rectangle object's perimeter.
        /// </summary>
        /// <returns>Returns Rectangle object's perimeter.</returns>
        public double GetPerimeter()
        {
            return 2 * (this.ab.GetLength() + this.bc.GetLength());
        }

        /// <summary>
        /// Rectangle object's area.
        /// </summary>
        /// <returns>Returns Rectangle object's area.</returns>
        public double GetArea()
        {
            return this.ab.GetLength() * this.bc.GetLength();
        }

        /// <summary>
        /// Returns a Rectangle object to string in the following format : Rectangle[(x,y), (height,width)]
        /// </summary>
        /// <returns>Rectangle object as String.</returns>
        public override string ToString()
        {
            return string.Format("Rectangle[(" + this.PointA + "," + this.PointC + "), (" + this.Height + "," + this.Width + ")]");
        }

        /// <summary>
        /// Overrides Rectangle object's Equals() method.
        /// </summary>
        /// <param name="obj">Object to compare.</param>
        /// <returns>True if Rectangle object equals the input object.</returns>
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

        /// <summary>
        /// Overrides Rectangle object's GetHashCode() method.
        /// </summary>
        /// <returns>Rectangle object's hash code.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.PointA.GetHashCode();
                hashCode = (hashCode * 397) ^ this.PointB.GetHashCode();
                hashCode = (hashCode * 397) ^ this.PointC.GetHashCode();
                hashCode = (hashCode * 397) ^ this.PointD.GetHashCode();
                hashCode = (hashCode * 397) ^ this.ab.GetHashCode();
                hashCode = (hashCode * 397) ^ this.bc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Equals method for current instance and another Rectangle object.
        /// </summary>
        /// <param name="other">Rectangle object.</param>
        /// <returns>True if both objects are equal.</returns>
        protected bool Equals(Rectangle other)
        {
            return Rectangle.Equals(this.PointA, other.PointA) 
                && Rectangle.Equals(this.PointB, other.PointB) 
                && Rectangle.Equals(this.PointC, other.PointC) 
                && Rectangle.Equals(this.PointD, other.PointD) 
                && Rectangle.Equals(this.ab, other.ab) 
                && Rectangle.Equals(this.bc, other.bc);
        }
    }
}