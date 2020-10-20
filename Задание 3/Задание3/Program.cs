using System;

namespace Задание3
{
    class solution
    {
       private double ac, bc, x;

        public double divideby(double a, double b)
        {
            ac = a;
            bc = b;

            x = bc / ac;

            return x;
        }

    }

    class number3

    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Enter a, b:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());

            solution ob = new solution();
            Console.WriteLine(ob.divideby(a, b));

            Console.ReadKey();
        }
       
    }
    
}
