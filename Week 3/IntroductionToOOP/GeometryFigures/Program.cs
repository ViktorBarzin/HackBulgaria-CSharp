﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(0, 0);
            Point point2 = new Point(4, 4);

            Point point3 = new Point(5, 5);
            Point point4 = new Point(1, 1);
            //point.ToString();
            //Console.WriteLine(point.Equals(point2));
            //Console.WriteLine(point == point2);

            //LineSegment line = new LineSegment(point, point2);
            //LineSegment line2 = new LineSegment(point3, point4);
            //Console.WriteLine(line.GetLength());
            //Console.WriteLine(line.ToString());
            //Console.WriteLine(line.Equals(line2));
            ////Console.WriteLine(line >= 5);
            //LineSegment line5 = point + point2;
            //Console.WriteLine(line5);
            Rectangle rect = new Rectangle(point, point2);
            Rectangle rect2 = new Rectangle(point3, point4);
            Console.WriteLine(rect.Equals(rect2));
            Console.WriteLine(rect == rect2);
            
            //TODO : properties for edges;
        }
    }
}
