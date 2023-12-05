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
        private Random rng = new Random();
        private int timer1Intervale = 1000;
        private int timer2Intervale = 800;
        private int hits = 0;
        private const int MoleHitCount = 10;
        private int CurrentHitCount = 0;
        private int FailedAttemps = 0;
        private int Gametime = 60;
        int mil = 0;

        public game22()
        {
            InitializeComponent();
            timer1.Interval = timer1Intervale;
            timer2.Interval = timer2Intervale;
            bt_Mole.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Gametime <= 0)
            {
                EndGame();
            }

            mil++;
            if (mil == 30)
            {
                EndGame();
            }

            label1.Text = mil.ToString();
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            // 시작 버튼을 눌렀을 때 초기화 작업 수행
            FailedAttemps = 0; // 실패 횟수 초기화
            Gametime = 60; // 게임 시간 초기화


            // 타이머 시작
            timer1.Start();
            timer2.Start();

            // 랜덤 버튼을 보이게 만듭니다.
            bt_Mole.Visible = true;
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            bt_Mole.Visible = true;
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            hits = 0;
            mil = 0; // 특정 게임 로직을 위한 카운터 초기화
            CurrentHitCount = 0;
            FailedAttemps = 0;
            label1.Text = "00"; // 레이블 초기화
            label2.Text = "0"; // 레이블 초기화

            label2.Text = mil.ToString();
            timer1.Stop();
            timer1.Start();
            timer2.Stop();
            timer2.Start();
        }

        private void EndGame()
        {
            timer1.Stop();
            timer2.Stop();
            MessageBox.Show("게임 종료!\n점수 : " + hits.ToString() + "\n게임시간 : " + label1.Text.ToString());
            mil = 0; // 특정 게임 로직을 위한 카운터 초기화
            hits = 0;
            label2.Text = mil.ToString();
            CurrentHitCount = 0;
            FailedAttemps = 0;
            label1.Text = "00";
            label2.Text = $"{CurrentHitCount}";

        }

        private void bt_Mole_Click(object sender, EventArgs e)
        {
            hits++;
            label2.Text = hits.ToString();

            if (CurrentHitCount >= MoleHitCount)
            {
                MessageBox.Show("목표를 달성했습니다.");
                bt_Mole.TabStop = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            bt_Mole.Location = new Point(rng.Next(0, this.ClientSize.Width - bt_Mole.Width),
                rng.Next(0, this.ClientSize.Height + 11 - bt_Mole.Height - 50));
        }
    }
}
