using System;

namespace ConsoleApp7
{
    class Employee
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string Employer(string firstname, string lastname)
        {
            Console.WriteLine("Имя:" + firstname);
            Console.WriteLine("Фамилия:" + lastname);
            return firstname;
        }
        public void oklad(string status)
        {
            int oklad;
            int persent;

            while (status == "Администратор")
            {
                Console.WriteLine("Должность:" + status);
                oklad = 10000;
                Console.WriteLine("Оклад:" + oklad);
                persent = oklad / 5;
                Console.WriteLine("Налог:" + persent);
            }
            while (status == "бухгалтер")
            {
                Console.WriteLine("Должность:" + status);
                oklad = 20000;
                Console.WriteLine("Оклад:" + oklad);
                persent = oklad / 5;
                Console.WriteLine("Налог:" + persent);
            }
            while (status == "менеджер по продажам")
            {
                Console.WriteLine("Должность:" + status);
                oklad = 40000;
                Console.WriteLine("Оклад:" + oklad);
                persent = oklad / 5;
                Console.WriteLine("Налог:" + persent);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employer = new Employee();

            Console.WriteLine("Имя:");
            string Firstname = Console.ReadLine();

            Console.WriteLine("Фамилия:");
            string Lastname = Console.ReadLine();

            Console.WriteLine("Выберите должность(Администратор, бухгалтер, менеджер по продажам):");
            string Status = Console.ReadLine();

            employer.Employer(Firstname, Lastname);
            Employee oklad = new Employee();
            oklad.oklad(Status);
        }
    }
    
}