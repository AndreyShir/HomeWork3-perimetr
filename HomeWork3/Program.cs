using System;


namespace HomeWork3
{
    class Program
    {
        private static void Main(string[] args)
        {
           
            var m = new Polygon(PointA(), PointB(), PointC(), PointD(), PointF());
            double a = m.Perimeter(m); // я не понемаю почему она так вызывается;
            Console.WriteLine($"Перемитр= {a}");

            

        }
        static Point PointA()
        {
            var a = new Point("A", -4, 4);
            // a.DisplayInfo();
            return a;
        }
        static Point PointB()
        {
            var b = new Point("B", 0, 8);
            // b.DisplayInfo();
            return b;
        }
        static Point PointC()
        {
            var c = new Point("C", 4, 4);
            // c.DisplayInfo();
            return c;
        }
        static Point PointD()
        {
            var d = new Point("D", 1, -3);
            // d.DisplayInfo();
            return d;
        }
        static Point PointF()
        {
            var f = new Point("F", -2, 5);
            // f.DisplayInfo();
            return f;
        }



    }
}
