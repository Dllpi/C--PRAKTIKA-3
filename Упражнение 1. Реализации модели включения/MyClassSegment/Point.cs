using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassSegment
{
    class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x; this.y = y;
        }

        public Point() { }

        public void Show()
        {
            Console.WriteLine("Точка с координатами: ({0};{1})", x, y);
        }

        public double Interval(Point p)
        {
            return Math.Sqrt((this.x - p.x) * (this.x - p.x) + (this.y - p.y) * (this.y - p.y));
        }

        public override string ToString()
        {
            return "(" + x + ";" + y + ")";
        }
    }
}
