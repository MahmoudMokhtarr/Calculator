using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win2From
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        
        struct stNumbers
        {
            public float Number1;
            public float Number2;
        }
        stNumbers Numbers;

        public struct stOperationTypeCalculation
        {

            public Boolean Addition;
            public Boolean Subtraction;
            public Boolean Division;
            public Boolean Multiplication;
            public Boolean Mod ;

        }
        stOperationTypeCalculation OperationType;
        private void Calculator_Load(object sender, EventArgs e)
        {
            stOperationTypeCalculation OperationType;
            OperationType.Addition = false;
            OperationType.Subtraction = false;
            OperationType.Division = false;
            OperationType.Multiplication = false;    
            OperationType.Mod = false;
        }
        private void btnPoint_Click_1(object sender, EventArgs e)
        {
            if (txbStor.Text != "") 
            {
                txbStor.Text += ".";
            }
        }
        private void btn0_Click_1(object sender, EventArgs e)
        {
            if (txbStor.Text == "" || txbStor.Text == "0") 
            {
                txbStor.Text = "0";
                return;
            }

            txbStor.Text += 0;



        }
        private void btn1_Click_1(object sender, EventArgs e)
        {
            if (txbStor.Text == "0")
            {
                txbStor.Text = "1";
                return;
            }

            txbStor.Text += 1;
        }
        private void btn2_Click_1(object sender, EventArgs e)
        {
            if (txbStor.Text == "0")
            {
                txbStor.Text = "2";
                return;
            }
            txbStor.Text += 2;

        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txbStor.Text == "0")
            {
                txbStor.Text = "3";
                return;
            }

            txbStor.Text += 3;

        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (txbStor.Text == "0")
            {
                txbStor.Text = "4";
                return;
            }

            txbStor.Text += 4;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (txbStor.Text == "0")
            {
                txbStor.Text = "5";
                return;
            }

            txbStor.Text += 5;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (txbStor.Text == "0")
            {
                txbStor.Text = "6";
                return;
            }

            txbStor.Text += 6;

        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txbStor.Text == "0")
            {
                txbStor.Text = "7";
                return;
            }

            txbStor.Text += 7;

        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (txbStor.Text == "0")
            {
                txbStor.Text = "8";
                return;
            }

            txbStor.Text += 8;

        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txbStor.Text == "0")
            {
                txbStor.Text = "9";
                return;
            }

            txbStor.Text += 9;

        }
        void StockNumber1()
        {
            Numbers.Number1 = float.Parse(txbStor.Text);

        }
        void StockNumber2()
        {
            Numbers.Number2 = float.Parse(txbStor.Text);
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            OperationType.Addition = true;
            StockNumber1();
            txbResult.Text = txbStor.Text += " + ";
            txbStor.Clear();
            
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            OperationType.Subtraction = true;
            StockNumber1();
            txbResult.Text = txbStor.Text += " - ";
            txbStor.Clear();
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            OperationType.Multiplication = true;
            StockNumber1();
            txbResult.Text = txbStor.Text += " X ";
            txbStor.Clear();
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            OperationType.Division = true;
            StockNumber1();
            txbResult.Text = txbStor.Text += " / ";
            txbStor.Clear();
        }
        private void btnMod_Click_1(object sender, EventArgs e)
        {
            OperationType.Mod = true;
            StockNumber1();
            txbResult.Text = txbStor.Text += " % ";
            txbStor.Clear();
        }
        void ArithmeticOperation()
        {
            StockNumber2();

            float Result = 0;

            if (OperationType.Addition == true)
            {
                Result = (Numbers.Number1 + Numbers.Number2);
                txbStor.Clear();
                txbResult.Text = Result.ToString();
                OperationType.Addition = false;
                return;
            }

            if (OperationType.Subtraction == true)
            {
                Result = (Numbers.Number1 - Numbers.Number2);
                txbStor.Clear();
                txbResult.Text = Result.ToString();
                OperationType.Subtraction = false;

                return;
            }

            if (OperationType.Multiplication == true)
            {
                Result = (Numbers.Number1 * Numbers.Number2);
                txbStor.Clear();
                txbResult.Text = Result.ToString();
                OperationType.Multiplication = false;

                return;
            }

            if (OperationType.Mod == true)
            {
                Result = (Numbers.Number1 % Numbers.Number2);
                txbStor.Clear();
                txbResult.Text = Result.ToString();
                OperationType.Mod = false;

                return;
            }

            if (OperationType.Division == true)
            {
                Result = (Numbers.Number1 / Numbers.Number2);
                txbStor.Clear();
                txbResult.Text = Result.ToString();
                OperationType.Division = false;

                return;
            }
        }
        private void btnCler_Click(object sender, EventArgs e)
        {
            txbResult.Clear();
            txbStor.Clear();
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            ArithmeticOperation();
        }
        private void btn0_KeyDown(object sender, KeyEventArgs e)
        {

             if (e.KeyCode == Keys.NumPad0)
                {
                    btn0_Click_1(sender, e);
                    return;
                }

            if (e.KeyCode == Keys.OemPeriod)
            {
                btnPoint_Click_1(sender, e);
                return;
            }

            if (e.KeyCode == Keys.NumPad1)
                {
                    btn1_Click_1(sender, e);
                    return;
                }

             if (e.KeyCode == Keys.NumPad2)
                {
                    btn2_Click_1(sender, e);
                    return;
                }

             if (e.KeyCode == Keys.NumPad3)
                {
                    btn3_Click(sender, e);
                    return;
                }

             if (e.KeyCode == Keys.NumPad4)
                {
                    btn4_Click(sender, e);
                    return;
                }

             if (e.KeyCode == Keys.NumPad5)
                {
                    btn5_Click(sender, e);
                    return;
                }

            if (e.KeyCode == Keys.NumPad6)
                {
                    btn6_Click(sender, e);
                    return;
                }

            if (e.KeyCode == Keys.NumPad7)
                {
                    btn7_Click(sender, e);
                    return;
                }

            if (e.KeyCode == Keys.NumPad8)
            {
                btn8_Click(sender, e);
                return;
            }

            if (e.KeyCode == Keys.NumPad9)
            {
                btn9_Click(sender, e);
                return;
            }

            if (e.KeyCode == Keys.Add)
            {
                btnPlus_Click(sender, e);
                return;
            }

            if (e.KeyCode == Keys.Subtract)
            {
                btnSubtract_Click(sender, e);
                return;
            }

            if (e.KeyCode == Keys.Divide)
            {
                btnDivision_Click(sender, e);
                return;
            }

            if (e.KeyCode == Keys.Multiply)
            {
                btnMultiply_Click(sender, e);
                return;
            }

            if (e.KeyCode==Keys.D5)
            {
                btnMod_Click_1(sender, e);
                return;
            }


            if (e.KeyCode == Keys.Back)
            {
                btnCler_Click(sender, e);
                return; 
            }

            if (e.KeyCode==Keys.ShiftKey)
            {
                ArithmeticOperation();
            }



        }


    }
}
