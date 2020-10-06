using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число");
            int number = int.Parse(Console.ReadLine());
            double octatok = number % 2;
            if (octatok == 0)
                Console.WriteLine("число четное");
            else
                Console.WriteLine("Число нечетное");

        }
    }
}
