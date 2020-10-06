using System;

namespace proetct2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvdei chislo");
            int number = Convert.ToInt32(Console.ReadLine());

            int pervoe = 1;
            Console.Write("{0} ", pervoe);
            int vtoroe = 1;
            Console.Write("{0} ", vtoroe);
            int sum = 0;
            while (number >= sum)
            {
                sum = pervoe + vtoroe;
                if (number >= sum)
                    Console.Write("{0} ", sum);

                pervoe = vtoroe;
                vtoroe = sum;
            }
        }
    }
}