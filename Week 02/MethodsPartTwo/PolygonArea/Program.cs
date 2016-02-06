namespace PolygonArea
{
    using System;
    using System.Drawing;

    /// <summary>
    /// Write a method which calculates the area of a given polygon.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Gets point distance.
        /// </summary>
        /// <param name="point1">Input Point one.</param>
        /// <param name="point2">Input Point two.</param>
        /// <returns>The distance from point one to point two.</returns>
        public static float GetPointDistance(PointF point1, PointF point2)
        {
            float distance = (float)Math.Pow(Math.Max(point1.X, point2.X) - Math.Min(point1.X, point2.X), 2) + (float)Math.Pow(Math.Max(point1.Y, point2.Y) - Math.Min(point1.Y, point2.Y), 2);
            return (float)Math.Sqrt(distance);
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            // TODO : find formula for any random polygon area
        }
    }
}