using System;
using System.Runtime.InteropServices;

namespace FIbonachchi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int [n];
            a[0] = 1;
            a[1] = 1;
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            for (int i = 2; i < n; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
                if (a[i] > n) { break; }
                Console.WriteLine(a[i]);
            }
        }
    }
}
