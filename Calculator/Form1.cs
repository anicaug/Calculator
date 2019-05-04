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
        Double result = 0;
        String equation = " ";
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                OpEquals.PerformClick();
                equation = button.Text;
                CurrentOperation.Text = result + " " + equation;
                isOperationPerformed = true;
            }
            else
            {
                equation = button.Text;
                result = Double.Parse(textBox1.Text);
                CurrentOperation.Text = result + " " + equation;
                isOperationPerformed = true;
            }
        }

        private void OpEquals_Click(object sender, EventArgs e)
        {
            switch(equation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "x":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(textBox1.Text);
            CurrentOperation.Text = " ";
        }

        private void OpClear_Click(object sender, EventArgs e)
        {
            result = 0;
            textBox1.Text = " ";
            CurrentOperation.Text = " ";
        }

        //string equation = textBox1.Text;
        //string result = new DataTable().ToString().Compute(equation, null);
        //Not sure where to convert the DataTable object to string to get correct output to Calculator Form
        //Compiler error when trying to call the Compute method
        //textBox1.Text = result;
        //    private void Num1_Click(object sender, EventArgs e)
        //    {
        //        textBox1.Text = textBox1.Text + "1";
        //    }

        //    private void Num2_Click(object sender, EventArgs e)
        //    {
        //        textBox1.Text = textBox1.Text + "2";
        //    }

        //private void Num3_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + "3";
        //}

        //private void Num4_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + "4";
        //}

        //private void Num5_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + "5";
        //}

        //private void Num6_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + "6";
        //}

        //private void Num7_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + "7";
        //}

        //private void Num8_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + "8";
        //}

        //private void Num9_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + "9";
        //}

        //private void Num0_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + "0";
        //}





        //private void OpPlus_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + "+";
        //}

        //private void OpMinus_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + "-";
        //}

        //private void OpMultiply_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + "*";
        //}

        //private void OpDivide_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + "/";
        //}

        //private void OpDecimal_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + ".";
        //}
    }
}
