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
        //로그인폼에서 처음 값은 false
        private Boolean m_blLoginCheck = false;


        public Boolean LoginCheck
        {
            //로그인 폼에서 로그인이 되는지 알려주는 값
            get { return m_blLoginCheck; }
            set { m_blLoginCheck = value; }
        }

        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //log화면을 먼저 보여주도록 해줌
            log _Form2 = new log(this);
            _Form2.ShowDialog();
            if (!m_blLoginCheck) this.Close();

            //화면이 로드됨과 동시에 시계, 달력, 메모장, 계산기 사진을 이미지리스트중 [0]을 보여줌
            watch.Image = imageListWatch.Images[0];
            memo.Image = imageListMemo.Images[0];
            calendar.Image = imageListCalendar.Images[0];
            calcul.Image = imageListCalculator.Images[0];
        }
    

        private void naver_Click(object sender, EventArgs e)//네이버 페이지로 연결
        {
            System.Diagnostics.Process.Start("https://www.naver.com/");
        }

        private void google_Click(object sender, EventArgs e)//구글 페이지로 연결
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }

        private void waffle_Click(object sender, EventArgs e)//원광대학교 와플페이지로 연결
        {
            System.Diagnostics.Process.Start("https://waffle.wku.ac.kr/lms/login.jsp");
        }

        private void wku_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.wku.ac.kr/index.php");
        }

        private void logout_Click(object sender, EventArgs e)//원광대학교 홈페이지 연결
        {
            MessageBox.Show("         로그아웃하였습니다.\n     로그인화면으로 전환합니다.");
            //로그아웃 되면 메시지박스가 뜬 후 log폼으로 포커스 됨
            log _Form2 = new log(this);
            _Form2.ShowDialog();
        }

        //close버튼을 클릭하면 프로그램 종료
        private void close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("    프로그램을 종료합니다.");
            Application.Exit();
        }

        private void FontChange_Click(object sender, EventArgs e)
        {
            //변수 없이 확인버튼을 눌렀을 때만 폰트변경
            if (fontDialog1.ShowDialog() == DialogResult.OK)     
            {
                //바뀌는 폰트들 작성
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

        //반복사용되는 색상, 작성 길이를 줄이기 위해 변수 생성
        Color RED = Color.LightPink;
        Color BLUE = Color.LightSkyBlue;
        Color YELLOW = Color.LightYellow;
        Color ORIGIN = SystemColors.Control;

        //바뀌는 배경색상들을 묶은 변수
        public void BackColor(Color color)
        {
            //배경색상이 바뀔때 해당 변수들의 배경색이 변함
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

        //변수 없이 확인버튼을 눌렀을 때만 배경색상변경
        private void BackgroundChange_Click(object sender, EventArgs e)
        {
            //확인버튼이 눌리면 BackColor변수의 값들 선택색상으로 바뀜
            if (colorDialog1.ShowDialog() == DialogResult.OK)                      //변수를 통하여 해당 변수의 값이 확인버튼일 때만 색상 변경
            {
                BackColor(colorDialog1.Color);
            }
        }

        private void apply_Click(object sender, EventArgs e)
        {
            //테마 변경 창에서 'RED'가 선택되면 아래 색상과 이미지로 바꾸어줌
            if (domainUpDown1.SelectedItem == "RED")
            {
                //BackColor변수의 값들 RED변수의 색상으로 바뀜
                BackColor(RED);
                //StudyDesk의 색상 해당색상으로 변경
                label1.ForeColor = Color.Crimson;

                //시계, 메모장, 달력, 계산기의 이미지를 이미지 리스트중 [1]로 변경
                watch.Image = imageListWatch.Images[1];
                memo.Image = imageListMemo.Images[1];
                calendar.Image = imageListCalendar.Images[1];
                calcul.Image = imageListCalculator.Images[1];
            }
            //테마 변경 창에서 'BLUE'가 선택되면 아래 색상과 이미지로 바꾸어줌
            else if (domainUpDown1.SelectedItem == "BLUE")
            {
                //BackColor변수의 값들 BLUE변수의 색상으로 바뀜
                BackColor(BLUE);
                //StudyDesk의 색상 해당색상으로 변경
                label1.ForeColor = Color.Blue;

                //시계, 메모장, 달력, 계산기의 이미지를 이미지 리스트중 [2]로 변경
                watch.Image = imageListWatch.Images[2];
                memo.Image = imageListMemo.Images[2];
                calendar.Image = imageListCalendar.Images[2];
                calcul.Image = imageListCalculator.Images[2];
            }
            //테마 변경 창에서 'YELLOW'가 선택되면 아래 색상과 이미지로 바꾸어줌
            else if (domainUpDown1.SelectedItem == "YELLOW")
            {
                //BackColor변수의 값들 YELLOW변수의 색상으로 바뀜
                BackColor(YELLOW);
                //StudyDesk의 색상 해당색상으로 변경
                label1.ForeColor = Color.DarkGoldenrod;

                //시계, 메모장, 달력, 계산기의 이미지를 이미지 리스트중 [3]로 변경
                watch.Image = imageListWatch.Images[3];
                memo.Image = imageListMemo.Images[3];
                calendar.Image = imageListCalendar.Images[3];
                calcul.Image = imageListCalculator.Images[3];
            }
            else
            {
                //BackColor변수의 값들 ORIGIN변수의 색상으로 바뀜
                BackColor(ORIGIN);
                //StudyDesk의 색상 해당색상으로 변경
                label1.ForeColor = Color.Black;

                //시계, 메모장, 달력, 계산기의 이미지를 이미지 리스트중 [0]로 변경
                watch.Image = imageListWatch.Images[0];
                memo.Image = imageListMemo.Images[0];
                calendar.Image = imageListCalendar.Images[0];
                calcul.Image = imageListCalculator.Images[0];
            }
        }

        //시계 폼 생성 후 보여줌
        private void watch_Click(object sender, EventArgs e)
        {
            timer _Form = new timer();
            _Form.ShowDialog();
        }

        //달력 폼 생성 후 보여줌
        private void calendar_Click(object sender, EventArgs e)
        {
            calendar _Form = new calendar();
            _Form.ShowDialog();
        }

        //계산기 폼 생성 후 보여줌
        private void calcul_Click(object sender, EventArgs e)
        {
            calculator _Form = new calculator();
            _Form.ShowDialog();
        }

        //메모장 폼 생성 후 보여줌
        private void memo_Click(object sender, EventArgs e)
        {
            memo _Form = new memo();
            _Form.ShowDialog();
        }

        //두더지게임(normal) 폼 생성 후 보여줌
        private void game1_Click(object sender, EventArgs e)
        {
            game11 _Form = new game11();
            _Form.ShowDialog();
        }

        //두더지게임(hard) 폼 생성 후 보여줌
        private void game2_Click(object sender, EventArgs e)
        {
            game22 _Form = new game22();
            _Form.ShowDialog();
        }
    }
}
