using System;

namespace HomeWork3
{
    class Polygon
    {

        public string namePolygon;
        public Point p1;
        public Point p2;
        public Point p3;
        public Point p4;
        public Point p5;
        public int numberOfVertices;

        public Polygon(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p2 = p3;
            numberOfVertices = 3;
            namePolygon = "треугольник";
        }

        public Polygon(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            namePolygon = "Пятиугольник";
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.numberOfVertices = 5;
        }

        public static double SideLength(Point рoint1, Point point2)
        {
            double length = Math.Sqrt(Math.Pow((point2.x - рoint1.x), 2) + Math.Pow((point2.y - рoint1.y), 2));

            return length;
        }

        public double Perimeter(Polygon m)
        {
            Point[] a = { m.p1, m.p2, m.p3, m.p4, m.p5};

            double perimeterP = 0.0;

            for (int i = 1; i < m.numberOfVertices - 1; i++)
            {
                if (i == m.numberOfVertices)
                {
                    perimeterP += SideLength(a[i], a[1]);
                }
                else
                {
                    perimeterP += SideLength(a[i], a[i + 1]);
                }

            }
            return perimeterP;
        }
        
    }


}
