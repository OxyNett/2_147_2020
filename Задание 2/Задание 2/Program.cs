using System;

namespace Задание_2
{
    class number2
    {
        static void Main(string[] args)
        {
            int value, f, s, fib;
            Console.WriteLine("To what value should the prog calculate Fibonacci?");
            value = Convert.ToInt32(Console.ReadLine());

            f = 1;
            s = 1;
            Console.Write("1 1 ");
            fib = 0;

            while (fib < value)
            {
                fib = f + s;
                Console.Write(fib);
                Console.Write(" ");

                f = s;
                s = fib;
            }
        }
    }
}
