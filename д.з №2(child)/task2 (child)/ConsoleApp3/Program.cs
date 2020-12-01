using System;

namespace task2
{
    class child
    {
        private bool hungry = true;
        private bool play = true;
        private bool sleep = true;

        public child(bool hungry, bool play, bool sleep)
        {
            this.hungry = hungry;
            this.play = play;
            this.sleep = sleep;
        }


        public void kid_hungry()
        {
            if (!hungry)
            {
                Console.WriteLine("Ребёнок сыт");
            }
            else
            {
                Console.WriteLine("Ребёнок хотел есть. Вы его покормили");
                hungry = false;
            }
        }

        public void kid_sleep()
        {
            if (!sleep)
            {
                Console.WriteLine("Ребёнок не хочет спать");
            }
            else
            {
                Console.WriteLine("Ребёнок хотел спать. Вы уложили его спать");
                sleep = false;
            }
        }


        public void kid_play()
        {
            if (!play)
            {
                Console.WriteLine("Ребёнок не хочет играть");
            }
            else
            {
                Console.WriteLine("Ребёнок хотел играть. Вы поиграли с ним");
                play = false;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите H, чтобы покормить ребёнка");
            Console.WriteLine("Нажмите S, чтобы уложить ребёнка");
            Console.WriteLine("Нажмите P, чтобы поиграть с ребёнокм");
            Console.WriteLine("Нажмите E, чтобы закрыть это окно");

            child child1 = new child(true, false, false);

            string value = Console.ReadLine();

            while (value != "e")
            {
                if (value == "h")
                {
                    child1.kid_hungry();
                }

                else if (value == "s")
                {
                    child1.kid_sleep();
                }

                else if (value == "p")
                {
                    child1.kid_play();
                }
                else
                {
                    Console.WriteLine("Используете только те кнопки, что заявлены выше");
                }
                value = Console.ReadLine();
            }
            Console.ReadKey();
        }

    }

}

