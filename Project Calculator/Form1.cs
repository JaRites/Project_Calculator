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

        private void NumberBtn_Click(object sender, EventArgs e)
        {
            if ((DsplyTxtBx.Text == "0") || (calc.IsOperationsPressed))
                DsplyTxtBx.Clear();

            calc.IsOperationsPressed = false;
            Button b = (Button)sender;
            DsplyTxtBx.Text = DsplyTxtBx.Text + b.Text;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            calc.Operation = b.Text;
            calc.Value = float.Parse(DsplyTxtBx.Text);
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
                DsplyTxtBx.Text = (calc.Value + float.Parse(DsplyTxtBx.Text)).ToString();
            }

            if (calc.Operation.Equals("-"))
            {
                DsplyTxtBx.Text = (calc.Value - float.Parse(DsplyTxtBx.Text)).ToString();
            }

            if (calc.Operation.Equals("*"))
            {
                DsplyTxtBx.Text = (calc.Value * float.Parse(DsplyTxtBx.Text)).ToString();
            }
            if (calc.Operation.Equals("/"))
            {
                DsplyTxtBx.Text = (calc.Value / float.Parse(DsplyTxtBx.Text)).ToString();
            }

            if (calc.Operation.Equals("%"))
            {
                DsplyTxtBx.Text = (calc.Value * (float.Parse(DsplyTxtBx.Text)/100)).ToString();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DsplyTxtBx.Text = "";
            calc.Value = 0;
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
