using System;

namespace Task4
{
    public class Kid
    {
        private bool full;
        private bool sleep;
        private bool play;
        
        public void StatusFalse()
        {
            play = false;
            sleep = false;
            full = false;
        }
        public void KidStatus()
        {
            if (play == false)
            {
                Console.WriteLine("Ребёнок хочет играть!");
                play = true;
                Console.WriteLine("Играем с ребёнком . . .");
            }
            else
            {
                Console.WriteLine("Ребёнок уже поиграл.");
            }
            if (sleep == false)
            {
                Console.WriteLine("Ребёнок хочет спать!");
                sleep = true;
                Console.WriteLine("Укладываем спать ребёнка . . .");
            }
            else
            {
                Console.WriteLine("Ребёнок не хочет спать.");
            }
            if (full == false)
            {
                Console.WriteLine("Ребёнок хочет есть!");
                full = true;
                Console.WriteLine("Кормим ребёнка . . .");
            }
            else
            {
                Console.WriteLine("Ребёнок не хочет есть.");
            }
            if (full == true && sleep == true && play == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ребёнок доволен!!!");
            }
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kid Kid1 = new Kid();
            Kid1.StatusFalse();
            Kid1.KidStatus();
            Console.ReadKey();
        }
    }
}
