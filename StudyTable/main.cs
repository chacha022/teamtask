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
    public partial class main : Form
    {
        private Boolean m_blLoginCheck = false;


        public Boolean LoginCheck
        {
            get { return m_blLoginCheck; }
            set { m_blLoginCheck = value; }
        }

        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log _Form2 = new log(this);
            _Form2.ShowDialog();
            if (!m_blLoginCheck) this.Close();

            watch.Image = imageListWatch.Images[0];
            memo.Image = imageListMemo.Images[0];
            calendar.Image = imageListCalendar.Images[0];
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

            log _Form2 = new log(this);
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

        Color RED = Color.LightPink;
        Color BLUE = Color.LightSkyBlue;
        Color YELLOW = Color.LightYellow;
        Color ORIGIN = SystemColors.Control;

        public void BackColor(Color color)
        {
            BackColorlabel.BackColor = color;
            label1.BackColor = color;
            label3.BackColor = color;
            groupBox1.BackColor = color;
            groupBox2.BackColor = color;
            close.BackColor = color;
            logout.BackColor = color;

            watch.BackColor = color;
            calcul.BackColor = color;
            calendar.BackColor = color;
            memo.BackColor = color;

            domainUpDown1.BackColor = color;
            game1.BackColor = color;
            game2.BackColor = color;
        }

        private void BackgroundChange_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)                      //변수를 통하여 해당 변수의 값이 확인버튼일 때만 색상 변경
            {
                BackColor(colorDialog1.Color);
            }
        }

        private void apply_Click(object sender, EventArgs e)
        {
            if (domainUpDown1.SelectedItem == "RED")
            {
                BackColor(RED);
                label1.ForeColor = Color.Crimson;

                watch.Image = imageListWatch.Images[1];
                memo.Image = imageListMemo.Images[1];
                calendar.Image = imageListCalendar.Images[1];
                calcul.Image = imageListCalculator.Images[1];
            }
            else if (domainUpDown1.SelectedItem == "BLUE")
            {
                BackColor(BLUE);
                label1.ForeColor = Color.Blue;

                watch.Image = imageListWatch.Images[2];
                memo.Image = imageListMemo.Images[2];
                calendar.Image = imageListCalendar.Images[2];
                calcul.Image = imageListCalculator.Images[2];
            }
            else if (domainUpDown1.SelectedItem == "YELLOW")
            {
                BackColor(YELLOW);
                label1.ForeColor = Color.DarkGoldenrod;

                watch.Image = imageListWatch.Images[3];
                memo.Image = imageListMemo.Images[3];
                calendar.Image = imageListCalendar.Images[3];
                calcul.Image = imageListCalculator.Images[3];
            }
            else
            {
                BackColor(ORIGIN);
                label1.ForeColor = Color.Black;

                watch.Image = imageListWatch.Images[0];
                memo.Image = imageListMemo.Images[0];
                calendar.Image = imageListCalendar.Images[0];
                calcul.Image = imageListCalculator.Images[0];
            }
        }

        private void watch_Click(object sender, EventArgs e)
        {
            timer _Form = new timer();
            _Form.ShowDialog();
        }

        private void calendar_Click(object sender, EventArgs e)
        {
            calendar _Form = new calendar();
            _Form.ShowDialog();
        }

        private void calcul_Click(object sender, EventArgs e)
        {
            calculator _Form = new calculator();
            _Form.ShowDialog();
        }

        private void memo_Click(object sender, EventArgs e)
        {

        }
    }
}
