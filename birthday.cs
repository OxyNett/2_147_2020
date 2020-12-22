using System; // Учитываем что в каждом месяце 31 день
using System.Runtime.InteropServices.WindowsRuntime;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату");
            string birthDate = Console.ReadLine();
            DateTime BirthDate = DateTime.Parse(birthDate);
            int year = DateTime.Now.Year - BirthDate.Year;
            int month = DateTime.Now.Month - BirthDate.Month;
            int day = DateTime.Now.Day - BirthDate.Day;
            if ((year==0) && (month==0) && (day==0)) {
                Console.WriteLine("ТЫ СЕГОДНЯ РОДИЛСЯ?");
            }
            else if ((year<0) || (year==0 && month<0) || (year==0 && month==0 && day<0)) {
                Console.WriteLine("ЧЕЛ, ТЫ ИЗ БУДУЩЕГО?");
            }
            else {
                if (month<0 && (day==0 || day>0)) {
                year--;
                month=12-BirthDate.Month+DateTime.Now.Month;
                }
                else if (month<0 && day<0) {
                year--;
                month=12-BirthDate.Month+DateTime.Now.Month-1;
                day=31-BirthDate.Day+DateTime.Now.Day;
                }
                else if (day<0 && month==0) {
                year--;
                month=11;
                day=31-BirthDate.Day+DateTime.Now.Day;
                }
                else if (day<0 && month>0) {
                month--;
                day=31-BirthDate.Day+DateTime.Now.Day;
                }
                Console.WriteLine("Тебе: ");
                Console.WriteLine(year, " лет, ");
                Console.WriteLine(month, " месяцев, ");
                Console.WriteLine(day, " дней.");
            }
        }
    }
