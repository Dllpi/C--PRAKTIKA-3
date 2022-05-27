using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassSegment
{
    class Segment
    {
        private Point pStart;
        private Point pEnd;

        public Segment(Point pStart, Point pEnd)
        {
            this.pStart = pStart;
            this.pEnd = pEnd;
        }

        public Segment() { }

        public void Show()
        {
            Console.WriteLine("Отрезок с координатами: {0} - {1}", pStart, pEnd);
        }

        public double Length()
        {
            return pStart.Interval(pEnd);
        }
    }
}
