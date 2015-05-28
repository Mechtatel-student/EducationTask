using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of rows and colunms");
            int rowCount=AskNaturalNumber();
            int columnCount=AskNaturalNumber();
            int countBombs=0;
            do
            {
               Console.WriteLine("Enter count of bombs");
               countBombs=AskNaturalNumber();
                if  (countBombs>rowCount*columnCount)
                    Console.WriteLine("new count of bombs ");
            }
            while (countBombs>rowCount*columnCount);
            
            int countKl = rowCount * columnCount;
            Random r = new Random();
            char[,] pole = new char[rowCount, columnCount];
            bool[,] isVisile = new bool[rowCount, columnCount];
            for (int i = 0; i < pole.GetLength(0); i++)
                for (int j = 0; j < pole.GetLength(1); j++)
                    pole[i, j] = ' ';
            int x, y;
            for (int i = 0; i < countBombs; i++)
            {
                x = r.Next(rowCount);
                y = r.Next(columnCount);
                pole[x, y] = '*';
            }
            for (int i = 0; i < pole.GetLength(0); i++)
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    if (pole[i, j] != '*')
                    {
                        int b = 0;
                        for (int i1 = (i - 1 >= 0) ? i - 1 : 0; i1 < ((pole.GetLength(0) <= i + 1) ? pole.GetLength(0) : i + 1); i1++)
                            for (int j1 = (j - 1 >= 0) ? j - 1 : 0; j1 < ((pole.GetLength(1) <= j + 1) ? pole.GetLength(0) : j + 1); j1++)
                                if (pole[i1, j1] == '*')
                                    b++;
                        pole[i, j] = Convert.ToChar(b);
                    }
                }
                    

            PrintCurrentPole(pole);
            PrintPole(pole);
            Console.ReadKey();

        }


        static void PrintPole(char[,] pole, bool[,] isVisile)
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                    if (isVisile[i, j] )
                        Console.Write(pole[i, j]);
                    else
                        Console.Write(' ');
                Console.WriteLine();
            }

        }
        static void PrintCurrentPole(char[,] pole)
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                    Console.Write(pole[i, j]);
                Console.WriteLine();
            }

        }

        //static void ChangeVisible(int x;int y, bool[,] isVisile)
        //{
        //    for (int i = 0; i < pole.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < pole.GetLength(1); j++)
        //            if (isVisile[i, j] )
        //                Console.Write(pole[i, j]);
        //            else
        //                Console.Write(' ');
        //        Console.WriteLine();
        //    }
        static int AskNaturalNumber()
    {
        int naturalNumber=0;
        while (!int.TryParse(Console.ReadLine(), out naturalNumber) || naturalNumber<=0)
             Console.WriteLine("Enter natural number:");
        return naturalNumber;
    }
    }
}
