using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Calculator
{
    public partial class Form1 : Form
    {
        ClassA calc = new ClassA();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNmb1_Click(object sender, EventArgs e)
        {
            AppendDisplay("1");
        }

        private void BtnNmb2_Click(object sender, EventArgs e)
        {
            AppendDisplay("2");
        }

        private void BtnNmb3_Click(object sender, EventArgs e)
        {
            AppendDisplay("3");
        }

        private void BtnNmb4_Click(object sender, EventArgs e)
        {
            AppendDisplay("4");
        }

        private void BtnNmb5_Click(object sender, EventArgs e)
        {
            AppendDisplay("5");
        }

        private void BtnNmb6_Click(object sender, EventArgs e)
        {
            AppendDisplay("6");
        }

        private void BtnNmb7_Click(object sender, EventArgs e)
        {
            AppendDisplay("7");
        }

        private void BtnNmb8_Click(object sender, EventArgs e)
        {
            AppendDisplay("8");
        }

        private void BtnNmb9_Click(object sender, EventArgs e)
        {
            AppendDisplay("9");
        }

        private void BtnNmb0_Click(object sender, EventArgs e)
        {
            AppendDisplay("0");
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            AppendDisplay(".");
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            calc.operation = "+";
            calc.isOperationsPressed = true;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            calc.operation. = "-";
            calc.isOperationsPressed = true;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (calc.operation.Equals("+"))
            {
                calc.Add();
            }
            if (calc.operation.Equals("-"))
            {
                calc.Subtract();
            }
        }

        private void AppendDisplay(String number)
        {
            if (calc.isOperationsPressed)
            {
                calc.Num1 = DsplyTxtBx.Text;
                DsplyTxtBx.Text = "";
            }

            DsplyTxtBx.Text += number;
            calc.isOperationsPressed = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
