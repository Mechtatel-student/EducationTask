using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateArray
{
    class Program
    {



        /// <summary>
        /// /// 5)
        ///  Существует массив строк формата: "07.07.2014 10:00-13:25,14:30-17:00" или например
        ///    "01.07.2014 10:30-13:25,14:30-17:00,18:30-19:00" или
        ///    "02.07.2014"
        ///    (можно задать его прямо в программе, напишите не меньше 10 строк)
        ///    При этом дата в каждой строке только одна, отделяется пробелом, а числа представляют 
        ///    собой диапазоны времени (промежутки рабочего времени). Предполагается, 
        ///    что внутри одной строки временные значения всегда должны возрастать слева направо.
        ///    Пользователь задаёт диапазон дат, вводит с клавиатуры.
        ///    Подсчитать общее количество рабочего времени в этом диапазоне, 
        ///    с точностью до минут (не округляя вверх), основываясь на данных из массива строк.
        /// </summary>


        static void Main(string[] args)
        {
            string st = "07.07.2014     10:00-13:25, 14:30-17:00";
            DateTime dt = new DateTime();
            StringSplitOptions opt = StringSplitOptions.None;
            //string[] s = st.Split(' ', opt);
            //foreach (string el in s)
             //   Console.WriteLine(el + ",");
            //UseDatesAndTimes();

            DateTime dt1 = new DateTime(2014, 01, 10, 10, 5, 0);
            DateTime dt2 = new DateTime(2015, 01, 10, 10, 10, 0);
            DateTime dt3 = new DateTime(2015, 01, 10, 9, 5, 0);
            TimeSpan tm1= dt2-dt1;
            TimeSpan tm2 = dt3 - dt1;

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(tm1.Days);
            Console.WriteLine(tm2);
            Console.ReadKey();

        }

        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times:");
            // Этот конструктор принимает год, месяц и день.
            DateTime dt = new DateTime(2011, 10, 17);
            // Какой это день месяца?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            // Сейчас месяц декабрь.
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            // Этот конструктор принимает часы, минуты и секунды.
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            // Вычесть 15 минут иэ текущего TimeSpan и вывести результат.
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
            Console.ReadKey();
        }



    }
}