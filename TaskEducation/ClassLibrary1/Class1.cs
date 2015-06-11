using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Field
    {
        private int[,] a;
        public Field(int width, int heigth)
        {
            if (width>0 && heigth>0)
                a=new int[width,heigth];
            else
                a=new int[1,1];
            for (int i=0;i<width;i++)
                for (int j=0; j<heigth; j++)
                    a[i,j]=10;
        }
        public int GetWidth()
        {
            return a.GetLength(0);
        }
        public int GetHeigth()
        {
            return a.GetLength(1);
        }
        public int GetCountCells()
        {
            return a.Length;

        }
        private bool ValidateCoordinates(int row, int col)
        {   
            bool b=false;
            if (row >= 0 && row < a.GetLength(0) && col >= 0 && col < a.GetLength(1))
                b = true;
            return b;
        }
        public bool IsOpened(int row, int col)
        {
            bool b = false;
            if (ValidateCoordinates(row, col) && Math.Abs(a[row, col]) < 10)
                b = true;
            return b;
        }
        public bool IsMine(int row, int col)
        {
            bool b = false;
            if (ValidateCoordinates(row, col) && a[row, col] < 0)
                b = true;
            return b;
        }
        public bool OpenCell(int row, int col)
        {
            bool b = false;
            if (ValidateCoordinates(row, col))
            {
                if (Math.Abs(a[row, col]) >= 10)
                    a[row, col] -= 10 * Math.Sign(a[row, col]);

                b = true;
            }
            return b;
        }
        public bool SetMine(int row, int col)
        {
            bool b = false;
            if (ValidateCoordinates(row, col))
            {
                if (Math.Abs(a[row, col]) >= 0)
                {
                    a[row, col] = -20 + a[row, col] % 10;
                    for (int i = row - 1; i <= row + 1; i++)
                        for (int j = col - 1; j <= col + 1; j++)
                            if (ValidateCoordinates(i, j))
                                a[i, j]++;
                }
                b = true;
            }
            return b;
        }

        public int CountMineAround(int row, int col)
        {
            int i = 0;
            if (ValidateCoordinates(row, col))
                if (a[row, col] >= 0)
                    i = a[row, col] % 10;
                else
                    i = a[row, col] % 10 + 9;
            return i;
        }

        public int CountOpenedCells()
        {
            int b = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (IsOpened(i, j))
                        b++;
            return b;

        }

        public int CountOpenedCellsWithMine()
        {
            int b = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (IsOpened(i, j) && IsMine(i,j))
                        b++;
            return b;

        }
        public int CountOpenedEmptyCells()
        {
            int b = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (IsOpened(i, j) && !IsMine(i, j))
                        b++;
            return b;
        }
        }
}
