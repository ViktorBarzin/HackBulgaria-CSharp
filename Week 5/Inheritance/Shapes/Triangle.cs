
namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Triangle : Shape
    {
        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
            Vertex3 = vertex3;
            this.Perimeter = GetPerimeter();
            this.Area = GetArea();
            this.Center = new Point(0, 0);
        }

        protected Point Vertex1 { get; set; }

        protected Point Vertex2 { get; set; }

        protected Point Vertex3 { get; set; }

        public override double GetArea()
        {
            // Works with positive numbers only, i hate geometry anyway
            return (Vertex1.X * (Math.Max(Vertex2.Y, Vertex3.Y) - Math.Min(Vertex2.Y, Vertex3.Y)) + Vertex2.X * (Math.Max(Vertex1.Y, Vertex3.Y) - Math.Min(Vertex1.Y, Vertex3.Y)) + Vertex3.X * (Math.Max(Vertex1.Y, Vertex2.Y) - Math.Min(Vertex1.Y, Vertex2.Y))) / 2;
        }

        public override double GetPerimeter()
        {
            double c = Math.Sqrt(Math.Pow(Math.Max(Vertex1.X, Vertex2.X) - Math.Min(Vertex1.X, Vertex2.X), 2) + Math.Pow(Math.Max(Vertex1.Y, Vertex2.Y) - Math.Max(Vertex1.Y, Vertex2.Y), 2));
            double b = Math.Sqrt(Math.Pow(Math.Max(Vertex1.X, Vertex3.X) - Math.Min(Vertex1.X, Vertex3.X), 2) + Math.Pow(Math.Max(Vertex1.Y, Vertex3.Y) - Math.Max(Vertex1.Y, Vertex3.Y), 2));
            double a = Math.Sqrt(Math.Pow(Math.Max(Vertex3.X, Vertex2.X) - Math.Min(Vertex3.X, Vertex2.X), 2) + Math.Pow(Math.Max(Vertex3.Y, Vertex2.Y) - Math.Max(Vertex3.Y, Vertex2.Y), 2));
            return a + b + c;
        }
    }
}
