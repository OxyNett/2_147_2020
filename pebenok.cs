using _4;
using System;

namespace _4
{
    class Pebenok
    {
        //private
            public bool satiety;
        public void full ()
                {
                satiety = true;
                }
        /*public void hungry()
        {
                satiety = false;
        }*/
        //private 
            public bool game;
        public void played()
        {
        game = true;
        }
        /*public void noplay()
        {
        game = false;
        }*/
        //private 
           public bool sleep;
        public void wontsleep()
        {
        sleep = true;
        }
        /*public void nosleep()
        {
        sleep = false;
        }*/

    }
class Program
    {
        static void Main(string[] args)
        {
        Pebenok yyy = new Pebenok();
            
            Console.Write("Введите состояния ребенка: ");
            string satiety1 = Console.ReadLine();
            string game1 = Console.ReadLine();
            string sleep1 = Console.ReadLine();


            
            if (satiety1=="сыт") { Console.Write("ребенок сыт"); }
            else { Console.Write("кормим ребенка"); yyy.full(); }
            //Console.Write("ребенок {0}", yyy.satiety);

            if (game1 == "не хочу играть") { Console.Write("ребенок не хочет играть "); }
            else { Console.Write("поиграть с ребенком"); yyy.played(); }

            if (sleep1 == "не хочет спать") { Console.Write("ребенок не хочет спать "); }
            else { Console.Write("ребенка надо уложить поспать "); yyy.wontsleep(); }



            Console.ReadLine();
        }
    }
}
