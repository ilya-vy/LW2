using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(27.77, 32.99, 0.3828);
        }
    }
    class Converter
    {
        public double usd { get; set; }
        public double eur { get; set; }
        public double rub { get; set; }
        public Converter(double usd, double eur, double rub) : base()
        {
            double ans;
            Console.WriteLine("Введите валюту в которую конвертируете(eur,usd,rub,uah)");
            string con = Console.ReadLine();
            if (con == "UAH")
            {
                Console.WriteLine("Введите количество");
                double num1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите целевую валюту USD\EUR\RUB?");
                string ConvettoUAH = Console.ReadLine();
                if (ConvettoUAH == "USD")
                {
                    ans = usd / num1;
                    Console.WriteLine(ans);
                }
                if (con == "EUR")
                {
                    ans = eur / num1;
                    Console.WriteLine(ans);
                }
                if (con == "RUB")
                {
                    ans = rub / num1;
                    Console.WriteLine(ans);
                }
            }
            if (con == "USD")
            {
                Console.WriteLine("Введите количество");
                double num = Double.Parse(Console.ReadLine());
                ans = num / usd;
                Console.WriteLine(ans);
            }
            if (con == "EUR")
            {
                Console.WriteLine("Введите количество");
                double num = Double.Parse(Console.ReadLine());
                ans = num / eur;
                Console.WriteLine(ans);
            }
            if (con == "RUB")
            {
                Console.WriteLine("Введите количество");
                double num = Double.Parse(Console.ReadLine());
                ans = num / rub;
                Console.WriteLine(ans);
            }
        }
    }
}