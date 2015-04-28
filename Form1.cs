using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


/*Author: Anthony Mount
 * Date:4/10/15*/

namespace Calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent(); 
        }
        Calculator calc = new Calculator();

        //Button Click Events
        private void numOne_Click(object sender, EventArgs e)
        {
            
            if (calc.NonEqualsSolveBool != true)
            {
                calc.numberAdd();
                textBox1.AppendText("1");
            }
            else
            {
                calc.numberAdd();
                calc.CurrentStringValue = textBox1.Text;
                textBox1.Text = "1";
            }
            button20.Focus();
        }

        private void numTwo_Click(object sender, EventArgs e)
        {
            if (calc.NonEqualsSolveBool != true)
            {
                calc.numberAdd();
                textBox1.AppendText("2");
            }
            else
            {
                calc.numberAdd();
                calc.CurrentStringValue = textBox1.Text;
                textBox1.Text = "2";
            }
            button20.Focus();
        }

        private void numThree_Click(object sender, EventArgs e)
        {
            if (calc.NonEqualsSolveBool != true)
            {
                calc.numberAdd();
                textBox1.AppendText("3");
            }
            else
            {
                calc.numberAdd();
                calc.CurrentStringValue = textBox1.Text;
                textBox1.Text = "3";
            }
            button20.Focus();
        }

        private void numFour_Click(object sender, EventArgs e)
        {
            if (calc.NonEqualsSolveBool != true)
            {
                calc.numberAdd();
                textBox1.AppendText("4");
            }
            else
            {
                calc.numberAdd();
                calc.CurrentStringValue = textBox1.Text;
                textBox1.Text = "4";
            }
            button20.Focus();
        }

        private void numFive_Click(object sender, EventArgs e)
        {
            if (calc.NonEqualsSolveBool != true)
            {
                calc.numberAdd();
                textBox1.AppendText("5");
            }
            else
            {
                calc.numberAdd();
                calc.CurrentStringValue = textBox1.Text;
                textBox1.Text = "5";
            }
            button20.Focus();
        }

        private void numSix_Click(object sender, EventArgs e)
        {
            if (calc.NonEqualsSolveBool != true)
            {
                calc.numberAdd();
                textBox1.AppendText("6");
            }
            else
            {
                calc.numberAdd();
                calc.CurrentStringValue = textBox1.Text;
                textBox1.Text = "6";
            }
            button20.Focus();
        }

        private void numSeven_Click(object sender, EventArgs e)
        {
            if (calc.NonEqualsSolveBool != true)
            {
                calc.numberAdd();
                textBox1.AppendText("7");
            }
            else
            {
                calc.numberAdd();
                calc.CurrentStringValue = textBox1.Text;
                textBox1.Text = "7";
            }
            button20.Focus();
        }

        private void numEight_Click(object sender, EventArgs e)
        {
            if (calc.NonEqualsSolveBool != true)
            {
                calc.numberAdd();
                textBox1.AppendText("8");
            }
            else
            {
                calc.numberAdd();
                calc.CurrentStringValue = textBox1.Text;
                textBox1.Text = "8";
            }
            button20.Focus();
        }

        private void numNine_Click(object sender, EventArgs e)
        {
            if (calc.NonEqualsSolveBool != true)
            {
                calc.numberAdd();
                textBox1.AppendText("9");
            }
            else
            {
                calc.numberAdd();
                calc.CurrentStringValue = textBox1.Text;
                textBox1.Text = "9";
            }
            button20.Focus();
        }

        private void numZero_Click(object sender, EventArgs e)
        {
            if (calc.NonEqualsSolveBool != true)
            {
                calc.numberAdd();
                textBox1.AppendText("0");
            }
            else
            {
                calc.numberAdd();
                calc.CurrentStringValue = textBox1.Text;
                textBox1.Text = "0";
            }
            button20.Focus();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            calc.clear();
            button20.Focus();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);

                if (textBox1.TextLength == 0)
                {
                    textBox1.Text = "";
                }
            }
            button20.Focus();
        }

        private void decimal_Click(object sender, EventArgs e)
        {
            if (calc.NonEqualsSolveBool!=true && textBox1.Text!="")
            {
                if (textBox1.Text.IndexOf(".") < 0)
                {
                    textBox1.AppendText(".");
                }
            }  
            else
            {
                 textBox1.Text = "0.";
                 calc.NonEqualsSolveBool = false;
                 calc.SuccessiveOperatorBool = false;
            }          

            button20.Focus();
        }

        //+/-
        private void plusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text.IndexOf("-") >= 0)
                {
                    textBox1.Text = textBox1.Text.Substring(1);
                }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
            button20.Focus();
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            string squareRootStringValue = textBox1.Text;
            double solution = Convert.ToDouble(squareRootStringValue);
            solution=Math.Sqrt(solution);
            textBox1.Text = solution.ToString();
        }
        

        //Operator click events
        private void operatorAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (calc.OperatorUsedBool != true)
                {
                    calc.CurrentStringValue = textBox1.Text;
                    //Console.WriteLine(calc.CurrentStringValue);
                    calc.OperatorUsedBool = true;
                    calc.AddOperatorBool = true;
                    calc.SubOperatorBool = false;
                    calc.MulOperatorBool = false;
                    calc.DivOperatorBool = false;
                    textBox1.Text = "";
                    calc.SuccessiveOperatorBool = true;
                }
                else if (calc.OperatorUsedBool == true && (calc.AddOperatorBool == true || calc.SubOperatorBool == true || calc.MulOperatorBool == true || calc.DivOperatorBool == true))
                {
                    if (calc.SuccessiveOperatorBool == false)
                    {
                        calc.NonEqualsSolveBool = true;
                        solve();
                        calc.SuccessiveOperatorBool = true;
                    }

                    calc.AddOperatorBool = true;
                    calc.SubOperatorBool = false;
                    calc.MulOperatorBool = false;
                    calc.DivOperatorBool = false;
                }
            }
        }
        private void operatorEquals_Click(object sender, EventArgs e)
        {
            solve();
        }
        private void operatorSub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (calc.OperatorUsedBool != true)
                {
                    calc.CurrentStringValue = textBox1.Text;
                    Console.WriteLine(calc.CurrentStringValue);
                    calc.OperatorUsedBool = true;
                    calc.AddOperatorBool = false;
                    calc.SubOperatorBool = true;
                    calc.MulOperatorBool = false;
                    calc.DivOperatorBool = false;
                    textBox1.Text = "";
                    calc.SuccessiveOperatorBool = true;
                }
                else if (calc.OperatorUsedBool == true && (calc.AddOperatorBool == true || calc.SubOperatorBool == true || calc.MulOperatorBool == true || calc.DivOperatorBool == true))
                {
                    if (calc.SuccessiveOperatorBool == false)
                    {
                        calc.NonEqualsSolveBool = true;
                        solve();
                        calc.SuccessiveOperatorBool = true;
                    }
                    calc.AddOperatorBool = false;
                    calc.SubOperatorBool = true;
                    calc.MulOperatorBool = false;
                    calc.DivOperatorBool = false;
                }
            } 
        }

        private void operatorMul_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (calc.OperatorUsedBool != true)
                {
                    calc.CurrentStringValue = textBox1.Text;
                    Console.WriteLine(calc.CurrentStringValue);
                    calc.OperatorUsedBool = true;
                    calc.AddOperatorBool = false;
                    calc.SubOperatorBool = false;
                    calc.MulOperatorBool = true;
                    calc.DivOperatorBool = false;
                    textBox1.Text = "";
                    calc.SuccessiveOperatorBool = true;
                }
                else if (calc.OperatorUsedBool == true && (calc.AddOperatorBool == true || calc.SubOperatorBool == true || calc.MulOperatorBool == true || calc.DivOperatorBool == true))
                {
                    if (calc.SuccessiveOperatorBool == false)
                    {
                        calc.NonEqualsSolveBool = true;
                        solve();
                        calc.SuccessiveOperatorBool = true;
                    }
                    calc.AddOperatorBool = false;
                    calc.SubOperatorBool = false;
                    calc.MulOperatorBool = true;
                    calc.DivOperatorBool = false;
                }
            }            
        }

        private void operatorDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (calc.OperatorUsedBool != true)
                {
                    calc.CurrentStringValue = textBox1.Text;
                    Console.WriteLine(calc.CurrentStringValue);
                    calc.OperatorUsedBool = true;
                    calc.AddOperatorBool = false;
                    calc.SubOperatorBool = false;
                    calc.MulOperatorBool = false;
                    calc.DivOperatorBool = true;
                    textBox1.Text = "";
                    calc.SuccessiveOperatorBool = true;
                }
                else if (calc.OperatorUsedBool == true && (calc.AddOperatorBool == true || calc.SubOperatorBool == true || calc.MulOperatorBool == true || calc.DivOperatorBool == true))
                {
                    if (calc.SuccessiveOperatorBool == false)
                    {
                        calc.NonEqualsSolveBool = true;
                        solve();
                        calc.SuccessiveOperatorBool = true;
                    }
                    calc.AddOperatorBool = false;
                    calc.SubOperatorBool = false;
                    calc.MulOperatorBool = false;
                    calc.DivOperatorBool = true;
                }
            }
        }

        //Keydown events nums and operators
        void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (Control.ModifierKeys != Keys.Shift)
            {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                    case Keys.NumPad0:
                        numZero_Click(sender, e);
                        break;
                    case Keys.D1:
                    case Keys.NumPad1:
                        numOne_Click(sender, e);
                        break;
                    case Keys.D2:
                    case Keys.NumPad2:
                        numTwo_Click(sender, e);
                        break;
                    case Keys.D3:
                    case Keys.NumPad3:
                        numThree_Click(sender, e);
                        break;
                    case Keys.D4:
                    case Keys.NumPad4:
                        numFour_Click(sender, e);
                        break;
                    case Keys.D5:
                    case Keys.NumPad5:
                        numFive_Click(sender, e);
                        break;
                    case Keys.D6:
                    case Keys.NumPad6:
                        numSix_Click(sender, e);
                        break;
                    case Keys.D7:
                    case Keys.NumPad7:
                        numSeven_Click(sender, e);
                        break;
                    case Keys.D8:
                    case Keys.NumPad8:
                        numEight_Click(sender, e);
                        break;
                    case Keys.D9:
                    case Keys.NumPad9:
                        numNine_Click(sender, e);
                        break;
                    case Keys.OemMinus:
                    case Keys.Subtract:
                        operatorSub_Click(sender, e);
                        break;
                    case Keys.Oemplus:
                    case Keys.Enter:
                        operatorEquals_Click(sender, e);
                        break;
                    case Keys.OemQuestion:
                    case Keys.Divide:
                        operatorDiv_Click(sender, e);
                        break;
                    case Keys.Back:
                        back_Click(sender, e);
                        break;
                    case Keys.Add:
                        operatorAdd_Click(sender, e);
                        break;
                    case Keys.Multiply:
                        operatorMul_Click(sender, e);
                        break;
                    case Keys.OemPeriod:
                        decimal_Click(sender, e);
                        break;
                }
            }
            else
            {
                //shift+key handlers
                if (e.KeyCode == Keys.Oemplus)
                {
                    operatorAdd_Click(sender, e);
                }
                if (e.KeyCode == Keys.D8)
                {
                    operatorMul_Click(sender, e);
                }
                if (e.KeyCode == Keys.OemMinus)
                {
                    plusMinus_Click(sender, e);
                }
            }
        }
        private void solve()
        {
            calc.NextStringValue = textBox1.Text;
            calc.solve();
            textBox1.Text = calc.Solution.ToString();

                if (calc.NonEqualsSolveBool == false)
                {
                    calc.OperatorUsedBool = false;
                }
         }
        
    }
}
