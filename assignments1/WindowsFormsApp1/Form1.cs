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
        double number;
        String s;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            switch (s)
            {
                case "+":
                    number = num1 + num2;
                    label.Text = number.ToString();
                    break;
                case "-":
                    number = num1 - num2;
                    label.Text = number.ToString();
                    break;
                case "*":
                    number = num1 * num2;
                    label.Text = number.ToString();
                    break;
                case "/":
                    number = num1 / num2;
                    label.Text = number.ToString();
                    break;
                default:
                    label.Text = "0";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s = "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s = "/";
        }
    }
}
