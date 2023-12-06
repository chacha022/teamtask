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
    public partial class game22 : Form
    {
        //랜덤 숫자를 생성하기 위한 Random 객체
        private Random rng = new Random();
        /*타이머 간격과 초기 값*/
        private int timer1Intervale = 1000;
        private int timer2Intervale = 800;
        /*게임에서 사용할 변수*/
        private int hits = 0; //두더지를 잡은 횟수
        private const int MoleHitCount = 10;//두더지를 잡을 목표 횟수
        private int CurrentHitCount = 0; //현재 플레이어의 두더지 잡은 횟수
        private int FailedAttemps = 0; //실패한 횟수
        private int Gametime = 60; //게임 시간
        int sec = 0; //게임 시간(초)

        public game22()
        {
            InitializeComponent();
            /*타이머 초기화*/
            timer1.Interval = timer1Intervale;
            timer2.Interval = timer2Intervale;
            //시작 시, 두더지를 숨김
            bt_Mole.Visible = false;
        }

        /*타이머*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            //게임 시간이 0 이하이면, 게임 종료
            if (Gametime <= 0)
            {
                EndGame();
            }
            //게임시간
            sec++;

            //30초를 초과하면 게임 종료
            if (sec > 30)
            {
                EndGame();
            }
            //라벨에 시간 표시
            label1.Text = sec.ToString();
        }

        /*시작 버튼*/
        private void bt_Start_Click(object sender, EventArgs e)
        {
            /*초기화*/
            FailedAttemps = 0; // 실패 횟수 초기화
            Gametime = 60; // 게임 시간 초기화


            // 타이머 시작
            timer1.Start();
            timer2.Start();

            //시간 버튼 클릭 시, 두더지가 보이게 설정
            bt_Mole.Visible = true;
        }

        /*정지 버튼*/
        private void bt_Stop_Click(object sender, EventArgs e)
        {
            /*타이머 정지*/
            timer1.Stop();
            timer2.Stop();
            //정지 버튼 클릭 시, 두더지를 보이지 않게 설정
            bt_Mole.Visible = true;
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            /*변수들 초기화*/
            hits = 0;
            sec = 0; // 특정 게임 로직을 위한 카운터 초기화
            CurrentHitCount = 0;
            FailedAttemps = 0;
            /*라벨 초기화*/
            label1.Text = "00"; // 레이블 초기화
            label2.Text = "0"; // 레이블 초기화

            /*타이머 정지 후 시작*/
            timer1.Stop();
            timer1.Start();
            timer2.Stop();
            timer2.Start();
        }

        /*게임 종료*/
        private void EndGame()
        {
            /*타이머 정지*/
            timer1.Stop();
            timer2.Stop();
            /*메시지 표시*/
            MessageBox.Show("게임 종료!\n점수 : " + hits.ToString() + "\n게임시간 : " + label1.Text.ToString());
            /*게임 변수들 초기화*/
            sec = 0;
            hits = 0;
            CurrentHitCount = 0;
            FailedAttemps = 0;
            /*라벨 초기화*/
            label1.Text = "00";
            label2.Text = $"{CurrentHitCount}";

        }

        /*두더지 버튼*/
        private void bt_Mole_Click(object sender, EventArgs e)
        {
            /*두더지 잡은 횟수 증가*/
            hits++;
            label2.Text = hits.ToString();

            //목표 횟수 달성 시, 메시지 표시
            if (CurrentHitCount >= MoleHitCount)
            {
                MessageBox.Show("목표를 달성했습니다.");
                bt_Mole.TabStop = true;
            }
        }

        /*배경을 클릭 시, 게임 종료*/
        private void label5_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //두더지를 랜덤 위치로 이동
            Random random = new Random();
            bt_Mole.Location = new Point(rng.Next(0, this.ClientSize.Width - bt_Mole.Width),
                rng.Next(0, this.ClientSize.Height + 11 - bt_Mole.Height - 50));
        }
    }
}
