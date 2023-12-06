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
    public partial class calculator : Form
    {

        enum Operators // 사칙 연산 열거형
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Remainder,
            Result
        }

        enum NumberBase // 진법 변환을 위한 열거형
        {
            Decimal,
            Binary,
            Octal,
            Hexadecimal
        }

        Operators currentOperator = Operators.None; // 현재 연산자
        Boolean operatorChangeFlag = false; // 연산자 변경 플래그
        int firstOperand = 0; // 첫번째 피연산자
        int secondOperand = 0; // 두번째 피연산자
        double memory = 0; // 메모리
        bool clear = true; // 화면 초기화 여부
        NumberBase currentBase = NumberBase.Decimal; // 현재 숫자 진법

        public calculator()
        {
            InitializeComponent();
            // 화면 텍스트가 변경될 때 이벤트 핸들러 연결
            Display.TextChanged += Display_TextChanged;
        }

        private void bt_Result_Click(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(Display.Text); // 입력 받은 문자를 숫자로 변환
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand; // 연산 수행
                Display.Text = firstOperand.ToString(); // 수행된 숫자를 문자로 변경하여 출력
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
            // 현재 화면의 값을 첫번째 피연산자로 설정하고 덧셈 연산자로 변경
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
            // 모든 연산자와 피연산자 초기화, 화면에 0 표시
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            Display.Text = "0";
        }

        private void bt_Backspace_Click(object sender, EventArgs e)
        {
            // 화면에서 마지막 글자 삭제
            Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
        }

        private void bt_Zero_Click(object sender, EventArgs e)
        {
            // 연산자 변경 플래그 확인 후 화면에 0 추가
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
            memory = 0; // 메모리 값을 0으로 초기화
            clear = true; // 화면 클리어 플래그 설정
        }

        private void bt_MR_Click(object sender, EventArgs e)
        {
            Display.Text = Convert.ToString(memory); // 메모리 값 화면에 표시
            clear = true;
        }

        private void bt_MS_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(Display.Text); // 현재 화면의 값 메모리에 저장
            clear = true;
        }

        private void bt_MP_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(Display.Text); // 현재 화면의 값
            memory += num; // 메모리에 더하기
            clear = true;
        }

        private void bt_MM_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(Display.Text); // 현재 화면의 값
            memory -= num; // 메모리에서 빼기
            clear = true;
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {
            // 숫자 진법 변환 함수 호출
            ConvertAndDisplay();
        }

        // 숫자 진법 변환 및 화면 표시
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

            // 숫자 진법에 따라 레이블 설정
            SetLabels(
                Convert.ToString(decimalNumber, 2),
                Convert.ToString(decimalNumber, 8),
                decimalNumber.ToString(),
                Convert.ToString(decimalNumber, 16)
                ); ;
        }

        // 진법 변환 레이블 설정 함수
        private void SetLabels(string binary, string octal, string decimalValue, string hexadecimal)
        {
            Trans2.Text = binary;
            Trans8.Text = octal;
            Trans10.Text = decimalValue;
            Trans16.Text = hexadecimal;
        }
    }
}
