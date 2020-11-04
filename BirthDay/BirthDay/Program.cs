using System;

namespace BirthDay
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату в формате xx.xx.xxxx");
            string birthDate = Console.ReadLine();
            DateTime BirthDate = DateTime.Parse(birthDate);
            int year = DateTime.Now.Year - BirthDate.Year;
            int month = 12 - BirthDate.Month + DateTime.Now.Month;
            int day = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - Math.Abs(DateTime.Now.Day - BirthDate.Day); ;
            if (year >= 0)
            {
                if (DateTime.Now.Month < BirthDate.Month)
                {
                    year--;
                }
                else if ((DateTime.Now.Month == BirthDate.Month) && (DateTime.Now.Day < BirthDate.Day))
                {
                    year--;
                }

            }
            if (month >= 0)
            {
                if (DateTime.Now.Day < BirthDate.Day)
                {
                    month--;
                }
            }
            if ((year < 0) || (month < 0))
            {
                Console.WriteLine("Эта дата еще не наступила.");
                return;
            }
            if (day >= 0)
            {
                Console.WriteLine("Полный возраст: ");
                if ((DateTime.Now.Day == BirthDate.Day) && (DateTime.Now.Month == BirthDate.Month))
                {
                    day = 0;
                    month = 0;
                    Console.WriteLine("С ДНЕМ РОЖДЕНИЯ !!!!!!!!");
                }
                Console.WriteLine("Лет: " + year + " Месяцев: " + month + " Дней: " + day + " ");
            }
        }
    }       
}