using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private double a, b;
        private bool t=false;
        private char op = '+';
        public Form1()
        {
            InitializeComponent();
            t = false;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += this.button2.Text;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += this.button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += this.button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            textBox2.Text = "";
            textBox3.Text = "";
            t = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (t)
            {
                b = Convert.ToDouble(textBox1.Text);
                if (b != 0 || op !='/' )
                {
                    a = Operation(a, b, op);
                    textBox2.Text += " " + textBox1.Text + " = " + Convert.ToString(a);
                    textBox1.Text = Convert.ToString(a);
                    textBox1.Text = Convert.ToString(a);
                    t = false;
                }
                else
                    textBox3.Text = "Ошибка: деление на ноль";



                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                op = '+';
                Res();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                op = '-';
                Res();
            }
        }

        private void Res()
        {
            
            if (!t)
            {
                a = Convert.ToDouble(textBox1.Text);
                t = true;
              
            }
            else
            {
                b = Convert.ToDouble(textBox1.Text);
                a = Operation(a, b, op);
             }

            textBox2.Text = Convert.ToString(a) + " " + Convert.ToString(op);
            textBox1.Text = "";
        }
        private double Operation(double a, double b, char r )
        {
            double s = 0;
            switch (r)
            {
                case '+': s = a + b;
                    break;
                case '-': s = a - b;
                    break;
                case '*': s = a * b;
                    break;
                case '/': s = a / b;
                    break;
                default: s = 0;
                    break;
            }
            return s;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                op = '*';
                Res();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                op = '/';
                if (!t)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    t = true;
                    textBox2.Text = textBox1.Text + " " + Convert.ToString(op);
                    textBox1.Text = "";
                }
                else
                {
                    b = Convert.ToDouble(textBox1.Text);
                    if (b != 0)
                    {
                        a = Operation(a, b, op);
                        textBox2.Text = Convert.ToString(a) + " " + Convert.ToString(op);
                        textBox1.Text = "";
                    }
                    else
                    {
                        textBox3.Text = "Ошибка: деление на ноль";
                        textBox2.Text = Convert.ToString(a) + " " + Convert.ToString(op);
                        textBox1.Text = "";
                    }

                }


               





            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += this.button15.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += this.button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += this.button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += this.button11.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += this.button14.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += this.button13.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += this.button12.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
