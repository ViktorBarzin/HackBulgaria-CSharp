using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PolygonArea
{
    class Program
    {
        public static float getPointDistance(PointF point1, PointF point2)
        {
            float distance = (float)Math.Pow((Math.Max(point1.X, point2.X) - Math.Min(point1.X, point2.X)), 2) +
                              (float)Math.Pow((Math.Max(point1.Y, point2.Y) - Math.Min(point1.Y, point2.Y)), 2);
            return (float)Math.Sqrt(distance);
        }
        static void Main(string[] args)
        {
            // TODO : find formula for any random polygon area
        }
    }
}
