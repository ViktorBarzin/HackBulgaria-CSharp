namespace PolygonArea
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

        public static void Main()
        {
            // TODO : find formula for any random polygon area
        }
    }
}