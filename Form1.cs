using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConfirmExit()
        {
            if (MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void cpybtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDisplay.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            previousOperation = Operation.None;
            txtDisplay.Clear();
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                double d;
                if (!double.TryParse(txtDisplay.Text[txtDisplay.Text.Length - 1].ToString(), out d))
                {
                    previousOperation = Operation.None;
                }
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            else
            {
                previousOperation = Operation.None;
                txtDisplay.Clear();
            }
            }

        private void btn0_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btn1_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void PerformCalculation(Operation previousOperation)
        {
            List<double> lstNums = new List<double>();
            switch (previousOperation)
            {
                case Operation.Add:
                    lstNums = txtDisplay.Text.Split('+').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] + lstNums[1]).ToString();
                    break;
                case Operation.Sub:
                    lstNums = txtDisplay.Text.Split('-').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] - lstNums[1]).ToString();
                    break;
                case Operation.Mul:
                    lstNums = txtDisplay.Text.Split('*').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] * lstNums[1]).ToString();
                    break;
                case Operation Div:
                    try
                    {
                        lstNums = txtDisplay.Text.Split('/').Select(double.Parse).ToList();
                        txtDisplay.Text = (lstNums[0] / lstNums[1]).ToString();
                    }
                    catch(DivideByZeroException)
                    {
                        txtDisplay.Text = "EEEEEEE";
                    }
                    break;
                default:

            }
        }

        private void btn2_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btn3_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btn4_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btn5_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btn6_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btn7_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btn8_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btn9_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
                PerformCalculation(previousOperation);

            previousOperation = Operation.Add;
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
                PerformCalculation(previousOperation);
            else
                return;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
                PerformCalculation(previousOperation);

            previousOperation = Operation.Mul;
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
                PerformCalculation(previousOperation);

            previousOperation = Operation.Div;
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
                PerformCalculation(previousOperation);

            previousOperation = Operation.Sub;
            txtDisplay.Text += (sender as Button).Text;
        }

        enum Operation
        {
            Add,
            Sub,
            Mul,
            Div,
            None
        }

        static Operation previousOperation = Operation.None;

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void dotbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
