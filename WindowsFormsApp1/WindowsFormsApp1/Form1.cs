using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Form form1 = new Form2();
            form1.Show();
            Form form2 = new Form3();
            form2.Show();*/
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double SecondNumber = Convert.ToDouble(textBox1.Text);
            double Result;

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(3.ToString());
            }
            else
            {
                textBox1.AppendText(3.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(5.ToString());
            }
            else
            {
                textBox1.AppendText(5.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(9.ToString());
            }
            else
            {
                textBox1.AppendText(9.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(1.ToString());
            }
            else
            {
                textBox1.AppendText(1.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(2.ToString());
            }else
            {
                textBox1.AppendText(2.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(4.ToString());
            }
            else
            {
                textBox1.AppendText(4.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(6.ToString());
            }
            else
            {
                textBox1.AppendText(6.ToString());
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(7.ToString());
            }
            else
            {
                textBox1.AppendText(7.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(8.ToString());
            }
            else
            {
                textBox1.AppendText(8.ToString());
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = ""; 
            Operation = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Operation = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Operation = "*";
        }
        
        private void button9_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(0.ToString());
            }
            else
            {
                textBox1.AppendText(0.ToString());
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Operation = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
              
        }
    }
}

