using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp2
{
    internal class Figures
    {
        public string Name { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Figures() { }
        public Figures(string name, double side1, double side2) 
        {
            Name = name;
            Side1 = side1;
            Side2 = side2;
        }
        public Figures(string name, double side1, double side2, double side3)
        {
            Name = name;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;  
        }
        public void InputName()
        {
            WriteLine("Введите имя фигуры: ");
            string name = ReadLine();
            Name = name;

        }
        public void InputSides3()
        {
            
            Write("Введите первую сторону: ");
            double a = double.Parse(ReadLine());
            Write("Введите вторую сторону: ");
            double b = double.Parse(ReadLine());
            Write("Введите третью сторону: ");
            double c = double.Parse(ReadLine());
            Side1 = a;
            Side2 = b;
            Side3 = c;
        }
        public void ShowInfo()
        {
            if (Side1 > 0 && Side2 > 0 && Side3 == 0)
            {
                WriteLine($"Имя фигуры - {Name}, сторона 1 - {Side1}, сторона 2 - {Side2} ");
            }
            else
            {
                WriteLine($"Имя треугольника - {Name}, сторона 1 - {Side1}, сторона 2 - {Side2}, сторона 3 - {Side3} ");
            }

        }
    }
}
