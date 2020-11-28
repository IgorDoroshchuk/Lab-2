using System;

namespace Lab_2._4
{
    namespace _4
    {
        class Point
        {
            private int x;
            private int y;
            private string pointName;
            public int X { get { return x; } }
            public int Y { get { return y; } }
            public Point()
            {

            }
            public Point(int x, int y, string name)
            {
                this.x = x;
                this.y = y;
                this.pointName = name;
            }
        }

        class Figure
        {
            private Point A;
            private Point B;
            private Point C;
            private Point D;
            private Point E;
            public Figure()
            {

            }
            public Figure(Point A, Point B, Point C)
            {
                this.A = A;
                this.B = B;
                this.C = C;
            }
            public Figure(Point A, Point B, Point C, Point D)
            {
                this.A = A;
                this.B = B;
                this.C = C;
                this.D = D;
            }
            public Figure(Point A, Point B, Point C, Point D, Point E)
            {
                this.A = A;
                this.B = B;
                this.C = C;
                this.D = D;
                this.E = E;
            }
            public double LengthSide(Point A, Point B)
            {
                return Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
            }
            public void PerimeterCalculator()
            {
                if (E != null)
                {
                    Console.WriteLine($"Perimeter: {(LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A) + LengthSide(D, E) + LengthSide(E, A))}");
                }
                else if (D != null)
                {
                    Console.WriteLine($"Perimeter: {(LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, A))}");
                }
                else
                {
                    Console.WriteLine($"Perimeter: {(LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A))}");
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Point A = new Point(0, 0, "point1");
                Point B = new Point(2, 3, "point2");
                Point C = new Point(3, 3, "point3");
                Point D = new Point(2, 5, "point4");
                Point E = new Point(1, 2, "point5");

                Figure figure = new Figure(A, B, C, D, E);
                figure.PerimeterCalculator();
                Console.ReadKey();
            }
        }
    }
}
