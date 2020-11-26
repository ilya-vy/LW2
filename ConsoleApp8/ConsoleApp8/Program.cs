using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            invoice.CalculateAndShowAccount();

            Console.ReadKey();
        }
    }
    class Invoice
    {
        int account = 1;
        string customer = "Arctic inc.";
        string provider = "Jing Electro";

        private string article = "Intel Xeon E5 2699V4";
        private int quantity = 201;

        private int moprice = 29;
        public void CalculateAndShowAccount()
        {
            int pwitht = (quantity * moprice) + (quantity * account);
            int pwithoutt = (quantity * moprice);
            Console.WriteLine("Заказчик: " + customer + "\nПоставщик: " + provider + "\nСумма за заказанный товар " + article + "\nБЕЗ НДС: " + pwithoutt + "$" + "\nC НДС: " + pwitht + "$");
        }
    }
}
