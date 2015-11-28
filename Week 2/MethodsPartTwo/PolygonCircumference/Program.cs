/*
Write a method which calculates the circumference of a given polygon.

float CalcCircumference(PointF[] points)

The polygon is given as an array of PointFs which represents a point with a floating point coordinates (from System.Drawing).

The 0 index of the array contains the bottom-most point, and the next points are sorted counter-clockwise according to the point at 0.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PolygonCircumference
{
    class Program
    {
        public static float getPointDistance(PointF point1, PointF point2)
        {
            float distance = (float)Math.Pow((Math.Max(point1.X, point2.X) - Math.Min(point1.X, point2.X)), 2) +
                              (float)Math.Pow((Math.Max(point1.Y, point2.Y) - Math.Min(point1.Y, point2.Y)),2);
            return (float)Math.Sqrt(distance);
        }
        public static float CalcCircumference(PointF[] points)
        {
            float sum = 0;
            for (int i = 0; i < points.Length-1; i++)
            {
                if (points[i+1] != null)
                {
                    sum += (float)getPointDistance(points[i], points[i + 1]);
                }
                else
                {
                    sum += (float)getPointDistance(points[i], points[0]);
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            PointF[] pointsArr = new PointF[]
            {
                new PointF(3,2),
                new PointF(6,2),
                new PointF(3,4),
                new PointF(6,4)
            };
            Console.WriteLine(CalcCircumference(pointsArr));
        }
    }
}
