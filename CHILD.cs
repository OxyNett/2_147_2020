using System;
class Child {
        private bool hungry = true;
        private bool cry= true;
        private bool sleep = true;
        public Child(bool hungry, bool cry, bool sleep) {
            this.hungry = hungry;
            this.cry = cry;
            this.sleep = sleep;
        }
        public void Nakormit() {
            if (hungry == true) {
                Console.WriteLine("Ребёнок хочет есть. Дать ему еды?(y/n)");
                string s = Console.ReadLine();
                if (s == "y") {
                    Console.WriteLine("Ребёнок лопнул. Ну зато не голодный.\nWASTED");
                    hungry = false;
                    Environment.Exit(0);
                }
                if (s == "n") {
                    Console.WriteLine("НУ И ПУСТЬ ГОЛОДАЕТ");
                }
            }
            if (hungry == false) {
                Console.WriteLine("Ребёнок не хочет есть");
            }
        }
        public void Playing() {
            if (cry == true) {
                Console.WriteLine("Ребёнок плачет. Дать ему игрушку?(y/n)");
                string s = Console.ReadLine();
                if (s == "y") {
                    Console.WriteLine("Ребёнок проглотил её и умер. Ну зато повеселился. \nWASTED");
                    cry = false;
                    Environment.Exit(0);
                }
                if (s == "n") {
                    Console.WriteLine("НУ И ПУСТЬ ДАЛЬШЕ НОЕТ");
                }
            }
            if (cry == false) {
                Console.WriteLine("Ребёк не плачет. Странно...");
            }
        }
        public void Idipospi() {
            if (sleep == true) {
                Console.WriteLine("Ребёнок хочет спать. Уложить его в кровать?(y/n)");
                string s = Console.ReadLine();
                if (s == "y") {
                    Console.WriteLine("Ребёнок настолько сладко спал, что впал в кому и умер.\nWASTED");
                    sleep = false;
                    Environment.Exit(0);
                }
                if (s == "n") {
                    Console.WriteLine("ТЫ ДОСТАТОЧНО ЖЕСТОК \nCongratulations! You won!");
                    Environment.Exit(0);
                }
            }
            if (hungry == false) {
                Console.WriteLine("Ребёнок не хочет спать");
            }
        }
    }
class MOR {
    static void Main(string[] args)
        {
            Console.WriteLine("Нажми w чтобы проведать ребенка");
            Console.WriteLine("Нажми s чтобы никуда не ходить");
            Child child1 = new Child(true, true, true);
            string a = Console.ReadLine();
                if (a == "w")
                {
                    child1.Nakormit();
                    child1.Playing();
                    child1.Idipospi();
                }
                else if (a == "s")
                {
                    Console.WriteLine("ТЫ ДОСТАТОЧНО ЖЕСТОК \nCongratulations! You won!");
                }
                else
                {
                    Console.WriteLine("Сейчас бы по кнопке не попасть...");
                    Main(args);
                }
            Console.ReadKey();
        }
}
  





