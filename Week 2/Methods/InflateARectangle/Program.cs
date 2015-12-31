namespace InflateARectangle
{
    using System;
    using System.Drawing;

    /// <summary>
    /// Write a method which takes a rectangle as an argument and inflates it
    /// with the specified size in all directions.This means that if you get
    /// a rectangle (x:0, y:0, w:10, h:10) and inflate it with a size of(2,2),
    /// the resulting rectangle should be(x:-2, y:-2, w:14, h:14). 
    /// Use the ref keyword to store the result in the same variable.
    /// void Inflate(ref Rectangle <![CDATA[rect]]>, Size inflateSize).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Inflates a Rectangle with "inflateSize".
        /// </summary>
        /// <param name="rect">Rectangle to resize.</param>
        /// <param name="inflateSize">Amount of inflation.</param>
        public static void Inflate(ref Rectangle rect, Size inflateSize)
        {
            rect.X -= inflateSize.Width;
            rect.Y -= inflateSize.Height;
            rect.Height += inflateSize.Height * 2;
            rect.Width += inflateSize.Width * 2;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Rectangle rect = new Rectangle(0, 0, 10, 10);
            Size size = new Size(2, 2);
            Inflate(ref rect, size);
            Console.WriteLine(rect);

            // x: 0,y: 0,w: 10,h:10
        }
    }
}