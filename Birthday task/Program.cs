using System;

namespace Birthday_task
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату в формате день.месяц.год в числах");
            string birthdaydate = Console.ReadLine();
            DateTime BirthdayDate = DateTime.Parse(birthdaydate);
            int age = DateTime.Now.Year - BirthdayDate.Year;
            if (age >= 0)
            {
                if (DateTime.Now.Month < BirthdayDate.Month)
                {
                    age--;
                    if (age >= 0)
                    {
                        Console.WriteLine(age);
                    }
                    else
                    {
                        Console.WriteLine("Этот день ещё не наступил.");
                    }
                }
                else if (DateTime.Now.Month == BirthdayDate.Month && DateTime.Now.Day < BirthdayDate.Day)
                {
                    if (age >= 0)
                    {
                        Console.WriteLine(age);
                    }
                    else
                    {
                        Console.WriteLine("Этот день ещё не наступил.");
                    }
                }
                else if (DateTime.Now.Year == BirthdayDate.Year && DateTime.Now.Month == BirthdayDate.Month && DateTime.Now.Day == BirthdayDate.Day)
                {
                    Console.WriteLine("Этот день сегодня.");
                }

            }
            else
            {
                Console.WriteLine("Этот день ещё не наступил.");
            }
        }
    }
}