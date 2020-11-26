using System;

namespace LW_1
{
    class Address
    {
        public string index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string house { get; set; }
        public string appartment { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Address address = new Address();

            address.index = "09184";
            address.country = "Kyiv";
            address.city = "Ukraine";
            address.street = "Shlyapska";
            address.house = "24";
            address.appartment = "53";

            Console.WriteLine("Address: {0} {1} {2} {3} {4} {5}", address.index, address.country, address.city, address.street, address.house, address.appartment);
        }
    }
}
