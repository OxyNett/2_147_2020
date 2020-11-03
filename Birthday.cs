using System;

namespace Denrojdeniya
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату в формате xx.xx.xxxx");
            string birthDate = Console.ReadLine();
            DateTime BirthDate = DateTime.Parse(birthDate);
            int age = DateTime.Now.Year - BirthDate.Year;
            if (age >= 0)
            {
                if (DateTime.Now.Month < BirthDate.Month)
                {
                    age--;
                    if (age >= 0)
                    {
                        Console.WriteLine(age);
                    }
                    else { Console.WriteLine("Эта дата еще не наступила."); }
                }
                else if (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day)
                {
                    if (age >= 0)
                    {
                        Console.WriteLine(age);
                    }
                    else { Console.WriteLine("Эта дата еще не наступила."); }
                }
                else if (DateTime.Now.Year == BirthDate.Year && DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day == BirthDate.Day)
                {
                    Console.WriteLine("eto je segodnya");
                }

            }
            else
            {
                Console.WriteLine("Эта дата еще не наступила.");
            }
        }
    }
}
