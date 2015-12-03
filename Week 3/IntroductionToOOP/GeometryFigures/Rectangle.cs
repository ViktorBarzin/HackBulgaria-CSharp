using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Rectangle
    {
        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private LineSegment AB;
        private LineSegment BC;

        public Rectangle(Point p1, Point p2)
        {
            PointA = p1;
            PointC = p2;
            this.B = new Point(Math.Max(PointA.X, PointC.X), Math.Min(PointA.Y, PointC.Y));
            this.D = new Point(Math.Min(PointA.X, PointC.X), Math.Max(PointA.Y, PointC.Y));

            this.AB = new LineSegment(this.A, this.B);
            this.BC = new LineSegment(this.B, this.C);


        }
        public Point PointA
        {
            get { return A; }
            set
            {
                this.A = value;
            }
        }
        public Point PointC
        {
            get { return C; }
            set
            {
                if (value.X != this.A.X && value.Y != this.A.Y)
                {
                    this.C = value;
                }
                else
                {
                     throw new ArgumentException("Invalid Point");
                }
            }
        }

        public Point DisplayA
        {
            get { return this.A; }
        }
        public Point DisplayB
        {
            get { return this.B; }
        }
        public Point DisplayC
        {
            get { return this.C; }
        }
        public Point DisplayD
        {
            get { return this.D; }
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
            get { return new Point(this.Width / 2 + this.A.X, this.Height / 2 + this.A.Y); }
        }

        public double GetPerimeter()
        {
            return 2 * (this.AB.GetLength() + this.BC.GetLength());
        }
        public double GetArea()
        {
            return this.AB.GetLength() * this.BC.GetLength();
        }

        public override string ToString()
        {
            //Rectangle[(x,y), (height,width)]
            string res = "Rectangle[(" + this.PointA.ToString() + "," + this.PointC.ToString() + "), (" + this.Height + "," + this.Width + ")]";
            return res;
        }
        public override bool Equals(object obj)
        {
            if (this.PointC.Equals((obj as Rectangle).PointC) && this.PointA.Equals((obj as Rectangle).PointA))
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Rectangle rect1,Rectangle rect2)
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
    }
}

