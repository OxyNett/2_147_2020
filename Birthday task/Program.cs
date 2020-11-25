using System;

namespace Birthday_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату в формате XX.XX.XXXX");
            string birthdate = Console.ReadLine();
            DateTime BirthDate = DateTime.Parse(birthdate);
            int year = DateTime.Now.Year - BirthDate.Year;
            int month = 12 - BirthDate.Month + DateTime.Now.Month;
            int day = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - Math.Abs(BirthDate.Day-DateTime.Now.Day);
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
            }
            if (day >= 0)
            {
                Console.WriteLine("Возраст: {0}", year);
                Console.WriteLine("Лет: {0}  Месяцев: {1}  Дней: {2}", year, Math.Abs(12-month), day);
            }
        }
    }
}