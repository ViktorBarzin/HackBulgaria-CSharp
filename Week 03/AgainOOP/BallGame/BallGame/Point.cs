using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGame
{
    public class Point
    {
        private double x;
        private double y;
        private double xOrigin;
        private double yOrigin;

        public Point()
        {
            this.X = 0;
            this.Y = 0;
        }
        public Point(double xCoor, double yCoor,double xOrig = 0, double yOrig = 0)
        {
            this.X = xCoor;
            this.Y = yCoor;
            this.XOrigin = xOrig;
            this.YOrigin = yOrig;
        }
        public double XOrigin
        {
            get { return this.xOrigin; }
            set { this.xOrigin = value; }
        }
        public double YOrigin
        {
            get { return this.yOrigin; }
            set { this.yOrigin = value; }
        }
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public int Display
        {
            get { Console.WriteLine("{0}:{1}", this.x, this.y); return 1; }
        }
        public override string ToString()
        {
            string toString = x.ToString() + ":" + y.ToString();
            return toString;
        }
        public override bool Equals(object point)
        {
            if (this.x == (point as Point).x && this.y == (point as Point).y)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Point point1, Point point2)
        {
            if (point1.x == point2.x && point1.y == point2.y)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Point point1, Point point2)
        {
            if (point1.x == point2.x ^ point1.y == point2.y)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + x.GetHashCode();
                hash = hash * 23 + y.GetHashCode();
                return hash;
            }
        }
        public static LineSegment operator +(Point p1, Point p2)
        {
            LineSegment newLine = new LineSegment(p1, p2);
            return newLine;
        }
    }
}
