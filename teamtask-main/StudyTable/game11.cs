using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTable
{
    public partial class game11 : Form
    {
        private Stopwatch watch = new Stopwatch();
        private Random rng = new Random();
        private int timerIntervale = 1000;
        private int hits = 0;
        private const int MoleHitCount = 10;
        private int CurrentHitCount = 0;
        private int FailedAttemps = 0;
        private int Gametime = 60;

        public game11()
        {
            InitializeComponent();
            timer1.Interval = timerIntervale;
            this.Click += game11_Click;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = watch.Elapsed.ToString();

            Random random = new Random();
            bt_Mole.Location = new Point(random.Next(0, this.ClientSize.Width - bt_Mole.Width),
                random.Next(0, this.ClientSize.Height - bt_Mole.Height));

            if (Gametime <= 0)
            {
                EndGame();
            }
        }

        private void bt_Mole_Click_1(object sender, EventArgs e)
        {
            hits++;
            label2.Text = hits.ToString();

            if (CurrentHitCount >= MoleHitCount)
            {
                MessageBox.Show("목표를 달성했습니다.");
                bt_Mole.TabStop = true;
            }
        }


        private void game11_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        private void EndGame()
        {
            MessageBox.Show("게임 종료!\n점수 : " + hits.ToString() + "\n게임시간 : " + watch.Elapsed.ToString());
            timer1.Stop();
            watch.Reset();
            CurrentHitCount = 0;
            FailedAttemps = 0;
            label1.Text = "00:00:00";
            label2.Text = $"{CurrentHitCount}";
        }
       

        private void label5_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        private void bt_Start_Click_1(object sender, EventArgs e)
        {
            watch.Start();
        }

        private void bt_Stop_Click_1(object sender, EventArgs e)
        {
            watch.Stop();
        }

        private void bt_Reset_Click_1(object sender, EventArgs e)
        {
            watch.Reset();
        }

        
    }
}
