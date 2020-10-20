using System;

namespace Task
{
    class Child
    {
        private bool hungry = false;
        private bool play = false;
        private bool sleep = false;


        public void child_hungry()
        {
            if (hungry == true)
            {
                Console.WriteLine("The child isnt hungry");
            }
            else
            {
                Console.WriteLine("You've feed the child! Good job!");
                hungry = true;
            }
        }

        public void child_sleep()
        {
            if (sleep == true)
            {
                Console.WriteLine("The child dont wanna sleep");
            }
            else
            {
                Console.WriteLine("You put the child to bed.");
                sleep = true;
            }
        }


        public void child_play()
        {
            if (play == true)
            {
                Console.WriteLine("The child tired to play. He want to rest.");
            }
            else
            {
                Console.WriteLine("You are playing with the child.");
                play = true;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press W to feed the child");
            Console.WriteLine("Press A to put him to bed");
            Console.WriteLine("Press D to play with child");
            Console.WriteLine("Press S to close this app");

            Child child1 = new Child();

            string a = Console.ReadLine();

            while (a != "s")
            {
                if (a == "w")
                {
                    child1.child_hungry();
                }

                else if (a == "a")
                {
                    child1.child_sleep();
                }

                else if (a == "d")
                {
                    child1.child_play();
                }
                else
                {
                    Console.WriteLine("Ты промазал по клаве, давай еще раз");
                }
                a = Console.ReadLine();
            }
            Console.ReadKey();
        }

    }
    
}
