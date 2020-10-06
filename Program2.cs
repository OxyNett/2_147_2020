using System;

namespace Задание_2_2вар_
{
    class Program
    {
        static int Fibo(int n)
        {
            if (n > 1)
                return Fibo(n - 1) + Fibo(n - 2);
            else
                return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nВведите количество элементов: ");
            int p = int.Parse(Console.ReadLine());
            int n = p;
            for (int i = 0; i < n; i++)
                Console.Write(Fibo(i) + " "); 
            Console.WriteLine("\nВведите номер числа: ");
            int Number = int.Parse(Console.ReadLine());
            Number--;
            for (int i = 0; i <= Number; i++)
            {
                Console.WriteLine(Fibo(i));
            }
            Console.ReadKey();
        }
    }
}
