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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Num1_Click(object sender, EventArgs e)
        {
               textBox1.Text = textBox1.Text + "1";
          
        }

        private void Num2_Click(object sender, EventArgs e)
        {
               textBox1.Text = textBox1.Text + "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "9";
        }

        private void Num0_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "0";
        }

        private void OpEquals_Click(object sender, EventArgs e)
        {
                string equation = textBox1.Text;
                //string result = new DataTable().ToString().Compute(equation, null);
                //Not sure where to convert the DataTable object to string to get correct output to Calculator Form
                //Compiler error when trying to call the Compute method
                //textBox1.Text = result;
        }

        private void OpClear_Click(object sender, EventArgs e)
        {
                textBox1.Text = " ";
        }

        private void OpPlus_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "+";
        }

        private void OpMinus_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "-";
        }

        private void OpMultiply_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "*";
        }

        private void OpDivide_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "/";
        }

        private void OpDecimal_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + ".";
        }
    }
}
