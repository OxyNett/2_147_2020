using System;
class Program
{
    static void Main()
    {
        Console.Write("Vvedite chislo ");
        int a = int.Parse(Console.ReadLine());
        double a2 = a % 2;
        if (a2 == 0)
            Console.WriteLine("chislo chetnoe");
        else
            Console.WriteLine("chislo nechetnoe");
    }
}