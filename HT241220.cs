using System;

namespace HT241220
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company)
            : base(name)
        {
            Company = company;
        }

        public override void Display()
        {
            Console.WriteLine($"{Name} работает в {Company}");
        }
    }
    class Duration : Employee
    {
        public int Year { get; set; }

        public Duration (string name, string company, int year)
              : base(name, company)
        {
            Year = year; 
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} работает в {Company} с {Year} года");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Володя");
            p1.Display(); 
            Employee p2 = new Employee("Леха", "Пятерочке");
            p2.Display();
            Duration p3 = new Duration("Маша", "Кремле", 1991);
            p3.Display();
            Person p11 = new Employee("Леха", "Пятерочке");
            p11.Display();
            Employee p12 = new Duration("Маша", "Кремле", 1991);
            p12.Display();
        }
    }
}