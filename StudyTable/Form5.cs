using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTable
{
    public partial class Form5 : Form
    {

        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Remainder,
            Result
        }

        enum NumberBase
        {
            Decimal,
            Binary,
            Octal,
            Hexadecimal
        }

        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        int firstOperand = 0;
        int secondOperand = 0;
        double memory = 0;
        bool clear = true;
        NumberBase currentBase = NumberBase.Decimal;

        public Form5()
        {
            InitializeComponent();
            Display.TextChanged += Display_TextChanged;
        }

        private void bt_Result_Click(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(Display.Text);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                Display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                Display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                Display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOperand == 0)
                {
                    Display.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    firstOperand /= secondOperand;
                    Display.Text = firstOperand.ToString();
                }
            }
            else if (currentOperator == Operators.Remainder)
            {
                if (secondOperand == 0)
                {
                    Display.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    firstOperand %= secondOperand;
                    Display.Text = firstOperand.ToString();
                }
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void bt_Subtract_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void bt_Multiply_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void bt_Divide_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void bt_Remainder_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentOperator = Operators.Remainder;
            operatorChangeFlag = true;
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            Display.Text = "0";
        }

        private void bt_Backspace_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
        }

        private void bt_Zero_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "0";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void bt_One_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "1";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void bt_Two_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void bt_Three_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void bt_Four_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void bt_Five_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void bt_Six_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void bt_Seven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void bt_Eight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void bt_Nine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void bt_MC_Click(object sender, EventArgs e)
        {
            memory = 0;
            clear = true;
        }

        private void bt_MR_Click(object sender, EventArgs e)
        {
            Display.Text = Convert.ToString(memory);
            clear = true;
        }

        private void bt_MS_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(Display.Text);
            clear = true;
        }

        private void bt_MP_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(Display.Text);
            memory += num;
            clear = true;
        }

        private void bt_MM_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(Display.Text);
            memory -= num;
            clear = true;
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {
            ConvertAndDisplay();
        }

        private void ConvertAndDisplay()
        {
            string inputText = Display.Text;

            if (string.IsNullOrEmpty(inputText))
            {
                return;
            }

            int decimalNumber;
            if (!Int32.TryParse(inputText, out decimalNumber))
            {
                SetLabels("유효한 숫자가 아닙니다.", "유효한 숫자가 아닙니다.", "유효한 숫자가 아닙니다.", "유효한 숫자가 아닙니다.");
                return;
            }

            SetLabels(
                Convert.ToString(decimalNumber, 2),
                Convert.ToString(decimalNumber, 8),
                decimalNumber.ToString(),
                Convert.ToString(decimalNumber, 16)
                ); ;
        }

        private void SetLabels(string binary, string octal, string decimalValue, string hexadecimal)
        {
            Trans2.Text = binary;
            Trans8.Text = octal;
            Trans10.Text = decimalValue;
            Trans16.Text = hexadecimal;
        }
    }
}
