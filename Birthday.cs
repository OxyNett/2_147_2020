using System;
using System.Runtime.InteropServices.WindowsRuntime;

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
            int month = DateTime.Now.Month - BirthDate.Month;
            int day = Math.Abs(DateTime.Now.Day - BirthDate.Day);
            if (DateTime.Now.Year == BirthDate.Year && DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day == BirthDate.Day)
            {
                Console.WriteLine("eto segodnya");
            }
            if (DateTime.Now.Month < BirthDate.Month)
                year--;
            else if (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day)
            {
                year--;
                month = 11;
            }
            if (BirthDate.Month>DateTime.Now.Month)
            {
                month = 12-Math.Abs(DateTime.Now.Month - BirthDate.Month);
                if (DateTime.Now.Day < BirthDate.Day)
                    month--;
            }
            if (BirthDate.Month < DateTime.Now.Month && DateTime.Now.Day < BirthDate.Day)
                month--;
            if (DateTime.Now.Day >= BirthDate.Day)
            day = 30 - day;
            if (DateTime.Now.Year < BirthDate.Year || DateTime.Now.Year == BirthDate.Year && DateTime.Now.Month < BirthDate.Month || DateTime.Now.Year == BirthDate.Year && DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day)
            {
                Console.WriteLine("Эта дата еще не наступила.");
            }
            else
            {
                Console.WriteLine("Полный возраст: ");
                Console.WriteLine(year);
                Console.WriteLine(month);
                Console.WriteLine(30 - day);
            }
        }
    }
}