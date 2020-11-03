using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Class_Kid
{
    class Kid
    {
        private bool hungry = false;
        private bool want_play = false;
        private bool want_sleep = false;
        public Kid (bool hungry, bool want_play, bool want_sleep)
        {
            this.hungry = hungry;
            this.want_play = want_play;
            this.want_sleep = want_sleep;
        }
        public void Feed ()
        {
            if (!hungry) { Console.WriteLine("Ребенок не хочет есть"); }
            else { Console.WriteLine("Вы накормили ребенка!"); }
            hungry = false;
        }
        public void Playing()
        {
            if (!want_play) { Console.WriteLine("Ребенок не хочет играть"); }
            else { Console.WriteLine("Вы поиграли с ребенком!"); }
            want_play = false;
        }
        public void Sleeping()
        {
            if (!want_sleep) { Console.WriteLine("Ребенок не хочет спать"); }
            else { Console.WriteLine("Вы уложили ребенка спать!"); }
            want_sleep = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kid mKid = new Kid(true, false, false);

            Console.WriteLine("Чтобы покормить ребенка, нажми F");
            Console.WriteLine("Чтобы поиграть с ребенком, нажми P");
            Console.WriteLine("Чтобы уложить ребенка спать, нажми S");
            Console.WriteLine("Чтобы закончить , нажми E");

            string reshenie = Console.ReadLine();
            while (reshenie != "E")
            {
                if (reshenie == "F")
                {
                    mKid.Feed();
                }

                else if (reshenie == "P")
                {
                    mKid.Playing();
                }

                else if (reshenie == "S")
                {
                    mKid.Sleeping();
                }
                reshenie = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
