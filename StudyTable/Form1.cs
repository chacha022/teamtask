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

            watch.Image = imageListWatch.Images[0];
            memo.Image = imageListMemo.Images[0];
            calender.Image = imageListCalendar.Images[0];
            calcul.Image = imageListCalculator.Images[0];
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
            MessageBox.Show("         로그아웃하였습니다.\n     로그인화면으로 전환합니다.");

            Form2 _Form2 = new Form2(this);
            _Form2.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("    프로그램을 종료합니다.");
            Application.Exit();
        }

        private void FontChange_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)     //변수 없이 확인버튼을 눌렀을 때만 폰트변경
            {
                logout.Font = fontDialog1.Font;
                logout.ForeColor = fontDialog1.Color;
                game1.Font = fontDialog1.Font;
                game1.ForeColor = fontDialog1.Color;
                game2.Font = fontDialog1.Font;
                game2.ForeColor = fontDialog1.Color;
                groupBox1.Font = fontDialog1.Font;
                groupBox1.ForeColor = fontDialog1.Color;
                groupBox2.Font = fontDialog1.Font;
                groupBox2.ForeColor = fontDialog1.Color;
                Fontlabel.Font = fontDialog1.Font;
                Fontlabel.ForeColor = fontDialog1.Color;
                Colorlabel.Font = fontDialog1.Font;
                Colorlabel.ForeColor = fontDialog1.Color;
                Themalabel.Font = fontDialog1.Font;
                Themalabel.ForeColor = fontDialog1.Color;
                FontChange.Font = fontDialog1.Font;
                FontChange.ForeColor = fontDialog1.Color;
                BackgroundChange.Font = fontDialog1.Font;
                BackgroundChange.ForeColor = fontDialog1.Color;
                domainUpDown1.Font = fontDialog1.Font;
                domainUpDown1.ForeColor = fontDialog1.Color;
                apply.Font = fontDialog1.Font;
                apply.ForeColor = fontDialog1.Color;
                game1.BackColor = colorDialog1.Color;
                game2.BackColor = colorDialog1.Color;
            }
        }

        private void BackgroundChange_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)                      //변수를 통하여 해당 변수의 값이 확인버튼일 때만 색상 변경
            {
                BackColorlabel.BackColor = colorDialog1.Color;
                label1.BackColor = colorDialog1.Color;
                label3.BackColor = colorDialog1.Color;
                groupBox1.BackColor = colorDialog1.Color;
                groupBox2.BackColor = colorDialog1.Color;
                close.BackColor = colorDialog1.Color;
                logout.BackColor = colorDialog1.Color;
                watch.BackColor = colorDialog1.Color;
                calcul.BackColor = colorDialog1.Color;
                calender.BackColor = colorDialog1.Color;
                memo.BackColor = colorDialog1.Color;
                domainUpDown1.BackColor = colorDialog1.Color;
            }
        }

        private void apply_Click(object sender, EventArgs e)
        {
            if (domainUpDown1.SelectedItem == "RED")
            {
                BackColorlabel.BackColor = Color.LightPink; 
                label1.ForeColor = Color.Crimson;

                label1.BackColor = Color.LightPink;
                label3.BackColor = Color.LightPink;
                groupBox1.BackColor = Color.LightPink;
                groupBox2.BackColor = Color.LightPink;
                close.BackColor = Color.LightPink;
                logout.BackColor = Color.LightPink;
                domainUpDown1.BackColor = Color.LightPink;
                game1.BackColor = Color.LightPink;
                game2.BackColor = Color.LightPink;

                watch.BackColor = Color.LightPink;
                calcul.BackColor = Color.LightPink;
                calender.BackColor = Color.LightPink;
                memo.BackColor = Color.LightPink;

                watch.Image = imageListWatch.Images[1];
                memo.Image = imageListMemo.Images[1];
                calender.Image = imageListCalendar.Images[1];
                calcul.Image = imageListCalculator.Images[1];
            }
            else if (domainUpDown1.SelectedItem == "BLUE")
            {
                BackColorlabel.BackColor = Color.LightSkyBlue;
                label1.ForeColor = Color.DarkBlue;

                label1.BackColor = Color.LightSkyBlue;
                label3.BackColor = Color.LightSkyBlue;
                groupBox1.BackColor = Color.LightSkyBlue;
                groupBox2.BackColor = Color.LightSkyBlue;
                close.BackColor = Color.LightSkyBlue;
                logout.BackColor = Color.LightSkyBlue;
                domainUpDown1.BackColor = Color.LightSkyBlue;
                game1.BackColor = Color.LightSkyBlue;
                game2.BackColor = Color.LightSkyBlue;

                watch.BackColor = Color.LightSkyBlue;
                calcul.BackColor = Color.LightSkyBlue;
                calender.BackColor = Color.LightSkyBlue;
                memo.BackColor = Color.LightSkyBlue;

                watch.Image = imageListWatch.Images[2];
                memo.Image = imageListMemo.Images[2];
                calender.Image = imageListCalendar.Images[2];
                calcul.Image = imageListCalculator.Images[2];
            }
            else if (domainUpDown1.SelectedItem == "YELLOW")
            {
                BackColorlabel.BackColor = Color.LightYellow;
                label1.ForeColor = Color.DarkGoldenrod;

                label1.BackColor = Color.LightYellow;
                label3.BackColor = Color.LightYellow;
                groupBox1.BackColor = Color.LightYellow;
                groupBox2.BackColor = Color.LightYellow;
                close.BackColor = Color.LightYellow;
                logout.BackColor = Color.LightYellow;
                domainUpDown1.BackColor = Color.LightYellow;
                game1.BackColor = Color.LightYellow;
                game2.BackColor = Color.LightYellow;

                watch.BackColor = Color.LightYellow;
                calcul.BackColor = Color.LightYellow;
                calender.BackColor = Color.LightYellow;
                memo.BackColor = Color.LightYellow;

                watch.Image = imageListWatch.Images[3];
                memo.Image = imageListMemo.Images[3];
                calender.Image = imageListCalendar.Images[3];
                calcul.Image = imageListCalculator.Images[3];
            }
            else
            {
                BackColorlabel.BackColor = SystemColors.Control;
                label1.ForeColor = Color.Black;

                label1.BackColor = SystemColors.Control;
                label3.BackColor = SystemColors.Control;
                groupBox1.BackColor = SystemColors.Control;
                groupBox2.BackColor = SystemColors.Control;
                close.BackColor = SystemColors.Control;
                logout.BackColor = SystemColors.Control;
                domainUpDown1.BackColor = SystemColors.Control;
                game1.BackColor = SystemColors.Control;
                game2.BackColor = SystemColors.Control;

                watch.BackColor = SystemColors.Control;
                calcul.BackColor = SystemColors.Control;
                calender.BackColor = SystemColors.Control;
                memo.BackColor = SystemColors.Control;

                watch.Image = imageListWatch.Images[0];
                memo.Image = imageListMemo.Images[0];
                calender.Image = imageListCalendar.Images[0];
                calcul.Image = imageListCalculator.Images[0];
            }
        }
    }
}
