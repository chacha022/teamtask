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
    public partial class Form1 : Form
    {
        private Boolean m_blLoginCheck = false;


        public Boolean LoginCheck
        {
            get { return m_blLoginCheck; }
            set { m_blLoginCheck = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 _Form2 = new Form2(this);
            _Form2.ShowDialog();
            if (!m_blLoginCheck) this.Close();
        }
    

        private void naver_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.naver.com/");
        }

        private void google_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }

        private void waffle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://waffle.wku.ac.kr/lms/login.jsp");
        }

        private void wku_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.wku.ac.kr/index.php");
        }

        private void logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃하였습니다.\n로그인화면으로 전환합니다.");

            Form2 _Form2 = new Form2(this);
            _Form2.ShowDialog();
        }
    }
}
