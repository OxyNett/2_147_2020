using System;

namespace AreaPerimeterTask
{
    abstract class ShapesClass
    {
        abstract public double Per();
        abstract public double Area();
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
        public override double Per()
        {
            return 4 * side;
        }
    }
    class Circle : ShapesClass
    {
        int rad = 0;
        double pi = 3.14;
        public Circle(int r)
        {
            rad = r;
        }
        public override double Area()
        {
            double A = rad * rad * pi;
            return A;
        }
        public override double Per()
        {
            double P = 2 * pi * rad;
            return P;
        }
        class Corners
        {
            public int grad;
            public Corners(int a)
            {
                grad = a;
            }
        }
        class Triangle : ShapesClass
        {
            double? a, b, c;
            Corners corna, cornb, cornc;
            public Triangle(double? a, double? b, double? c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public Triangle(double? a, Corners cornb, Corners cornc)
            {
                this.a = a;
                this.cornb = cornb;
                this.cornc = cornc;
            }
            public Triangle(double? a, double? b, Corners cornc)
            {
                this.a = a;
                this.b = b;
                this.cornc = cornc;
            }
            public void CalculateSides()
            {
                if ((a != null) && (b != null) && (c != null))
                {
                    return;
                }
                else if ((cornb != null) && (cornc != null) && (a != null))
                {
                    c = a / Math.Sin(cornc.grad);
                    double s = (double)(a * a + c * c);
                    double d = Math.Sqrt(s);
                    b = (double?)d;
                }
                else if ((cornc != null) && (a != null) && (b != null))
                {
                    double s0 = (double)(b * b - a * a);
                    c = (double?)Math.Sqrt(s0);
                }
                else Console.WriteLine("Не хватает данных");
            }
            public override double Per()
            {
                CalculateSides();
                return Convert.ToInt32(a + b + c);
            }
            public override double Area()
            {
                double p = Per() / 2;
                double v = (double)(p * (p - a) * (p - b) * (p - c));
                return Convert.ToInt32(Math.Sqrt(v));
            }
        }
        static void Main(string[] args)
        {
            Square sq = new Square(12);
            Console.WriteLine("Square area = {0}; Perimeter of a square = {1}", sq.Area(), sq.Per());
            Circle cc = new Circle(12);
            Console.WriteLine("Area of the circle = {0}; Perimeter of a circle = {1}", cc.Area(), cc.Per());
            Triangle tg = new Triangle(12, 16, 20);
            Console.WriteLine("Triangle x3 side area = {0}; Perimeter of a triangle = {1}", tg.Area(), tg.Per());
            Corners b90 = new Corners(90);
            Corners c45 = new Corners(45);
            Triangle tc = new Triangle(4, b90, c45);
            Console.WriteLine("Triangle x1 side x2 corner area = {0}; Perimeter of a triangle {1}", tc.Area(), tc.Per());
            Triangle tt = new Triangle(24, 25, c45);
            Console.WriteLine("Triangle x2 side x1 corner area = {0}; Perimeter of a triangle = {1}", tt.Area(), tt.Per());
        }
    }
}
