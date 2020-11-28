using System;

namespace Lab_2._2
{
    using System;

    namespace _2
    {
        class Rectangle
        {
            private double side1, side2;
            public Rectangle(double side1, double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }
            private double AreaCalculator(double side1, double side2)
            {
                return side1 * side2;
            }
            private double PerimeterCalculator(double side1, double side2)
            {
                return 2 * (side1 + side2);
            }
            public double Area
            {
                get
                {
                    return AreaCalculator(side1, side2);
                }
            }
            public double Perimeter
            {
                get
                {
                    return PerimeterCalculator(side1, side2);
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Side A:");
                double A = double.Parse(Console.ReadLine());
                Console.WriteLine("Side B:");
                double B = double.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(A, B);
                Console.WriteLine($"Area: {rectangle.Area}\nPerimeter: {rectangle.Perimeter}");
                Console.ReadKey();
            }
        }
    }
}
    
