using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumber
{
    class Program
    {
        /// <summary>
        /// 3)
        ///  напишите статический метод BigInteger GetNumber(), который будет запрашивать 
        ///  с клавиатуры число любой длины (до нажатия Enter) и не будет разрешать вводить пользователю ничего, 
        ///  кроме цифр и Enter. Подсказка: используйте посимвольный ввод без немедленного отображения символа на экран.
        ///  «неправильно» введенные символы просто должны игнорироваться программой, что и создаст
        ///  иллюзию «запрета ввода» этих символов.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
               
           GetNumber();
           Console.WriteLine("Enter number : ");

           BigInteger i = GetNumber1();
           Console.WriteLine("i = "+i);
           Console.ReadKey(true);
      
        }
        /// <summary>
        ///  Функция BigInteger GetNumber() будет запрашивать 
        ///  с клавиатуры число любой длины (до нажатия Enter) и не будет разрешать вводить пользователю ничего, 
        ///  кроме цифр и Enter
        /// </summary>
        /// <returns></returns>
        static BigInteger GetNumber()
        {
            Console.WriteLine("Enter number : ");
            string str = "";
            BigInteger res=0;
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey(true);
                if (char.IsDigit(cki.KeyChar))
                {
                    Console.Write(cki.KeyChar);
                    str += cki.KeyChar;
                    res = res * 10 + Convert.ToInt32(cki.KeyChar.ToString());
       
                }
                if (cki.Key == ConsoleKey.Enter)
                
                    
                    Console.WriteLine(cki.KeyChar);
                
            }
            while (cki.Key != ConsoleKey.Enter);

            Console.ReadKey(true);
            Console.WriteLine(str);
            Console.WriteLine(res);
            
            return res;

        }
        /// <summary>
        /// Функция BigInteger GetNumber1()  возвращает введённое 
        ///  с клавиатуры число любой длины (до нажатия Enter) и не разрешает вводить пользователю ничего, 
        ///  кроме цифр и Enter, 
        ///  не выводит на экран запрос ввода числа 
        /// </summary>
        /// <returns></returns>
        static BigInteger GetNumber1()
        {
            
            BigInteger res = 0;
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey(true);
                if (char.IsDigit(cki.KeyChar))
                {
                    Console.Write(cki.KeyChar);
                    res = res * 10 + Convert.ToInt32(cki.KeyChar.ToString());

                }
                                

            }
            while (cki.Key != ConsoleKey.Enter);
                Console.WriteLine(cki.KeyChar);
            

            return res;

        }
    }
}
