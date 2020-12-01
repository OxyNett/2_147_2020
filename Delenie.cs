using System;
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите a ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b ");
            b = Convert.ToDouble(Console.ReadLine());
            new hole(a, b).resh();
        }
    }
    class hole
    {
        private double a;
        private double b;
        private double c;
        public hole(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public void resh()
        {
            c = b / a;
            if (a != 0)
            {
                Console.WriteLine("{0}", c);
            }
            if (a == 0)
            {
                Console.WriteLine("Корней НЕМА");
            }
        }
    }
