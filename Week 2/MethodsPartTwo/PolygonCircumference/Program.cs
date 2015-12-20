/*
Write a method which calculates the circumference of a given polygon.

float CalcCircumference(PointF[] points)

The polygon is given as an array of PointFs which represents a point with a floating point coordinates (from System.Drawing).

The 0 index of the array contains the bottom-most point, and the next points are sorted counter-clockwise according to the point at 0.
*/

namespace PolygonCircumference
{
    using System;
    using System.Drawing;

    public class Program
    {
        public static float GetPointDistance(PointF point1, PointF point2)
        {
            float distance = (float)Math.Pow(Math.Max(point1.X, point2.X) - Math.Min(point1.X, point2.X), 2) + (float)Math.Pow(Math.Max(point1.Y, point2.Y) - Math.Min(point1.Y, point2.Y), 2);
            return (float)Math.Sqrt(distance);
        }

        public static float CalcCircumference(PointF[] points)
        {
            float sum = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                sum += GetPointDistance(points[i], points[i + 1]);
            }

            return sum;
        }

        public static void Main()
        {
            PointF[] pointsArr = { new PointF(3, 2), new PointF(6, 2), new PointF(3, 4), new PointF(6, 4) };
            Console.WriteLine(CalcCircumference(pointsArr));
        }
    }
}