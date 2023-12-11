using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp2
{
    internal class Tel
    {
        public int Num_Of_Day { get; set; }
        public double Time { get; set; }
        public double Price { get; set; }
        public Tel() { }
        public Tel(int num, double time, double price)
        {
        Num_Of_Day = num;
            Time = time;
            Price = price;
        }
        public Tel(double price)
        {
           
            Price = price;
        }
        public void CountPrice()
        {
            double prc = Time * Price;
            if (Num_Of_Day > 0 && Num_Of_Day < 6)
            {
                Write($"Время разговора - {Time} минуты, цена минуты (в копейка) - {Price}, потрачено денег - {prc}");
            }
            else
            {
                Write($"Время разговора - {Time}, цена минуты (в копейках) - {Price}, потрачено денег(со скидкой 10% по выходным дням) - {prc * (100 - 10) / 100}");
            }
        }
        public void DayOfWeek()
        {
            Write("В какой день недели вы разговаривали? ");
            int day = int.Parse(ReadLine());
            Num_Of_Day = day;
        }
        public void TimeOfSpeeking()
        {
            Write("Сколько минут вы разговаривали ?  ");
            double time = double.Parse(ReadLine());
            Time = time;
        }

    }
}
