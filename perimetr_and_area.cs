using System;

namespace ConsoleApp1
{
    class Program
    {
        abstract class ShapesClass
        {
            abstract public double Area();
            abstract public double Perimetr();
        }
        class Square : ShapesClass
        {
            double side = 0;
            public Square(double n)
            {
                side = n;
            }
            public override double Area()
            {
                return side * side;
            }
            public override double Perimetr()
            {
                return side * 4;
            }
        }
        class Circule : ShapesClass
        {
            double R = 0;
            public Circule(double n)
            {
                R = n;
            }
            public override double Area()
            {
                return R * R * 3.14;
            }
            public override double Perimetr()
            {
                return R * 2 * 3.14;
            }
        }
        class Triangle1 : ShapesClass
        {
            double side1 = 0;
            double side2 = 0;
            double side3 = 0;
            public Triangle1(double n, double m, double k)
            {
                side1 = n;
                side2 = m;
                side3 = k;
            }
            public override double Area()
            {
                return Math.Sqrt((((side1 + side2 + side3) / 2) * ((side1 + side2 + side3) / 2) - side1) * (((side1 + side2 + side3) / 2) - side2) * (((side1 + side2 + side3) / 2) - side3));
            }
            public override double Perimetr()
            {
                return side1 + side2 + side3;
            }
        }
        class Triangle2 : ShapesClass
        {
            double side1 = 0;
            double angle2 = 0;
            double angle3 = 0;
            public Triangle2(double n, double m, double k)
            {
                side1 = n;
                angle2 = m;
                angle3 = k;
            }
            public override double Area()
            {
                return (Math.Sin(angle2) * Math.Sin(angle3) * side1 * side1) / (2 * Math.Sin(angle2 + angle3));
            }
            public override double Perimetr()
            {
                return side1 - side1 * (Math.Sin(angle2) / Math.Sin(180 - (angle2 + angle3))) - side1 * (Math.Sin(angle3) / Math.Sin(180 - (angle2 + angle3)));
            }
        }
        /*class Triangle3 : ShapesClass
        {
        double side1 = 0;
        double angle2 = 0;
        public Triangle2(double n, double m, double k)
        {
        side1 = n;
        angle2 = m;
        }
        public override double Area()
        {
        return ;
        }
        public override double Perimetr()
        {
        return ;
        }
        }*/

        static void Main(string[] args)
        {
            Square sq = new Square(12);
            Console.WriteLine("Area of the square = {0} Perimetr of the square = {1}", sq.Area(), sq.Perimetr());
            Circule cir = new Circule(12);
            Console.WriteLine("Area of the circule = {0} Perimetr of the circule = {1}", cir.Area(), cir.Perimetr());
            Triangle1 tr1 = new Triangle1(12, 11, 10);
            Console.WriteLine("Area of the triangle = {0} Perimetr of the triangle = {1} (for a triangle with given sides)", tr1.Area(), tr1.Perimetr());
            Triangle2 tr2 = new Triangle2(12, 30, 60);
            Console.WriteLine("Area of the triangle = {0} Perimetr of the triangle = {1} (for a triangle with a given side and two adjacent corners)", tr2.Area(), tr2.Perimetr());
            Console.ReadLine();
        }
    }
}
