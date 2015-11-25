using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InflateARectangle
{
    class Program
    {
        public static void Inflate(ref Rectangle rect, Size inflateSize)
        {
            rect.X -= inflateSize.Width;
            rect.Y -= inflateSize.Height;
            rect.Height += inflateSize.Height*2;
            rect.Width += inflateSize.Width*2;
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(0, 0, 10, 10);
            Size size = new Size(2, 2);
            Inflate(ref rect, size);
            Console.WriteLine(rect);
            //x: 0,y: 0,w: 10,h:10
        }
    }
}
