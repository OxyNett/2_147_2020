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
            if (!hungry) { Console.WriteLine("Ребенок хочет есть, нужно покормить его"); }
            else { Console.WriteLine("Вы накормили ребенка!"); }
            hungry = true;
        }
        public void Playing()
        {
            if (!want_play) { Console.WriteLine("Ребенок хочет играть, нужно поиграть с ним"); }
            else { Console.WriteLine("Вы поиграли с ребенком!"); }
            want_play = true;
        }
        public void Sleeping()
        {
            if (!want_sleep) { Console.WriteLine("Ребенок хочет спать, нужно уложить его спать"); }
            else { Console.WriteLine("Вы уложили ребенка спать!"); }
            want_sleep = true;
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
