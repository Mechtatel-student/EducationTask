using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Miner_It_is_possible_to_play
{
    class Program
    {

        /// <summary>
        ///   Сделать поле для игры в "Сапёр": пользователь вводит размеры поля и количество бомб, 
        ///   нужно раскидать эти бомбы по полю в случайном порядке. Нельзя позволить пользователю ввести
        ///   большее количество бомб, чем помещается на поле. Дальше цикл игры: пользователь вводит координаты
        ///   ячейки, которую он открывает (номера ячеек поля в этой игре, для пользователя, начинаются с 1),
        ///   и программа ему выдаёт, есть ли там бомба а если нету то какое количество бомб находится в 
        ///   соседних ячейках. Если пользователь ввёл координаты 0, 0 это он хочет закончить игру.
        ///   Нельзя позволить пользователю ввести координаты, которые выходят за пределы поля и не 
        ///   являются признаками конца игры (просто говорить ему, что координаты не верны, и спрашивать снова). 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Game();
            Game(false);
            Game(false, 2);
        }

        /// <summary>
        /// Игра "Минёр"
        /// </summary>
        /// <param name="isOpenCells">Параметр имеет значение истина, если игра ведётся до момента открытия всех клеток,
        ///                и ложь, если игра ведётся до открытия всех пустых клеток без мин, .   </param>
        /// <param name="mines"> Параметр указывает, до какой по счету открытой мины ведётся игра.  </param>
        static void Game(bool isOpenCells = true, int mines = 0)
        {
            Console.WriteLine("Enter count_of_rows and count_of_colunms:");
            Console.Write("Count_of_rows = ");
            int n = IsIntegerDiapason("Enter natural number:\r\n Count_of_rows = ", 1);
            Console.Write("Count_of_colunms = ");
            int m = IsIntegerDiapason("Enter natural number:\r\n Count_of_columns = ", 1);

            int countMines;

            int x = 0, y = 0;
            Console.WriteLine("Enter count of mines:");
            Console.Write("Count_of_mines = ");
            int c = n * m;
            countMines = IsIntegerDiapason("Enter natural number or 0:\r\n Pole can contain count of mines <= "
                                                + (n * m) + "Count_of_mines = ", 0, (n * m));

            int[,] a = Initialize(n, m, countMines);
            PrintArray(a);
            Console.ReadKey();
            Console.Clear();
            ConsoleColor prevFColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   Begin game    ");
            Console.WriteLine("If you want to end game, enter numbers of row and column equal 0:    (0,0)");
            Console.ForegroundColor = prevFColor;
            Console.WriteLine();
            PrintColorPoleSelelction(a);

            int countOpenCells = 0;
            int countOpenMines = 0;

            do
            {
                Console.WriteLine("Enter number_of_rou <= {0} and number_of_colunm <= {1}:", a.GetLength(0), a.GetLength(1));
                Console.Write("Number_of_row = ");
                x = IsIntegerDiapason("Enter natural number <=" + a.GetLength(0) + " :\r\n Number_of_row = ", 0);

                Console.Write("Number_of_colunm = ");
                y = IsIntegerDiapason("Enter natural number <=" + a.GetLength(1) + ":\r\n Number_of_row = ", 0);

                if (x > 0 && y > 0)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You choose cell (" + x + "," + y + ")");
                    if (a[x - 1, y - 1] >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("This cell is empty , safety, ");
                    }
                    else
                    {
                        if (!isOpenCells)
                            countOpenMines++;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("This cell contain the mine !");
                    }
                    Console.ForegroundColor = prevFColor;
                    Console.WriteLine();
                    countOpenCells += Change(a, x - 1, y - 1);
                    PrintColorPoleSelelction(a, x, y);
                    Console.WriteLine();
                }
                else
                    if (x != 0 || y != 0)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("You entered error coordinates, x={0}, y={1}  ", x, y);
                        Console.WriteLine("If you want to end game, enter numbers of row and column equal 0:    (0,0)");
                        Console.ForegroundColor = prevFColor;
                    }

            }
            while (Math.Pow(x, 2) + Math.Pow(y, 2) != 0 && countOpenCells < a.Length &&
                                                     (isOpenCells || countOpenMines < mines));
            if (Math.Pow(x, 2) + Math.Pow(y, 2) == 0)
                Console.WriteLine("You bring to end game, press \" Enter \" to quit. ");
            else
                if (isOpenCells)
                    Console.WriteLine("You opened all cells, press \" Enter \" to quit. ");

                else
                    if (countOpenCells == a.Length)
                    {
                        Console.WriteLine("You opened all cells, limit open mines more then count of mines, ");
                        Console.WriteLine(" press \" Enter \" to quit. ");
                    }
                    else
                        Console.WriteLine("You opened {0}  cells with mine, therefore game is end, " +
                              " press \" Enter \" to quit. ", countOpenMines);

            Console.ReadKey();

        }





        /// <summary>
        ///  Ввод натурального числа.
        /// </summary>
        /// <param name="message">Сообщение, которое выдается, если пользователь ввёл неверные данные </param>
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
        /// <param name="message">Сообщение, которое выдается, если пользователь ввёл неверные данные </param>
        /// <returns></returns>
        static int IsIntegerNonNegative(string message = "Enter integer positive number:\r\n")
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a < 0)
                Console.Write(message);
            return a;
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
        ///  Инициализация поля,  размещение в поле мин, и для каждой ячейки 
        ///  подсчет количества мин в соседних ячейках.
        /// </summary>
        /// <param name="n">Высота поля, количество строк</param>
        /// <param name="m">Ширина поля, количество столбцов</param>
        /// <param name="b">Количество мин</param>
        /// <returns>Заполненный массив чисел</returns>

        static int[,] Initialize(int n, int m, int b)
        {

            int[,] res = new int[n, m];

            for (int i = 0; i < res.GetLength(0); i++)
                for (int j = 0; j < res.GetLength(1); j++)
                    res[i, j] = 10;
            Random r = new Random();
            for (int i = 0; i < b; i++)
            {
                bool isEmpty = true;
                int x = 0, y = 0;
                do
                {
                    isEmpty = true;
                    x = r.Next(res.GetLength(0));
                    y = r.Next(res.GetLength(1));

                    if (res[x, y] > 0)
                        res[x, y] = -20;
                    else
                        isEmpty = false;
                }
                while (!isEmpty);

                for (int i1 = Math.Max(x - 1, 0); i1 < Math.Min(x + 2, res.GetLength(0)); i1++)
                    for (int j1 = Math.Max(y - 1, 0); j1 < Math.Min(y + 2, res.GetLength(1)); j1++)
                        res[i1, j1]++;

            }
            return res;
        }
        /// <summary>
        /// Выбор ячейки поля и изменение значений поля при выборе.
        /// </summary>
        /// <param name="a">Массив чисел, поле </param>
        /// <param name="x">Номер строки </param>
        /// <param name="y">Номер столбца </param>
        /// <returns>Количество изменённых ячеек </returns>
        static int Change(int[,] a, int x, int y)
        {
            int b = 1;
            if (x >= 0 && x < a.GetLength(0) && y >= 0 && y < a.GetLength(1))
            {
                if (Math.Abs(a[x, y]) >= 10)
                    a[x, y] = a[x, y] - 10 * Math.Sign(a[x, y]);
                else
                {
                    b = 0;
                    Console.WriteLine("You already change this cell");
                }
            }
            else
            {
                b = 0;
                Console.WriteLine("Error index");
            }

            return b;

        }

        /// <summary>
        ///  Вывод на экран массива чисел, соответствующего полю.
        /// </summary>
        /// <param name="a">Массив чисел</param>
        static void PrintArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write(" ");
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();

            }
        }
        /// <summary>
        ///  Вывод на экран поля, с отображением выбранных и не выбранных ячеек.
        /// </summary>
        /// <param name="a">Массив чисел</param>
        static void PrintPole(int[,] a)
        {

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    if (Math.Abs(a[i, j]) < 10)
                        if (a[i, j] >= 0)
                            Console.Write(a[i, j] + "\t");
                        else
                            Console.Write("+\t");
                    else
                        Console.Write(" \t");
                Console.WriteLine();


            }
        }



        /// <summary>
        /// Выбор цвета числа в зависимости от значения числа.
        /// </summary>
        /// <param name="a">Число, в зависимости от значения которого выбирается цвет</param>
        /// <returns>Цвет</returns>
        static ConsoleColor CurrentColorSymvol(int a)
        {
            ConsoleColor currenColor;
            switch (a)
            {
                case 0: currenColor = ConsoleColor.DarkGreen;
                    break;
                case 1: currenColor = ConsoleColor.Green;
                    break;
                case 2: currenColor = ConsoleColor.DarkCyan;
                    break;
                case 3: currenColor = ConsoleColor.DarkYellow;
                    break;
                case 4: currenColor = ConsoleColor.Cyan;
                    break;
                case 5: currenColor = ConsoleColor.Blue;
                    break;
                case 6: currenColor = ConsoleColor.DarkBlue;
                    break;
                case 7: currenColor = ConsoleColor.Magenta;
                    break;
                case 8: currenColor = ConsoleColor.DarkMagenta;
                    break;
                default: currenColor = ConsoleColor.Black;
                    break;
            }
            return currenColor;
        }

        /// <summary>
        ///  Отображение поля с выбранной ячейкой.
        ///  Корректно отображает поле с длиной и шириной меньше 100 ячеек.
        /// </summary>
        /// <param name="a">Массив чисел, поле</param>
        /// <param name="x">Номер строки выбранной ячейки </param>
        /// <param name="y">Номер столбца выбранной ячейки
        /// </param>
        static void PrintColorPoleSelelction(int[,] a, int x = 0, int y = 0)
        {
            Console.Write("     ");
            for (int j = 0; j < a.GetLength(1); j++)
                if (j < 9)
                    Console.Write((j + 1) + "  ");
                else
                    Console.Write((j + 1) + " ");
            Console.WriteLine();
            ConsoleColor prevBColor = Console.BackgroundColor;
            ConsoleColor prevFColor = Console.ForegroundColor;
            Console.Write("    ");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("-");
            for (int j = 0; j < a.GetLength(1); j++)
                Console.Write("---");
            Console.WriteLine();
            for (int i = 0; i < a.GetLength(0); i++)
            {

                Console.BackgroundColor = prevBColor;
                Console.ForegroundColor = prevFColor;
                if (i < 9)
                    Console.Write(" " + (i + 1) + "  ");
                else
                    Console.Write(" " + (i + 1) + " ");

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("|");
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == x - 1 && j == y - 1)
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    else
                        Console.BackgroundColor = ConsoleColor.White;
                    if (Math.Abs(a[i, j]) < 10)
                        if (a[i, j] >= 0)
                        {
                            Console.ForegroundColor = CurrentColorSymvol(a[i, j]);
                            Console.Write(a[i, j] + " ");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("+ ");
                        }
                    else
                        Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("|");
                }
                Console.WriteLine();


                Console.BackgroundColor = prevBColor;
                Console.ForegroundColor = prevFColor;
                Console.Write("    ");

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.Write("-");
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write("---");
                Console.WriteLine();
            }

            Console.BackgroundColor = prevBColor;
            Console.ForegroundColor = prevFColor;
        }


    }
}
