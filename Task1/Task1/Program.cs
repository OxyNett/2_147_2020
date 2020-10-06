using System;
using System.Diagnostics;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("T1");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m % 2 == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Нечетное");
            }
            Console.WriteLine("T2");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0, j = 0; j < n; ++i, j = Fib(i))
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("T3");
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("AATTAT");
            }
            else
            {
                Console.WriteLine($"x = {b / a}");
            }
        }
        static int Fib(int n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            }
            return Fib(n - 2) + Fib(n - 1);
        }
    }
}
