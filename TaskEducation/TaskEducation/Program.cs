using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumbers2_N();
            IsPrimeNumber();
            DayOfWeek();
            VYear();
            EvenNumbers();
            Average5Rand();
            Average5Keyboard();
            Square();
            Lotereya();
            Calculator();
            Passvord();
            TableofMultiplication();
            SumandAverage();
            CountofNul();
            CountTwoEqualElement();
            Operation();
            Matrix();
            ArrayOfArrayRandom();
        }

        /// <summary>
        ///    Проверка ввода целого числа
        /// </summary>
        /// <returns></returns>
        static int IntTryCatch1()
        {
            bool isInt = true;
            int intResult = 0;
            do
            {
                try
                {
                    intResult = Convert.ToInt32(Console.ReadLine());
                    isInt = true;
                }
                catch
                {
                    Console.WriteLine("Enter integer number:");
                    isInt = false;
                }
            }
            while (!isInt);
            return intResult;
        }
        /// <summary>
        ///    Проверка ввода целого числа
        /// </summary>
        /// <returns></returns>
        static int IntTryCatch2()
        {
            bool isInt = true;
            int intResult = 0;
            do
            {
                try
                {
                    intResult = int.Parse



                        (Console.ReadLine());
                    isInt = true;
                }
                catch
                {
                    Console.WriteLine("Enter integer number:");
                    isInt = false;
                }
            }
            while (!isInt);
            return intResult;
        }
        /// <summary>
        ///    Проверка ввода целого числа
        /// </summary>
        /// <returns></returns>
        static int IntProv()
        {

            int intResult = 0;
            while (!int.TryParse(Console.ReadLine(), out intResult))
                Console.WriteLine("Enter integer number:");
            return intResult;
        }
        /// <summary>
        ///    Проверка ввода целого неотрицательного числа
        /// </summary>
        /// <returns></returns>
        static uint UintProv()
        {

            uint intResult = 0;
            while (!uint.TryParse(Console.ReadLine(), out intResult))
                Console.WriteLine("Enter integer number not less then 0");
            return intResult;
        }
        /// <summary>
        ///    Проверка ввода натурального числа
        /// </summary>
        /// <returns></returns>
        static uint IsNatural()
        {

            uint intResult = 0;
            while (!uint.TryParse(Console.ReadLine(), out intResult) || intResult == 0)
                Console.WriteLine("Enter natural number, integer number more o");
            return intResult;
        }
        /// <summary>
        ///    Проверка является ли число простым
        /// </summary>
        /// <returns></returns>
        static bool IsPrime(uint n)
        {
            bool isSimple = true;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                {
                    isSimple = false;
                    break;
                }
            return isSimple;
        }
        /// <summary>
        /// 1)
        ///     Пользователь вводит число N.
        ///	 Напечатать все простые числа от 2 до N. 
        /// </summary>

        static void PrimeNumbers2_N()
        {
            Console.WriteLine("Enter a natural number, more then 1");
            uint n = UintProv();
            Console.WriteLine("Prime numbers:");
            bool isSimple = true;
            for (int i = 2; i <= n; i++)
            {
                isSimple = true;
                for (int j = 2; j <= i / 2; j++)
                    if (i % j == 0)
                    {
                        isSimple = false;
                        break;
                    }
                if (isSimple)
                    Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.ReadKey();


        }

        /// <summary>
        ///  7)
        ///   Дано натуральное число. Выяснить, является ли оно простым, т.е. делится только на 1 и на само себя.
        /// 
        /// </summary>
        static void IsPrimeNumber()
        {
            Console.WriteLine("Enter a natural number:");
            uint n = IsNatural();
            if (n > 1)
            {
                if (IsPrime(n))
                    Console.WriteLine(n + " is a prime number ");
                else
                    Console.WriteLine(n + " is not a prime number and is a composite number ");
            }
            else
                Console.WriteLine(n + " is not a prime number and is not a composite number ");

            Console.ReadKey();
            return;
        }

        /// <summary>
        ///  12)
        ///  	 Вывести название дня недели по его номеру (1 - понедельник, 7 - воскресенье) 
        /// </summary>
        static void DayOfWeek()
        {
            string[] Days = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine("Enter number a day of the week:");
            int number = IntProv();
            try
            {
                Console.WriteLine(Days[number - 1]);
            }
            catch
            {
                Console.WriteLine("This number in not number of day of week");
            }
            /* 
              while (i > 0 && i < 8)
            {
                Console.WriteLine(Days[i - 1]);
                i = Convert.ToInt32(Console.ReadLine());
                
            }
            while (i > 0 && i < 8);
             */
            Console.ReadKey();
        }


        /// <summary>
        /// 14)
        /// 	 Високосный год
        ///	 Пользователь вводит год. Определить, является ли год високосным по григорианскому календарю.
        ///	 Год является високосным в двух случаях: либо он кратен 4, но при этом не кратен 100, либо кратен 400. 
        ///       Год не является високосным, если он не кратен 4, либо он кратен 100, но при этом не кратен 400.
        /// </summary>




        static void VYear()
        {
            uint year;
            Console.WriteLine("Enter a year:  ");
            year = UintProv();
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine(year + " - высокосный год ");
            else
                Console.WriteLine(year + " - не высокосный год ");
            Console.ReadKey();
        }

        /// <summary>
        ///  15)
        ///  Чётные числа
        ///   Определить, что среди заданных целых чисел A, B, C, D есть хотя бы два чётных.
        /// </summary>
        static void EvenNumbers()
        {
            int a, b, c, d;
            int i;
            Console.WriteLine("Enter four integer numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            i = a % 2 + b % 2 + c % 2 + d % 2;
            if (i >= 2)
                Console.WriteLine("equal or more then >= 2 even numbers ");
            else
                Console.WriteLine(" less then < 2 even numbers ");
            Console.ReadKey();
        }
        /// <summary>
        /// 16)
        ///	 Создать 5 случайных целых чисел, посчитать их среднее арифметическое и сообщить его пользователю
        /// </summary>

        static void Average5Rand()
        {
            const int n = 5;
            Random r = new Random();
            double result = 0, currentNumber;
            for (int i = 0; i < n; i++)
            {
                currentNumber = r.Next(100);
                Console.WriteLine(currentNumber);
                result += currentNumber;
            }
            result /= n;
            Console.WriteLine("Average of " + n + " random numbers " + result);
            Console.ReadKey();
        }

        /// <summary>
        /// 17)
        ///	 Прочитать с клавиатуры 5 целых чисел, посчитать их среднее арифметическое и сообщить его пользователю
        /// </summary>
        static void Average5Keyboard()
        {
            const int n = 5;
            Random r = new Random();
            double average = 0;
            Console.WriteLine("Enter " + n + " integer numbers:");
            for (int i = 0; i < n; i++)
            {

                average += Convert.ToInt32(Console.ReadLine());

            }
            average /= n;
            Console.WriteLine("Average " + n + "  numbers " + average);
            Console.ReadKey();
        }
        /// <summary>
        /// 19)
        /// 	 Выведите все точные квадраты натуральных чисел, которые (квадраты) меньше заданного числа N.
        /// 	 (натуральные - это числа, которые мы используем при счёте: 1, 2, 3 и т.д.)
        /// 	 	 Например, если задано число 15, то результат должен быть 1, 4, 9
        /// </summary>
        static void Square()
        {
            uint n;

            int square = 1;
            Console.WriteLine("Enter natural number n");
            n = Convert.ToUInt32(Console.ReadLine());
            int i = 1;
            while (square < n)
            {
                Console.Write(square + ", ");
                i++;
                square = i * i;
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        /// <summary>
        ///  20)
        ///  	Вы организатор лотереи. Пользователь вводит ставку. Вы бросаете 12-гранный кубик.
        ///  	Если выпадают значения от 1 до 5, пользователь проиграл. Если выпадают значения от 6 до 8,
        ///  	пользователь получает свою ставку обратно. Если выпало от 9 до 11, пользователь получает 
        ///  	двойную ставку, а если выпало 12 - ставку умноженную на 10.
        ///  		После окончания игры покажите пользователю, сколько он выиграл.
        ///  		22)
        ///  		Обе задачи переделать таким образом, чтобы программа спрашивала, хочет ли пользователь
        ///  		ещё раз сыграть (или посчитать). 
        /// </summary>
        /// 
        static void Lotereya()
        {
            int stavka, viigrish;
            Random r = new Random();

            string s;
            do
            {
                Console.WriteLine("Сделайте ставку:");
                stavka = Convert.ToInt32(Console.ReadLine());
                int kubik = r.Next(1, 13);
                if (kubik >= 1 && kubik <= 5)
                    viigrish = 0;
                else
                    if (kubik > 5 && kubik <= 8)
                        viigrish = stavka;
                    else
                        if (kubik > 8 && kubik < 12)
                            viigrish = 2 * stavka;
                        else
                            viigrish = 10 * stavka;

                Console.WriteLine("Ваш выигрыш: " + viigrish);
                Console.WriteLine("Введите 1, если хотите продолжить игру, ");
                Console.WriteLine("и любой другой символ для окончания игры,");
                s = Console.ReadLine();
            }
            while (s == "1");
        }

        /// <summary>
        /// 21)
        /// 	Написать простой калькулятор, который работает с целыми числами. 
        /// 	Пользователь вводит первое число, потом второе число, потом знак операции (+ - * /). 
        /// 	Нужно с помощью switch определить, какой знак операции, затем выполнить соответствующие
        /// 	вычисления и выдать пользователю результат (в случае деления, результат должен быть
        /// 	вещественный).
        /// 	22)
        /// 	Обе задачи переделать таким образом, чтобы программа спрашивала, 
        /// 	хочет ли пользователь ещё раз сыграть (или посчитать). 
        /// </summary>
        static void Calculator()
        {


            string canContinue;
            do
            {
                Console.WriteLine("Enter two integer numbers and sign of the operation: ");
                int firstOperand = Convert.ToInt32(Console.ReadLine());
                int secondOperand = Convert.ToInt32(Console.ReadLine());
                char input = Convert.ToChar(Console.ReadLine());
                bool isCorrect = true;
                double result = 0;
                Console.Write(firstOperand + " " + input + " " + secondOperand + " = ");
                switch (input)
                {
                    case '+': result = firstOperand + secondOperand;
                        break;
                    case '-': result = firstOperand - secondOperand;
                        break;
                    case '*': result = firstOperand * secondOperand;
                        break;
                    case '/': result = (double)firstOperand / secondOperand;
                        break;
                    default: isCorrect = false;
                        break;
                }

                if (isCorrect)
                    Console.WriteLine(result);
                else
                    Console.WriteLine("\r\n Неправильный знак операции,");

                Console.WriteLine("Введите 1, если хотите ещё что-то посчитать, ");
                Console.WriteLine("и любой другой символ для окончания работы, ");
                canContinue = Console.ReadLine();
            }
            while (canContinue == "1");
            Console.ReadKey();
        }

        /// <summary>
        /// 23)
        /// Напишите программу, которая будет «спрашивать» правильный пароль, 
        /// до тех пор, пока он не будет введен. Правильный пароль пусть будет «root». 
        /// Если пароль не верный, программа должна сказать "Неверный пароль!"
        /// 
        /// </summary>
        static void Passvord()
        {
            string s;
            do
            {
                Console.WriteLine("Enter a password:");
                s = Console.ReadLine();
                if (s != "root")
                    Console.WriteLine("Incorrect password,");
                Console.WriteLine(String.Compare(s, "root"));
            }
            while (s != "root");  // (String.Compare(s, "root") != 0);
            Console.ReadKey();
        }



        ///
        /// 24)
        ///	 напечатать "табличку умножения" треугольником, от 1 до 10:
        ///	 1
        ///	 2 4
        ///	 3 6 9
        ///	 4 8 12 16
        ///	 5 10 15 20 25
        ///	 6 12 18 24 30 36
        ///	 7 14 21 28 35 42 49
        ///	 8 16 24 32 40 48 56 64
        ///	 9 18 27 36 45 54 63 72 81
        ///	 10 20 30 40 50 60 70 80 90 100
        /// 


        static void TableofMultiplication()
        {
            const int n = 10;
            int i, j;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write(i * j + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 25)
        /// 	 Задан одномерный массив (элементы задаются случайными числами), 
        /// 	 посчитать сумму элементов и среднее арифметическое. 
        /// </summary>
        static void SumandAverage()
        {

            int[] a = new int[10];
            double sum = 0, average = 0;
            Random r = new Random();

            for (int i = 0; i < a.Length; i++)
                a[i] = r.Next(20);
            foreach (int el in a)
                sum += el;
            average = sum / a.Length;
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Sum of elements: " + sum);
            Console.WriteLine("Average: " + average);
            Console.ReadKey();
        }

        /// <summary>
        ///  26)
        ///  	 В заданном одномерном массиве, состоящем из n целых чисел
        ///  	 (ввод с клавиатуры размера массива,
        ///  	 заполнение значений ячеек случайным образом от 0 до 3), подсчитать количество нулей.
        /// </summary>
        static void CountofNul()
        {
            int countNul = 0;
            Console.Write("Enter count elements of array  n =");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
                a[i] = r.Next(3);
            foreach (int el in a)
                if (el == 0)
                    countNul++;

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Количество нулей: " + countNul);
            Console.ReadKey();
        }

        /// <summary>
        /// 27)
        /// Дан массив чисел (заполните с клавиатуры). Найти, сколько в нем пар
        /// одинаковых соседних элементов.
        /// </summary>
        static void CountTwoEqualElement()
        {
            Console.Write("Enter count elements of array  n =");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter " + n + " elements of array");
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            int pairsNumber = 0;
            for (int i = 0; i < n - 1; i++)
                if (a[i] == a[i + 1])
                    pairsNumber++;


            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Количество пар одинаковых соседних элементов: " + pairsNumber);
            Console.ReadKey();
        }


        /// <summary>
        /// 29)
        /// 	 Существуют эти три массива одинаковой длины:
        /// 	 	 { 1, 2, 3, 4, 5, 6, 7, 12, 3 }
        /// 	 	  { 50, 5, 3, 12, 8, 7, 2, 4, 1 }
        /// 	 	  { '+', '-', '-', '*', '*', '-', '#', '+', '/' }
        /// 	 	   Создайте четвертый массив result такой же длины и 
        /// 	 	   запишите туда результаты выполнения соответствующей операции
        /// 	 	   для каждого из элементов массива. Например result[0] 
        /// 	 	   это сумма operand1[0] и operand2[0], result[1]
        /// 	 	   это разница operand1[1] и operand2[1] и так далее.
        /// </summary>

        public static double f1(int a, int b, char r)
        {
            double c = 0;
            switch (r)
            {
                case '+': c = a + b; break;
                case '-': c = a - b; break;
                case '*': c = a * b; break;
                case '/': c = (double)a / b; break;
            }

            return c;
        }
        static void Operation()
        {

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 12, 3 };
            int[] b = { 50, 5, 3, 12, 8, 7, 2, 4, 1 };
            char[] r = { '+', '-', '-', '*', '*', '-', '/', '+', '/' };
            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
                result[i] = f1(a[i], b[i], r[i]);
            Console.WriteLine("Array of results: ");
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
                Console.Write(result[i] + " ");
            Console.WriteLine();
            Console.ReadKey();
        }

        /// <summary>
        /// 32)
        /// 	Дана квадратная матрица А(N,N). Составить программу замены положительных элементов, 
        /// 	расположенных ниже главной диагонали, на среднее арифметическое значение 
        /// 	элементов главной диагонали. 
        /// 	Исходную и скорректированную матрицы напечатать. 
        /// </summary>
        static void Matrix()
        {
            const int n = 10;
            double[,] a = new double[n, n];
            int[,] a1 = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    a1[i, j] = (r.Next(0, 2) == 1) ? 1 : -1;
                    a[i, j] = a1[i, j] * r.Next(50);
                }
            Console.WriteLine("Исходная матрица: \r\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (a[i, j] > 9)
                        Console.Write(" " + a[i, j] + " ");
                    else
                        if (a[i, j] >= 0)
                            Console.Write("  " + a[i, j] + " ");
                        else
                            if (a[i, j] > -10)
                                Console.Write(" " + a[i, j] + " ");
                            else
                                Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }

            double b = 0;
            for (int i = 1; i < n; i++)
                b += a[i, i];
            b /= n;
            Console.WriteLine();
            Console.WriteLine(" Average b = " + b);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < i; j++)
                    if (a[i, j] > 0)
                        a[i, j] = b;

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Скорректированная матрица: \r\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(" " + a[i, j] + " ");
                Console.WriteLine();
            }


            Console.ReadKey();
        }
        /// <summary>
        /// 35)
        /// Создайте массив целых чисел, с разной длиной строк
        /// (количество строк 10, длина строк определяется случайным образом, от 2 до 7).
        /// Заполните его целыми числами от 0 до 15.
        /// </summary>
        static void ArrayOfArrayRandom()
        {
            const int n = 10;
            int i, j;
            Random r = new Random();
            int[][] a = new int[n][];
            for (i = 0; i < n; i++)
                a[i] = new int[r.Next(2, 8)];
            for (i = 0; i < n; i++)
                for (j = 0; j < a[i].Length; j++)
                    a[i][j] = r.Next(16);
            for (i = 0; i < n; i++)
            {
                foreach (int el in a[i])
                    Console.Write(el + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }



    }
}
