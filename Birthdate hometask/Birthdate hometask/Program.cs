using System;

namespace Birthdate_hometask
{

        class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Введите дату в формате dd.mm.yyyy");
                string birthDate = Console.ReadLine();
                DateTime BirthDate = DateTime.Parse(birthDate);
                int year = DateTime.Now.Year - BirthDate.Year;
                int month = 11 - BirthDate.Month + DateTime.Now.Month;
                int day = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - Math.Abs(DateTime.Now.Day - BirthDate.Day); ;
                if (year >= 0)
                {
                    if (DateTime.Now.Month < BirthDate.Month)
                    {
                        year--;
                    }
                    else if (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day)
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
                if (DateTime.Now.Year < BirthDate.Year || DateTime.Now.Year == BirthDate.Year && DateTime.Now.Month < BirthDate.Month || DateTime.Now.Year == BirthDate.Year && DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day)
                {
                    Console.WriteLine("Эта дата еще не наступила.");
                }
                {
                    if (DateTime.Now.Day == BirthDate.Day && DateTime.Now.Month == BirthDate.Month)
                    {
                        month = 0;
                        day = 0;
                        Console.WriteLine("Это сегодняшний день.");
                    }
                    Console.WriteLine("Полный возраст ");
                    Console.WriteLine("Лет: {0} Меясцев: {1} Дней: {2}", year, Math.Abs(11 - month), Math.Abs(30 - day));
                }
            }
        }
    }
