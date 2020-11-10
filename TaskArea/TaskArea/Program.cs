using System;

namespace TaskArea
{
    abstract class ShapesClass
    {
        abstract public double Area();
        abstract public double Perimeter();
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

        public override double Perimeter()
        {
            return 4 * side;
        }
    }

    class Circle : ShapesClass
    {
        int radius = 0;
        double pi = 3.14;
        public Circle(int r)
        {
            radius = r;
        }
        public override double Area()
        {
            double A = radius * radius * pi;
            return A;
        }

        public override double Perimeter()
        {
            double P = 2 * pi * radius;
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
            double a, b, c;
            public Triangle(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public Triangle(double a, Corners cornb, Corners cornc)
            {
                this.a = a;
                this.c = a / Math.Sin(cornc.grad);
                this.b = Math.Sqrt(a * a + c * c);
            }

            public Triangle(double a, double b, Corners cornc)
            {
                this.a = a;
                this.b = b;
                this.c = Math.Sqrt(b * b - a * a);
            }

            public override double Perimeter()
            {
                int P = Convert.ToInt32(a + b + c);
                return P;
            }
            public override double Area()
            {
                double p = Perimeter() / 2;
                int A = Convert.ToInt32(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
                return A;
            }
        }

        static void Main()
        {
            Square sq = new Square(12);
            Console.WriteLine("Area of the square = {0}; Perimetr of the square = {1}", sq.Area(), sq.Perimeter());
            Circle cir = new Circle(12);
            Console.WriteLine("Area of the circle = {0}; Perimetr of the circle = {1}", cir.Area(), cir.Perimeter());
            Triangle tr1 = new Triangle(12, 16, 20);
            Console.WriteLine("Triangle x3 side area = {0}, triangle perimetr = {1}", tr1.Area(), tr1.Perimeter());
            Corners b90 = new Corners(90);
            Corners c45 = new Corners(45);
            Triangle tr2 = new Triangle(4, b90, c45);
            Console.WriteLine("Triangle x1 side x2 corner area = {0}, triangle perimetr = {1}", tr2.Area(), tr2.Perimeter());
            Triangle tr3 = new Triangle(24, 25, c45);
            Console.WriteLine("Triangle x2 side x1 corner area = {0}, triangle perimetr = {1}", tr3.Area(), tr3.Perimeter());
        }
    }
}
