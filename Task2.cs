using System;

namespace Fibobacci
{
    class Task2
    {
        static int Fibo(int n)
        {
            if (n > 1)
                return Fibo(n - 1) + Fibo(n - 2);
            else
                return 1;
        }


        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                Console.Write(Fibo(i) + " ");
            Console.WriteLine();
        }
    }