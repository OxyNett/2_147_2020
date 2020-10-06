using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int Num = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            int second = 1;
            int x = 0;
            while (x <= Num)
            {
                Console.WriteLine(x);
                first = second;
                second = x;
                x = first + second;
            }
            Console.ReadKey();
        }
    }
}
