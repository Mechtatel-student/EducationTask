using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        struct Student
        {
            public string FIO;
            public DateTime dtOfBirth;
            public DateTime dtEnterUniv;
            public bool isLiveHall;
            public int average;
            public int grant;
        }

        static   void Main(string[] args)
        {
            
            Student[] st =new Student[3];
               st[0]=GetStudent();
               st[1] = GetStudent();
               st[2] = GetStudent();
               //st[1] = new Student();
               PrintStudent(st);
             Console.ReadKey();
            DateTime cur = new DateTime();
           
            cur = DateTime.Today;
            TimeSpan age = cur - st[0].dtEnterUniv;
            //  Console.WriteLine(cur.ToShortDateString());
            //  Console.WriteLine(age.);
            Console.ReadKey();
            DateTime date1 = new DateTime(15, 1, 10, 10, 5, 3);

            DateTime date2 = new DateTime(14, 1, 9, 5, 5, 5);
            DateTime date3 = new DateTime(14, 1, 10, 9, 5, 3);


        }
        static Student GetStudent(bool date=false)
        {
            Student st= new Student();
            Console.WriteLine("Enter FIO of student");
            st.FIO = Console.ReadLine();
            if (date)
            {
                Console.WriteLine("Enter date of birth of student");
                Console.Write("Year = ");
                int year = IsIntegerDiapason("Year >= 1900, Year <=" + Convert.ToInt32(DateTime.Now.Year) + "\n\r Year = "
                    , 1900, DateTime.Now.Year);
                Console.Write("Month = ");
                int month = IsIntegerDiapason("Month >= 1, Month <= 12 \n\r Month =  ", 1, 12);

                Console.Write("Day = ");
                int day = IsIntegerDiapason("Day >= 1, Day  <= 31 \n\r Month =  ", 1, 31);
                Console.WriteLine("Enter time of birth of student");
                st.dtOfBirth = new DateTime(year, month, day);
                Console.WriteLine("Enter date of enter to university of student");
                Console.Write("Year = ");
                year = IsIntegerDiapason("Year >= 1900, Year <=" + Convert.ToInt32(DateTime.Now.Year) + "\n\r Year = "
                   , 1900, DateTime.Now.Year);
                Console.Write("Month = ");
                month = IsIntegerDiapason("Month >= 1, Month <= 12 \n\r Month =  ", 1, 12);

                Console.Write("Day = ");
                day = IsIntegerDiapason("Day >= 1, Day  <= 31 \n\r Month =  ", 1, 31);

                st.dtEnterUniv = new DateTime(year, month, day);
                day = IsIntegerDiapason("Day >= 1, Day  <= 31 \n\r Month =  ", 1, 31);
            }
             Console.Write("Student live in hall ?  Enter Y/N,  or  1/0    0=no, 1=yes.");
            st.isLiveHall = IsYNOr01();
            Console.Write("Average ball = ");
            st.average = IsIntegerDiapason("Enter natural number or 0 , Average ball >= 0, Average ball <=100:\r\n Average ball =  ",
                                                        0, 100);
            Console.Write("Grant = ");
            st.grant = IsIntegerDiapason("Enter natural number or 0, Grant >= 0:\r\n Grant =  ",0);
            return st;
        }

        /// <summary>
        ///  Ввод целого числа в заданном диапазоне.
        /// </summary>
        /// <param name="message">Сообщение, которое выдается, если пользователь ввёл неверные данные </param>
        /// <returns></returns>

        static int IsIntegerDiapason(string message = "Enter integer number:\r\n", int a = int.MinValue, int b = int.MaxValue)
        {
            int t;
            while (!int.TryParse(Console.ReadLine(), out t) || t < a || t > b)
                Console.Write(message);
            return t;
        }
        /// <summary>
        /// Получение ответа на вопрос в виде значения логического типа, 
        /// функция запрашивает с клавиатуры ввести символы y,n или 0,1
        /// и возвращает значение истина для y и 1 и ложь для n и 0.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static bool IsYNOr01(string message = "Enter one of the symbols y/n, 0/1:\r\n")
        {
            bool b = true;
            string s = Console.ReadLine().ToLower();
            while (s != "y" && s != "n" && s != "1" && s != "0")
            {
                Console.Write(message);
                s = Console.ReadLine().ToLower();
            }
            if (s == "y" || s == "1")
                b = true;
            else
                b = false;
            return b;
        }

        static void PrintStudent(Student[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("| {0}\t|",a[i].FIO);
                Console.Write("{0} |",a[i].dtOfBirth);
                Console.Write("{0} |",a[i].dtEnterUniv);
                if (a[i].isLiveHall)
                    Console.Write(" Да   |");
                else
                    Console.Write(" Нет  |");
                Console.Write(" {0}  \t|",a[i].average);
                Console.Write(" {0}  \t|",a[i].grant);

            }
        }
    }
}
