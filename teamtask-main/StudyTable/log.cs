using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTable
{
    public partial class log : Form
    {
        private main _Form1;
        public log(main form1)
        {
            InitializeComponent();
            _Form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //해당 폼으로 get,set값 가져옴
            this.ActiveControl = login;
        }

        private void bt_OK()
        {
            //아이디 : user, 비밀번호 : 1234
            if (IDTextBox.Text.Equals("user") && PWTextBox.Text.Equals("1234"))
            {
                //아이디랑 비밀번호가 맞으면 해당 창 닫고 다른 창 열음
                _Form1.LoginCheck = true;
                this.Close();
            }
            else //아이디 또는 패스워드가 틀리면
            {
                MessageBox.Show("아이디 또는 패스워드가 잘못 되었습니다.");

                IDTextBox.Text = "아이디를 입력해주세요.";
                PWTextBox.Text = "비밀번호를 입력해주세요.";
                PWTextBox.PasswordChar = '\0';
                login.Focus();//다시 로그인 폼에 포커스 줌
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            bt_OK();
        }

        private void IDTextBox_Click(object sender, EventArgs e)
        {
            //아이디텍스트박스를 클릭하면 텍스트박스가 빔
            if (IDTextBox.Text == "아이디를 입력해주세요.") IDTextBox.Text = "";
        }

        private void PWTextBox_Click(object sender, EventArgs e)
        {
            //패스워드텍스트박스를 클릭하면 텍스트박스가 빔
            if (PWTextBox.Text == "비밀번호를 입력해주세요.")
            {
                PWTextBox.Text = "";
                //패스워드텍스트박스를 클릭해서 문자를 작성하면 '*'로 출력됨
                PWTextBox.PasswordChar = '*';
            }
        }

        private void IDTextBox_Leave(object sender, EventArgs e)
        {
            //아이디텍스트박스를 떠나면 다시 '아이디를 입력해주세요'뜸
            if (IDTextBox.Text == "") IDTextBox.Text = "아이디를 입력해주세요.";
        }

        private void PWTextBox_Leave(object sender, EventArgs e)
        {
            if (PWTextBox.Text == "")
            {
                //패스워드텍스트박스를 떠나면 다시 '비밀번호를 입력해주세요'뜸
                PWTextBox.Text = "비밀번호를 입력해주세요.";
                PWTextBox.PasswordChar = '\0';
            }
        }

        private void PWTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //PWTextBox에서 값 작성후 엔터키를 누르면 바로 로그인함
            if (e.KeyCode == Keys.Enter)                                               
            {
                bt_OK();
            }
        }
    }
}
