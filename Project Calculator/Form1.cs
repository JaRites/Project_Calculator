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

        private void DsplyTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNmb1_Click(object sender, EventArgs e)
        {
            if (calc.IsOperationsPressed)
            {
                calc.Num1a = DsplyTxtBx.Text;
                DsplyTxtBx.Text = "";
            }

            DsplyTxtBx.Text += "1";
            calc.IsOperationsPressed = false;
        }

        private void BtnNmb2_Click(object sender, EventArgs e)
        {
            if (calc.IsOperationsPressed)
            {
                calc.Num1a = DsplyTxtBx.Text;
                DsplyTxtBx.Text = "";
            }

            DsplyTxtBx.Text += "2";
            calc.IsOperationsPressed = false;
        }

        private void BtnNmb3_Click(object sender, EventArgs e)
        {
            if (calc.IsOperationsPressed)
            {
                calc.Num1a = DsplyTxtBx.Text;
                DsplyTxtBx.Text = "";
            }

            DsplyTxtBx.Text += "3";
            calc.IsOperationsPressed = false;
        }

        private void BtnNmb4_Click(object sender, EventArgs e)
        {
            if (calc.IsOperationsPressed)
            {
                calc.Num1a = DsplyTxtBx.Text;
                DsplyTxtBx.Text = "";
            }

            DsplyTxtBx.Text += "4";
            calc.IsOperationsPressed = false;
        }

        private void BtnNmb5_Click(object sender, EventArgs e)
        {
            if (calc.IsOperationsPressed)
            {
                calc.Num1a = DsplyTxtBx.Text;
                DsplyTxtBx.Text = "";
            }

            DsplyTxtBx.Text += "5";
            calc.IsOperationsPressed = false;
        }

        private void BtnNmb6_Click(object sender, EventArgs e)
        {
            if (calc.IsOperationsPressed)
            {
                calc.Num1a = DsplyTxtBx.Text;
                DsplyTxtBx.Text = "";
            }

            DsplyTxtBx.Text += "6";
            calc.IsOperationsPressed = false;
        }

        private void BtnNmb7_Click(object sender, EventArgs e)
        {
            if (calc.IsOperationsPressed)
            {
                calc.Num1a = DsplyTxtBx.Text;
                DsplyTxtBx.Text = "";
            }

            DsplyTxtBx.Text += "7";
            calc.IsOperationsPressed = false;
        }

        private void BtnNmb8_Click(object sender, EventArgs e)
        {
            if (calc.IsOperationsPressed)
            {
                calc.Num1a = DsplyTxtBx.Text;
                DsplyTxtBx.Text = "";
            }

            DsplyTxtBx.Text += "8";
            calc.IsOperationsPressed = false;
        }

        private void BtnNmb9_Click(object sender, EventArgs e)
        {
            if (calc.IsOperationsPressed)
            {
                calc.Num1a = DsplyTxtBx.Text;
                DsplyTxtBx.Text = "";
            }

            DsplyTxtBx.Text += "9";
            calc.IsOperationsPressed = false;
        }

        private void BtnNmb0_Click(object sender, EventArgs e)
        {
            if (calc.IsOperationsPressed)
            {
                calc.Num1a = DsplyTxtBx.Text;
                DsplyTxtBx.Text = "";
            }

            DsplyTxtBx.Text += "0";
            calc.IsOperationsPressed = false;
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            if (calc.IsOperationsPressed)
            {
                calc.Num1a = DsplyTxtBx.Text;
                DsplyTxtBx.Text = "";
            }

            DsplyTxtBx.Text += ".";
            calc.IsOperationsPressed = false;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            calc.Operation = "+";
            calc.IsOperationsPressed = true;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            calc.Operation = "-";
            calc.IsOperationsPressed = true;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            calc.Operation = "*";
            calc.IsOperationsPressed = true;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            calc.Operation = "/";
            calc.IsOperationsPressed = true;
        }

        private void BtnPosNeg_Click(object sender, EventArgs e)
        {
            DsplyTxtBx.Text = "-";

            if (DsplyTxtBx.Equals("-"))
            {
                DsplyTxtBx.Text = "";
            }
            calc.IsOperationsPressed = false;
        }

        private void BtbPrcnt_Click(object sender, EventArgs e)
        {
            calc.Operation = "%";
            calc.IsOperationsPressed = true;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (calc.Operation.Equals("+"))
            {
                calc.Num2a = DsplyTxtBx.Text;
                calc.Add();
                DsplyTxtBx.Text = calc.Num2a;
            }

            if (calc.Operation.Equals("-"))
            {
                calc.Num2a = DsplyTxtBx.Text;
                calc.Subtract();
                DsplyTxtBx.Text = calc.Num2a;
            }

            if (calc.Operation.Equals("*"))
            {
                calc.Num2a = DsplyTxtBx.Text;
                calc.Multiply();
                DsplyTxtBx.Text = calc.Num2a;
            }
            if (calc.Operation.Equals("/"))
            {
                calc.Num2a = DsplyTxtBx.Text;
                calc.Divide();
                DsplyTxtBx.Text = calc.Num2a;
            }

            if (calc.Operation.Equals("%"))
            {
                calc.Num2a = DsplyTxtBx.Text;
                calc.Percent();
                DsplyTxtBx.Text = calc.Num2a;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DsplyTxtBx.Text = "";
            calc.Num1a = "";
            calc.Num2a = "";
        }

        private void BtnBckSpc_Click(object sender, EventArgs e)
        {
            if (DsplyTxtBx.Text.Length > 0)
            {
                DsplyTxtBx.Text = DsplyTxtBx.Text.Remove(DsplyTxtBx.Text.Length - 1, 1);
            }
        }

    }
}
