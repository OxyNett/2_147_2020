using System;

namespace S0311A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your date ");
            string date = Console.ReadLine();
            DateTime today = DateTime.Today;
            DateTime enterdate = DateTime.Parse(date);
            TimeSpan difference = today - enterdate;

            int result = Convert.ToInt32(difference.Days.ToString());
            int years = result / 365;
            int month = (result % 365) / 30;
            int days = result % 30;

            if (years > 4) // для високосных
            {
                days += (years / 4);
            }
            Console.WriteLine("{0} years, {1} month, {2} days", years, month, days);
            Console.Read();
        }
    }
}