using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            double a = rectangle.side1;
            double b = rectangle.side2;

            Program program = new Program();

            program.AreaCalculator(a, b);
            program.PerimeterCalculator(a, b);

            Console.ReadKey();
        }
        public double Area { get; }
        public double Perimeter { get; }

        public double AreaCalculator(double a,double b)
        {
            double Area = a * b;
            Console.WriteLine("Площадь = " + Area);

            return Area;
        }
        public double PerimeterCalculator(double a, double b)
        {
            double Perimeter = (a + b) * 2;
            Console.WriteLine("Периметр = " + Perimeter);

            return Perimeter;
        }
    }
    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public Rectangle()
        {
            Console.WriteLine("Ввод side1: ");
            side1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ввод side2: ");
            side2 = Double.Parse(Console.ReadLine());
        }
        
    }
}
