using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace date
{
        class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Введите дату рождения так хх.xx.xxxx (где х числа от 0 до 9 включительно)");
                string birthDate_string = Console.ReadLine();
                DateTime BirthDate = DateTime.Parse(birthDate_string);//меняем string на DateTime
                int year = DateTime.Now.Year - BirthDate.Year;
                int month = DateTime.Now.Month - BirthDate.Month;
                int day = Math.Abs(DateTime.Now.Day - BirthDate.Day);
                if (DateTime.Now.Month < BirthDate.Month)
                    year--;
                else if (month == 0 && DateTime.Now.Day < BirthDate.Day)
                { year--; month = 11; } // с годами

                if (BirthDate.Month > DateTime.Now.Month)
                {
                    month = 12 - Math.Abs(DateTime.Now.Month - BirthDate.Month);
                }
                if (DateTime.Now.Day >= BirthDate.Day)
                    day = 31 - day;

                if (DateTime.Now.Year < BirthDate.Year || (DateTime.Now.Year == BirthDate.Year && DateTime.Now.Month < BirthDate.Month)
                || (DateTime.Now.Year == BirthDate.Year && DateTime.Now.Month < BirthDate.Month && DateTime.Now.Day < BirthDate.Day)
                || BirthDate.Month > 12 || BirthDate.Day > 31)
                    Console.WriteLine("Ошибка при вводе");
                if (month < 0 || day < 0 || year < 0)
                    Console.WriteLine("Ошибка программа сработать не правильно, попробуйте написать другую дату рождения, ближайшую к вашей дате, и отталкиваясь от ответа можите сами посчитать :)");
                else
                    Console.WriteLine("Ваш возраст {0} лет {1} месяцев {2} дней", year, month, 31 - day);

            }
        }
    
}
