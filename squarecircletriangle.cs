using System;

namespace ConsoleApp12
{
    class Program
    {
        abstract class ShapesClass
        {
            abstract public double Area();
            abstract public double getP();

        }
        class Square : ShapesClass
        {
            int side = 0;
            public Square(int n)
            {
                side = n;
            }
            public override double Area()
            {
                return side * side;
            }
            public override double getP()
            {
                return side * 4;
            }
        }
        class Circle : ShapesClass
        {
            int r = 0;
            public Circle(int s)
            {
                r = s;
            }
            public override double Area()
            {
                return Math.PI * r * r;
            }
            public override double getP()
            {
                return 2 * r * Math.PI;
            }
        }
        class triangle : ShapesClass
        {
            double a = 0; double b = 0; double c = 0;
            public triangle(double f, double g, double t)
            {
                a = f;
                b = g;
                c = t;
            }
            public override double Area()
            {
                double p2 = (a + b + c) / 2;
                return Math.Sqrt(p2 * (p2 - a) * (p2 - b) * (p2 - c));
            }
            public override double getP()
            {
                return a + b + c;
            }


        }
        class triangle2 : ShapesClass
        {
            double a = 0; double b = 0; double c = 0;
            public triangle2(double y, double ugolB, double ugolC)
            {
                a = y;
                double ugolA = 180 - ugolB - ugolC;
                b = a * Math.Sin(ugolB) / Math.Sin(ugolA);
                c = a * Math.Sin(ugolC) / Math.Sin(ugolA);
            }

            public override double Area()
            {
                double p2 = (a + b + c) / 2;
                return Math.Sqrt(p2 * (p2 - a) * (p2 - b) * (p2 - c));
            }
            public override double getP()
            {
                return a + b + c;
            }


        }
        class triangle3 : ShapesClass
        {
            double a = 0; double b = 0; double c = 0;
            public triangle3(double u, double i, double ugolC)
            {
                a = u;
                b = i;
                c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(ugolC));
            }

            public override double Area()
            {
                double p2 = (a + b + c) / 2;
                return Math.Sqrt(p2 * (p2 - a) * (p2 - b) * (p2 - c));
            }
            public override double getP()
            {
                return a + b + c;
            }


        }
        static void Main(string[] args)
        {
            triangle tg1 = new triangle(6, 3, 4);
            triangle2 tg2 = new triangle2(6, 65, 25);
            triangle3 tg3 = new triangle3(6, 7, 45);
            Square sq = new Square(12);
            Circle ci = new Circle(5);
            Console.WriteLine("area of the square={0} ", sq.Area());
            Console.WriteLine("perimeter of the square={0} ", sq.getP());
            Console.WriteLine("area of the circle={0} ", ci.Area());
            Console.WriteLine("perimeter of the cirlce={0} ", ci.getP());
            Console.WriteLine("area of the triangle1={0} ", tg1.Area());
            Console.WriteLine("perimeter of the triangle1={0} ", tg1.getP());
            Console.WriteLine("area of the triangle2={0} ", tg2.Area());
            Console.WriteLine("perimeter of the triangle2={0} ", tg2.getP());
            Console.WriteLine("area of the triangle3={0} ", tg3.Area());
            Console.WriteLine("perimeter of the triangle3={0} ", tg3.getP());
        }
    }
}