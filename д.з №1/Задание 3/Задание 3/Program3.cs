using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,x;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());

            new prog(a, x).search();
            Console.ReadKey();
            
        }
    }
    class prog
    {
        private double a;
        private double x;
        private double b;
        public prog(double a, double x)
        {
            this.a = a;
            this.x = x;
        }
        public void search()
        {
            double b = this.a * this.x;
            Console.WriteLine("Решение: {0}", b);
            Console.ReadKey();
        }
    }
}
