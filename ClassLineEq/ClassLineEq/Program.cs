using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLineEq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = Convert.ToDouble(Console.ReadLine());
            LineEquation lineEquation1 = new LineEquation();
            lineEquation1.getRatios(ref a, ref b);
            lineEquation1.printEquation();
            Console.WriteLine("x={0}", lineEquation1.getAnsw());
            Console.ReadKey();
        }
    }
}
