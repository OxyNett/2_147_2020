using System;
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 1;
            int sum = 0;
            Console.WriteLine("Введи число");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} {1} ", first, second);
            while (num >= sum)
            {
                sum = first + second;
                if (num >= sum)
                    Console.Write("{0} ", sum);
                first = second;
                second = sum;
            }
        }
    }