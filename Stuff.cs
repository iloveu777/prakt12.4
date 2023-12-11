using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class Stuff
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int MinSalary { get; set; }
        public Stuff() { }
        public Stuff(string name, string surname ,int minSalary) 
        { 
            Name = name;
            Surname = surname;
            MinSalary = minSalary;
        }
        public void Income()
        {
            Write($"На сколько процентов повысить доход сотрудника {Name}? ");
            double percent = double.Parse(ReadLine());
            double income = MinSalary * (100 + percent) / 100;
            WriteLine($"Зарплата сотрудника {Name} повышена с {MinSalary} до {income}.");
        }
    }
}
