using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double a=0;
        private double b=0;
        private double memoryNumber = 0;


        private int i = 0;
        private bool isOperation = false;
        private bool isSecondOperand = false;

        
        private char op = '+';

        private bool isDoOperation = false;

        private bool isPrintSymbols = true;
        private bool cl = true;
        private bool isPoint = false;

private double[] arrayOfMemoryNumber=new double[5];
private RadioButton[] arrayOfRadioButton = new RadioButton[5];
private bool[] free = new bool[5];
private int currentMemoryIndex = 0;
        private int cur=0;

        public Form1()
        {
            InitializeComponent();
            arrayOfRadioButton[0] = nm1;
            arrayOfRadioButton[1] = nm2;
            arrayOfRadioButton[2] = nm3;
            arrayOfRadioButton[3] = nm4;
            arrayOfRadioButton[4] = nm5;
            nm1.Text = Convert.ToString(arrayOfMemoryNumber[0]);
            nm2.Text = Convert.ToString(arrayOfMemoryNumber[1]);
            nm3.Text = Convert.ToString(arrayOfMemoryNumber[2]);
            nm4.Text = Convert.ToString(arrayOfMemoryNumber[3]);
            nm5.Text = Convert.ToString(arrayOfMemoryNumber[4]);
            for (int i = 0; i < arrayOfMemoryNumber.Length; i++)
            {
                free[i] = true;
            }
                textBox1.Text = "0";
        }


        private void PrintNumber(int a)
        {
            if (isPrintSymbols)
            {
                if (cl)
                {
                    if (isOperation)
                    {
                        isDoOperation = true;
                    }
                    textBox1.Text = Convert.ToString(a);
                    if (a != 0)
                    {
                        cl = false;
                    }
                }
                else
                {
                    textBox1.Text += Convert.ToString(a);
                }
            }
        }
        private void PrintNumber(string a)
        {
            
            if (!isPoint && isPrintSymbols)
            {
                if (cl)
                {
                    textBox1.Text = "0" + a;
                    cl = false;
                }
                else
                {
                    textBox1.Text += a;
                }
                isPoint = true;
            }
        }

        private void SymbolOfOperation(char r)
        {
            if (isPrintSymbols)
            {
                int e = 0;
                if (i==0)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = Convert.ToString(a) + r;
                    i++;
                }
                else
                {
                    if (isDoOperation)
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        textBox2.Text += Convert.ToString(b) + r;
                        a = Operation(a, b, op, out e);
                        if (e > 0)
                            return;
                        textBox1.Text = Convert.ToString(a);
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1) + r;
                    }
                }
                op = r;
                isOperation = true;
                isDoOperation = false;
                cl = true;
                isPoint = false;
            }
        }

        private void Clear()
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            cl = true;
            isPoint = false;
            isPrintSymbols = true;
            i = 0;
            isOperation = false;
            isSecondOperand = false;
            isDoOperation = false;
        }

        private void FunctionEqual()
        {
            int e = 0;
            if (isOperation && isPrintSymbols)
            {
                if (!isSecondOperand)
                {
                    b = Convert.ToDouble(textBox1.Text);
                    isSecondOperand = true;
                }
                a = Operation(a, b, op, out e);
                if (e > 0)
                    return ;
                textBox1.Text = Convert.ToString(a);
                textBox2.Text = "";
                i = 0;
                isDoOperation = false;
                cl = true;
                isPoint = false;
            }
        }
        
        private double Operation(double a, double b, char r,  out int er)
        {
            double s = 0;
            er = 0;
            switch (r)
            {
                case '+': s = a + b;
                    break;
                case '-': s = a - b;
                    break;
                case '*': s = a * b;
                    break;
                case '/':
                    if (!b.Equals(0))
                    {
                        s = a / b;
                    }
                    else
                    {  
                        MessageBox.Show("Деление на 0");
                        textBox1.Text = "Деление на 0";
                        isPrintSymbols = false;
                        er=1;
                    }
                    break;
                default: s = 0;
                    break;
            }
            return s;
        }


        private void WriteToMemory()
        {
            
                int i = 0;
                for (i = 0; i < arrayOfMemoryNumber.Length; i++)
                {
                    if (free[i])
                    {
                        arrayOfMemoryNumber[i] = Convert.ToDouble(textBox1.Text);
                        arrayOfRadioButton[i].Text =
                                    Convert.ToString(arrayOfMemoryNumber[i]);
                        free[i] = false;
                        break;
                    }
                }
                if (i >= arrayOfMemoryNumber.Length)
                {
                    MessageBox.Show("Память заполнена");
                }
               

        }

        private void AddToMemory()
        {
            double n = Convert.ToDouble(textBox1.Text);
            n += arrayOfMemoryNumber[currentMemoryIndex];
            textBox1.Text =
                        Convert.ToString(n);
        }
        private void SubToMemory()
        {
            double n = Convert.ToDouble(textBox1.Text);
            n -= arrayOfMemoryNumber[currentMemoryIndex];
            textBox1.Text =
                        Convert.ToString(n);
        }

        private void ClearAllMemory()
        {
            for (int i = 0; i < arrayOfMemoryNumber.Length; i++)
            {
                free[i] = true;
                arrayOfMemoryNumber[i] = 0;
                arrayOfRadioButton[i].Text =
                            Convert.ToString(arrayOfMemoryNumber[i]);
            }
               
        }
        private void ShowAndClearMemory()
        {
            if (isOperation)
            {
                isDoOperation = true;
            }
            textBox1.Text = Convert.ToString(arrayOfMemoryNumber[currentMemoryIndex]);
            arrayOfMemoryNumber[currentMemoryIndex] = 0;
            free[currentMemoryIndex] = true;
            arrayOfRadioButton[currentMemoryIndex].Text =
                        Convert.ToString(arrayOfMemoryNumber[currentMemoryIndex]);
           
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            PrintNumber(1);
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            PrintNumber(2);
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            PrintNumber(3);
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            PrintNumber(4);
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            PrintNumber(5);
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            PrintNumber(6);
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            PrintNumber(7);
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            PrintNumber(8);
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            PrintNumber(9);
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            PrintNumber(0);
        }

      

        private void Point_Click(object sender, EventArgs e)
        {
            PrintNumber(",");
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            FunctionEqual();
                
            
        }

        private void OpAdd_Click(object sender, EventArgs e)
        {
            SymbolOfOperation('+');

        }

        private void OpSub_Click(object sender, EventArgs e)
        {
            SymbolOfOperation('-');
        }

        private void OpMul_Click(object sender, EventArgs e)
        {
            SymbolOfOperation('*');
        }

        private void OpDiv_Click(object sender, EventArgs e)
        {
            SymbolOfOperation('/');
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WriteMemory_Click(object sender, EventArgs e)
        {
            WriteToMemory();
        }

        private void AddMemory_Click(object sender, EventArgs e)
        {
            AddToMemory();
        }

        private void SubMemory_Click(object sender, EventArgs e)
        {
            SubToMemory();
        }

        private void ShowNumberMemory_Click(object sender, EventArgs e)
        {
            ShowAndClearMemory();
        }

        private void ClearNumberMemory_Click(object sender, EventArgs e)
        {
            ClearAllMemory();
        }

        private void nm1_CheckedChanged(object sender, EventArgs e)
        {
            currentMemoryIndex = 0;
        }

        private void nm2_CheckedChanged(object sender, EventArgs e)
        {
            currentMemoryIndex = 1;
        }

        
        
        

        private void nm3_CheckedChanged_1(object sender, EventArgs e)
        {
            currentMemoryIndex = 2;
        }

        private void nm4_CheckedChanged_1(object sender, EventArgs e)
        {
            currentMemoryIndex = 3;
        }

        private void nm5_CheckedChanged_1(object sender, EventArgs e)
        {
            currentMemoryIndex = 4;
        }
 
        
    }
}
