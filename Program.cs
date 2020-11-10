using System;

namespace _3._3._3
{
    class yravnenie 
    {
        public double a ;
        public double b;
        public yravnenie(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
       
        public void GetInfo()
        {
            if (a == 0)
            { Console.WriteLine("На 0 делить нельзя"); }
            else
            {
                Console.WriteLine("Otvet = {0}", b / a);
            }
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            double a, b;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            new yravnenie(a, b).GetInfo();
            Console.ReadKey();
        }
    }
}
