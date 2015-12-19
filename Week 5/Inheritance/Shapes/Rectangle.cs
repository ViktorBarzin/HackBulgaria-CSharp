namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
            this.Area = width * height;
            this.Perimeter = 2 * (this.Width + this.Height);
            this.Center = new Point(0.5 * this.Width, 0.5 * this.Height);
        }

        public double Width { get; protected set; }

        public double Height { get; protected set; }
        
    }
}
