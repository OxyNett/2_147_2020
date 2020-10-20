using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.Write("Enter your value: ");
            value = Convert.ToInt32(Console.ReadLine());

            if (value % 2 == 0)
            {
                Console.WriteLine("The value is even");
            }
            else
            {
                Console.WriteLine("The value is odd");
            }

            Console.ReadKey();

        }
    }
}
