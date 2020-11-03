using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("Число является чётным");
            else
                Console.WriteLine("Число не является чётным");
            Console.ReadKey();
        }
    }
}