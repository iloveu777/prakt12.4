using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp2
{
    internal class Company
    {
        public string Name { get; set; }
        public int Stuff { get; set; }
        public int Salary { get; set; }
        public Company() { }
        public Company(string name, int stuff, int salary) 
        { 
        Name = name;
            Stuff = stuff;
            Salary = salary;

        }
        public void Print()
        {
            WriteLine($"Имя компании: {Name}, кол-во сотрудников: {Stuff}, фонд з/п: {Salary}.");
        }
        public void AvgSal()
        {
            WriteLine($"средняя зп среди всех сотрудников: {Salary / Stuff}.");
        }
        public void MaxStuff(int z)
        {
            int avgstuff = Salary / z;
            WriteLine($"Максимальное кол-во сотрудников при сред. з/п ({z}) - {avgstuff} ");
            
        }
        public void Tax(int a)
        {
            int ot = Salary * (100 - a) / 100;
            WriteLine($"Сумма после вычета в пенс. фонд: {ot}. Сумма отчисления - {Salary - ot} ");
        }
    }
}
