namespace GeometryFigures
{
    using System;

    /// <summary>
    /// Main Method Class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Point point = new Point(0, 0);
            Point point2 = new Point(4, 4);

            Point point3 = new Point(5, 5);
            Point point4 = new Point(1, 1);

            LineSegment line = new LineSegment(point, point2);
            LineSegment line2 = new LineSegment(point3, point4);

            Rectangle rect = new Rectangle(point, point2);
            Rectangle rect2 = new Rectangle(point3, point4);

            // TODO : properties for edges;
            Vector vect1 = new Vector(1, 2, 3);
            Vector vect2 = new Vector(4, 5, 6);
            Console.WriteLine(vect1 * vect2);
        }
    }
}