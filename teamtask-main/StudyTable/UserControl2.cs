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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        int mil = 0;
        int sec = 0;
        int min = 0;
        int hour = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mil = 0;
            sec = 0;
            min = 0;
            hour = 0;

            label2.Text = hour.ToString() + " : " + min.ToString() + " : " + sec.ToString() + " : " + mil.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mil++;
            if (mil == 100)
            {
                sec++;
                mil = 0;
            }
            if (sec == 60)
            {
                min++;
                sec = 0;
            }
            if (min == 60)
            {
                hour++;
                min = 0;
            }

            label2.Text = hour.ToString() + " : " + min.ToString() + " : " + sec.ToString() + " : " + mil.ToString();

        }
    }
}
