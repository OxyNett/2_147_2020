using System;

namespace cw0411
{
    abstract class ShapesClass
    {
        abstract public int Area();
        abstract public int Per();
    }

    class Square : ShapesClass
    {
        int side = 0;
        public Square(int n)
        {
            side = n;
        }

        public override  int Area()
        {
            return side * side;
        }

        public override int Per()
        {
            return 4 * side;
        }
    }

    class Circle : ShapesClass
    {
        int radius = 0;
        int pi = 3;
        public Circle(int r)
        {
            radius = r;
        }
        public override int Area()
        {
            int A = radius * radius * pi;
            return A;
        }

        public override int Per()
        {
            int P = 2 * pi * radius;
            return P;
        }

        class Corners
        {
            public int grad;
            public Corners (int a)
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
                this.b = Math.Sqrt(a*a+c*c);
            }

            public Triangle(double a, double b, Corners cornc)
            {
                this.a = a;
                this.b = b;
                this.c = Math.Sqrt(b*b -a*a);
            }

            public override int Per()
            {
                int P = Convert.ToInt32(a + b + c);
                return P;
            }
            public override int Area()
            {
                double p = Per() / 2;
                int A = Convert.ToInt32(Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
                return A;
            }
        }

        static void Main()
        {
            Square sq = new Square(12);
            Console.WriteLine("Square area = {0}, square perimetr = {1}", sq.Area(), sq.Per());
            Circle cc = new Circle(12);
            Console.WriteLine("Circle area = {0}, circle perimetr = {1}", cc.Area(), cc.Per());
            Triangle tg = new Triangle(12, 16, 20);
            Console.WriteLine("Triangle x3 side area = {0}, triangle perimetr = {1}", tg.Area(), tg.Per());
            Corners b90 = new Corners(90);
            Corners c45 = new Corners(45);
            Triangle tc = new Triangle(4, b90, c45);
            Console.WriteLine("Triangle x1 side x2 corner area = {0}, triangle perimetr = {1}", tc.Area(), tc.Per());
            Triangle tt = new Triangle(24, 25, c45);
            Console.WriteLine("Triangle x2 side x1 corner area = {0}, triangle perimetr = {1}", tt.Area(), tt.Per());
        }
    }
}
