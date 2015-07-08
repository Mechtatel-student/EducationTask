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
        private int i = 0;
        private bool isOperation = false;
        private bool isSecondOperand = false;

        
        private char op = '+';

        private bool isDoOperation = false;

        private bool isPrintSymbols = true;
        private bool cl = true;
        private bool isPoint = false;
        public Form1()
        {
            InitializeComponent();
            
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


 
        
    }
}
