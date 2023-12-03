using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class UserControl3 : UserControl
    {
        private int remainingTimeInSeconds;
        private Color originalLabelColor;

        public UserControl3()
        {
            InitializeComponent();
            originalLabelColor = label1.ForeColor;

        }

        private string FormatTime(int seconds)
        {
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int remainingSeconds = seconds % 60;
            return $"{hours:D2}:{minutes:D2}:{remainingSeconds:D2}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ParseTime(maskedTextBox1.Text, out remainingTimeInSeconds))
            {
                // Label에 초기값 설정
                label1.Text = FormatTime(remainingTimeInSeconds);

                // 타이머 시작
                timer1.Start();

                label1.ForeColor = originalLabelColor;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingTimeInSeconds > 0)
            {
                remainingTimeInSeconds--;
                label1.Text = FormatTime(remainingTimeInSeconds);

                if (remainingTimeInSeconds <= 5)
                {
                    // Change label text color to red
                    label1.ForeColor = Color.Red;
                }
            }
            else
            {
                // 남은 시간이 0이 되면 타이머 중지
                timer1.Stop();

                label1.ForeColor = originalLabelColor;
            }
        }

        private bool ParseTime(string timeString, out int seconds)
        {
            string[] timeComponents = timeString.Split(':');
            if (timeComponents.Length == 3 &&
                int.TryParse(timeComponents[0], out int hours) &&
                int.TryParse(timeComponents[1], out int minutes) &&
                int.TryParse(timeComponents[2], out int secs))
            {
                seconds = hours * 3600 + minutes * 60 + secs;
                return true;
            }
            else
            {
                seconds = 0;
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 타이머 중지
            timer1.Stop();

            // 남은 시간 초기화
            remainingTimeInSeconds = 0;

            // Label 초기화
            label1.Text = "00:00:00";

            label1.ForeColor = originalLabelColor;
        }
    }
}
