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
    public partial class Form2 : Form
    {
        private Form1 _Form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _Form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = login;
        }

        private void bt_OK()
        {
            if (IDTextBox.Text.Equals("user") && PWTextBox.Text.Equals("1234"))
            {
                _Form1.LoginCheck = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("아이디 또는 패스워드가 잘못 되었습니다.");

                IDTextBox.Text = "아이디를 입력해주세요.";
                PWTextBox.Text = "비밀번호를 입력해주세요.";
                PWTextBox.PasswordChar = '\0';
                login.Focus();
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            bt_OK();
        }

        private void IDTextBox_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "아이디를 입력해주세요.") IDTextBox.Text = "";
        }

        private void PWTextBox_Click(object sender, EventArgs e)
        {
            if (PWTextBox.Text == "비밀번호를 입력해주세요.")
            {
                PWTextBox.Text = "";
                PWTextBox.PasswordChar = '*';
            }
        }

        private void IDTextBox_Leave(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "") IDTextBox.Text = "아이디를 입력해주세요.";
        }

        private void PWTextBox_Leave(object sender, EventArgs e)
        {
            if (PWTextBox.Text == "")
            {
                PWTextBox.Text = "비밀번호를 입력해주세요.";
                PWTextBox.PasswordChar = '\0';
            }
        }
    }
}
