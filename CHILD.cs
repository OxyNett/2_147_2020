using System;

namespace Task
{
      class Rebenok
    {
        private bool golodniy = true;
        private bool wannaplay = true;
        private bool ineedsomesleep = true;
        public string e;
        public Rebenok(bool golodniy , bool wannaplay, bool ineedsomesleep)
        { this.golodniy = golodniy;
            this.wannaplay = true;
            this.ineedsomesleep = true;
        }

        public void pokormit()
        {
            if (golodniy == true)
            {
                Console.WriteLine("Rebenok xochet edi, pokormit?(Y/N)");
                string q = Console.ReadLine();
                if (q == "y")
                {
                    Console.WriteLine("You give some food to Rebenok.");
                    golodniy = false;
                }
                if (q == "n")
                {
                    Console.WriteLine("Rebenok ne poel, proizoshla death ot goloda.");
                    Console.WriteLine("Play again?(Y/N)");
                    e = Console.ReadLine();
                    if (e == "y")
                    {
                        Console.Clear();
                        golodniy = true;
                        wannaplay = true;
                        ineedsomesleep = true;
                        Console.WriteLine("Press 1 chtobi proverit' sostoyanie goloda of the child");
                        Console.WriteLine("Press 2 chtobi uznat', ne xochet li on play");
                        Console.WriteLine("Press 3 chtobi uznat', ne xochet li on some sleep");
                        Console.WriteLine("Press S to close this app");
                        string a = Console.ReadLine();


                    }
                    if (e == "n")
                    {
                        return;
                    }

                }


            }
            else
            {
                Console.WriteLine("Rebenok ne goloden, on nedavno poel, podojdat' poka on progladaetsya?(y/n)");
                e = Console.ReadLine();
                if (e == "y")
                {
                    golodniy = true;
                }
                if (e == "n")
                {
                    Console.WriteLine("vozmojno ti hochesh proverit' odno iz drugix sostoyaniy rebenka?");
                }


            }
        }

        public void poigrat()
        {
            if (wannaplay == true)
            {
                Console.WriteLine("Rebenok xochet igat'. Poigrat' s rebenkom?(Y/N)");
                string q = Console.ReadLine();
                if (q == "y")
                {
                    Console.WriteLine("ti poigral s rebenkom.");
                    wannaplay = false;
                }
                if (q == "n")
                {
                    Console.WriteLine("Rebenok poshel iskat' s kem bi emu poigrat' i ne vernulsya.");
                    Console.WriteLine("Play again?(Y/N)");
                    e = Console.ReadLine();
                    if (e == "y")
                    {
                        Console.Clear();
                        golodniy = true;
                        wannaplay = true;
                        ineedsomesleep = true;
                        Console.WriteLine("Press 1 chtobi proverit' sostoyanie goloda of the child");
                        Console.WriteLine("Press 2 chtobi uznat', ne xochet li on play");
                        Console.WriteLine("Press 3 chtobi uznat', ne xochet li on some sleep");
                        Console.WriteLine("Press S to close this app");
                        string a = Console.ReadLine();


                    }
                    if (e == "n")
                    {
                        return;
                    }

                }


            }
            else
            {
                Console.WriteLine("Rebenok ne hochet igrat', on uje dostatochno poigral segodnya, podojdat' poka on zaxochet igrat'(y/n)?");
                e = Console.ReadLine();
                if (e == "y")
                {
                    wannaplay = true;
                }
                if (e == "n")
                {
                    Console.WriteLine("vozmojno ti hochesh proverit' odno iz drugix sostoyaniy rebenka?");
                }

            }
        }


        public void ulojit_spat()
        {
            if (ineedsomesleep == true)
            {
                Console.WriteLine("Rebenok said, \"i need some sleep, you cant go like this. \" ulojit rebenka spat'?(Y/N)"); ;
                string q = Console.ReadLine();
                if (q == "y")
                {
                    Console.WriteLine("ti ulojil rebenka spat'.");
                    ineedsomesleep = false;
                }
                if (q == "n")
                {
                    Console.WriteLine("Rebenok vse ravno usnul.");
                    Console.WriteLine("Rebenok prosnulsya(y/n)");
                    e = Console.ReadLine();
                    if (e == "y")
                    {
                        Console.Clear();
                        golodniy = true;
                        wannaplay = true;
                        ineedsomesleep = true;
                        Console.WriteLine("Press 1 chtobi proverit' sostoyanie goloda of the child");
                        Console.WriteLine("Press 2 chtobi uznat', ne xochet li on play");
                        Console.WriteLine("Press 3 chtobi uznat', ne xochet li on some sleep");
                        Console.WriteLine("Press S to close this app");
                        string a = Console.ReadLine();


                    }
                    if (e == "n")
                    {
                        return;
                    }

                }


            }
            else
            {
                Console.WriteLine("Rebenok ne hochet spat");
                ineedsomesleep = false;
                Console.WriteLine("vozmojno ti hochesh proverit' odno iz drugix sostoyaniy rebenka?");
            }
        }




        class Program
        {

            static void Main(string[] args)

            {
                
                    Console.WriteLine("Press 1 chtobi proverit' sostoyanie goloda of the child");
                    Console.WriteLine("Press 2 chtobi uznat', ne xochet li on play");
                    Console.WriteLine("Press 3 chtobi uznat', ne xochet li on some sleep");
                    Console.WriteLine("Press S to close this app");

                    Rebenok Rebenok1 = new Rebenok(true, false, false);

                    string a = Console.ReadLine();

                    while (a != "s")
                    {
                        if (a == "1")
                        {
                            Rebenok1.pokormit();
                        }

                        else if (a == "2")
                        {
                            Rebenok1.poigrat();
                        }
                        else if (a == "3")
                        {
                            Rebenok1.ulojit_spat();
                        }
                        else
                        {
                            Console.WriteLine("Это на каком языке ?");
                        }
                        a = Console.ReadLine();
                    }
                    Console.ReadKey();
                } 
            }

            
        }

    }
