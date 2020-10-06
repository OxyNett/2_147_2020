using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvdei chislo");
            int number = Convert.ToInt32(Console.ReadLine());

            int odin = 1;
            Console.Write("{0} ", odin);
            int dva = 1;
            Console.Write("{0} ", dva);
            int sum = 0;
            while (number >= sum)
            {
                sum = odin + dva;
                if (number >= sum)
                    Console.Write("{0} ", sum);

                odin = dva;
                dva = sum;
            }
        }
    }
}
