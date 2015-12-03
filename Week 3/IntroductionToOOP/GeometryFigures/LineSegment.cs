using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class LineSegment
    {
        private Point start;
        private Point end;
        private double length;
        public LineSegment(Point start, Point end)
        {
            this.Start = start;
            this.End = end;
            this.length = GetLength();
        }
        public Point Start
        {
            get { return this.start; }
            set { this.start = value; }
        }
        public Point End
        {
            get { return this.end; }
            set
            {
                if (value == this.start)
                {
                    throw new ArgumentException("Cannot have a line with 0 lenght");
                }
                this.end = value;
            }
        }
        public double GetLength()
        {
            this.length = Math.Pow(Math.Max(this.start.X, this.end.X) - Math.Min(this.start.X, this.end.X),2) 
                + Math.Pow(Math.Max(this.start.Y,this.end.Y) - Math.Min(this.start.Y,this.end.Y),2) ;
            return Math.Sqrt(length);
        }
        public override string ToString()
        {
            //Line[(x1, y1), (x2, y2)]
            string res = "Line[(" + start.X.ToString() + ", " + start.Y.ToString() + "), (" + end.X.ToString() + ", " + end.Y.ToString() + ")]";
            return res;
        }
        public static bool operator == (LineSegment line1,LineSegment line2)
        {
            if (line1.length ==line2.length)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(LineSegment line1, LineSegment line2)
        {
            if (line1.length != line2.length)
            {
                return true;
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            if (this.start == (obj as LineSegment).start && this.end == (obj as LineSegment).end)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(LineSegment line1, LineSegment line2)
        {
            if (line1.length < line2.length)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(LineSegment line1, LineSegment line2)
        {
            if (line1.length <= line2.length)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(LineSegment line1, LineSegment line2)
        {
            if (line1.length > line2.length)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(LineSegment line1, LineSegment line2)
        {
            if (line1.length >= line2.length)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(LineSegment line1,double len)
        {
            if (line1.length < len)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(LineSegment line1,double len)
        {
            if (line1.length <= len)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(LineSegment line1, double len)
        {
            if (line1.length > len)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(LineSegment line1,double len)
        {
            if (line1.length >= len)
            {
                return true;
            }
            return false;
        }
    }
}
