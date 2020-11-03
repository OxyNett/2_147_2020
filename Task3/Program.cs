using System;

namespace CourseApp
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

            new Solution(a, b).calculation();
            Console.ReadKey();
        }
    }
    class Solution
    {
        private double a;
        private double b;
        private double x;
        public Solution(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public void calculation()
        {
            x = b / a;
            if (a != 0)
            {
                Console.WriteLine("Ответ - {0}", x);
            }
            else
            {
                Console.WriteLine("Уравнение не имеет корней");
            }
        }
    }
}