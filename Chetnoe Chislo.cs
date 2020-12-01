using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число");
        int a = int.Parse(Console.ReadLine());
        double b = a % 2;
        if (b == 0)
            Console.WriteLine("Число - четноё");
        else
            Console.WriteLine("Число - нечётное");
    }
}
