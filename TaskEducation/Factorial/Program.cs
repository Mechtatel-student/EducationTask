using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{

    class Program
    {
        /// <summary>
        ///  1)
        ///    Посчитать 200! (циклом или рекурсивной функцией)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(" Int");
            Console.WriteLine("200! = " + Fact(200));
            Console.WriteLine(" BigInteger recursion");
            Console.WriteLine("200! = " + FactForBigNumber1(200));
            Console.WriteLine(" BigInteger tsikl");
            Console.WriteLine("200! = " + FactForBigNumber2(200));
            Console.WriteLine("Press Enter, or other key ");
            Console.ReadKey(true);
            int number;

            do
            {
                Console.WriteLine("Enter integer number:               0 - end of work");
                number = IsIntegerNonNegative();
                try
                {
                    Console.WriteLine(number + "!=" + Fact(number));
                    Console.WriteLine(number + "!=" + FactForBigNumber1(number));
                    Console.WriteLine(number + "!=" + FactForBigNumber2(number));
                }
                catch (StackOverflowException)
                {
                    Console.WriteLine("Переполнение стека .");

                }
            }

            while (number > 0);
            Console.WriteLine("End of work,  press Enter or other key ");
            Console.ReadKey(true);



           
             number=200;

            do
            {

                     Console.WriteLine(" Int");
                    Console.WriteLine(number + "!=" + Fact(number));
                    Console.WriteLine(" BigInteger recursion");
                    Console.WriteLine(number + "!=" + FactForBigNumber1(number));
                    Console.WriteLine(" BigInteger tsikl");
                    Console.WriteLine(number + "!=" + FactForBigNumber2(number));
                    Console.WriteLine("Enter integer number:               0 - end of work");
                     number = IsIntegerNonNegative();
            }

            while (number > 0);
            Console.WriteLine("End of work,  press Enter or other key ");
            Console.ReadKey(true);

        }
        /// <summary>
        /// Вычисление факториала с помощью рекурсивной функции,
        /// с обычным типом int
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int Fact(int a)
        {

            if (a == 1 || a == 0)
                return 1;
            else
                return Fact(a - 1) * a;
        }
        /// <summary>
        /// Вычисление факториала с помощью рекурсивной функции,
        /// тип данных BigInteger
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static BigInteger FactForBigNumber1(int a)
        {
            if (a == 1 || a == 0)
                return 1;
            else
                return FactForBigNumber1(a - 1) * a;
        }
        /// <summary>
        /// Вычисление факториала с помощью цикла,
        /// тип данных BigInteger
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static BigInteger FactForBigNumber2(int a)
        {
            BigInteger r = 1;
            for (int i = 1; i <= a; i++)
                r *= i;
            return r;
        }

        static void UseBigInteger()
        {
            Console.WriteLine("=> Use BigInteger:");
            BigInteger biggy =
            BigInteger.Parse("9999999999999999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            // Значение biggy
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            // biggy четное?
            Console.WriteLine("Is biggy а power of two?: {0}", biggy.IsPowerOfTwo);
            // biggy степень 2?
            BigInteger reallyBig = BigInteger.Multiply(biggy,
            BigInteger.Parse("8888888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
            // Значение reallyBig
        }
        /// <summary>
        ///  Ввод натурального числа.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>

        static int IsNatural(string message = "Enter natural number:\r\n")
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
                Console.Write(message);
            return a;
        }
        /// <summary>
        ///  Ввод неотрицательного целого числа.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static int IsIntegerNonNegative(string message = "Enter integer positive number:\r\n")
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a < 0)
                Console.Write(message);
            return a;
        }


    }
}