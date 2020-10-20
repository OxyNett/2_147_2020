using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Class_Kid
{
    class Kid
    {
        public int hungry;
        public int want_play;
        public int want_sleep;
        public string Feed ()
        {
            if (hungry == 1) { return  "Попроси кого-нибудь тебя накормить"; }
            if (hungry == 0) { return  "Не хочешь, как хочешь"; }
            return "Cледующий вопрос";
        }
        public string Playing()
        {
            if (want_play == 1) { return  "Попроси кого-нибудь с тобой поиграть"; }
            if (want_play == 0) { return  "Нет, так нет"; }           
            return "Следующий вопрос";
        }
        public string Sleeping()
        {
            if (want_sleep == 1) { return  "Попроси кого-нибудь тебя уложить спатеньки"; }
            if (want_sleep == 0) {  }
            return "Допрос окончен, можете покинуть помещение";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kid mKid = new Kid();
            Console.WriteLine("Ребенок, ты хочешь кушать? (Yes/No)");
            string ans1 = Console.ReadLine();
            if (ans1 == "Yes"){ mKid.hungry = 1; }
            if (mKid.hungry == 1) 
            {
                Thread.Sleep(500); 
                Console.WriteLine(mKid.Feed()); 
            }
            if (ans1 == "No") { mKid.hungry = 0; }
            if (mKid.hungry == 0) 
            {
                Thread.Sleep(500);
                Console.WriteLine(mKid.Feed());
            }
            Thread.Sleep(500);
            Console.WriteLine("Ребенок, ты хочешь играть? (Yes/No)");
            string ans2 = Console.ReadLine();
            if (ans2 == "Yes") { mKid.want_play = 1; }
            if (mKid.want_play == 1) 
            {
                Thread.Sleep(500); 
                Console.WriteLine(mKid.Playing());
            }
            if (ans2 == "No") { mKid.want_play = 0; }
            if (mKid.want_play == 0) 
            {
                Thread.Sleep(500); 
                Console.WriteLine(mKid.Playing());
            }
            Thread.Sleep(500);
            Console.WriteLine("Ребенок, ты хочешь спать? (Yes/No)");
            string ans3 = Console.ReadLine();
            if (ans3 == "Yes") { mKid.want_sleep = 1; }
            if (mKid.want_sleep == 1) 
            {
                Thread.Sleep(500); 
                Console.WriteLine(mKid.Sleeping());
            }
            if (ans3 == "No") { mKid.want_sleep = 0; }
            if (mKid.want_sleep == 0)
            { 
                Thread.Sleep(500); 
                Console.WriteLine(mKid.Sleeping());
            }
        }
    }
}
