using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine("{0} is even", Num);
            }
            else
            {
                Console.WriteLine("{0} is odd", Num);
            }
            Console.ReadKey();
        }
    }
}
