using System;

namespace MyClassSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.Show();

            Point p2 = new Point(12, 13);
            p2.Show();

            Segment r = new Segment(p1, p2);
            r.Show();

            double d = r.Length();
            Console.WriteLine("Длина отрезка: {0}", d);
        }
    }
}
