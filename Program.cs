using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Figures fig1 = new Figures();
             fig1.Name = "Fig 1";
             fig1.Side1 = 5;
             fig1.Side2 = 7;
             fig1.ShowInfo();
             Figures fig2 = new Figures("Fig 2", 8 ,8);
             fig2.ShowInfo();

             Figures fig3 = new Figures();
             fig3.InputName();
             fig3.InputSides3();
             fig3.ShowInfo();*/
            /*
            Stuff s1 = new Stuff("Иван","Иванов", 10000);
             s1.Income();
             */
            /*
            Tel tel1 = new Tel(0.5);
             tel1.DayOfWeek();
             tel1.TimeOfSpeeking();
             tel1.CountPrice();*/
            Company c1= new Company("asd", 150, 1000000);
            c1.Print();
            c1.AvgSal();
            c1.Tax(4);
            c1.MaxStuff(15000);
            ReadKey();
        }
    }
}
