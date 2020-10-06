using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());

            new Reshenie(a, b).raschet();
            Console.ReadKey();
        }
    }
    class Reshenie
    {
        private double a;
        private double b;
        private double x;
        public Reshenie(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public void raschet()
        {
            x = b / a;
            if (a != 0)
            {
                Console.WriteLine("Ответ: {0}", x);
            }
            else
            {
                Console.WriteLine("x - уравнение не имеет корней");
            }
            Console.ReadKey();
        }
    }
}