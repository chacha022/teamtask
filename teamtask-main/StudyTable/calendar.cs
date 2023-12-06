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
    public partial class calendar : Form
    {
        public calendar()
        {
            InitializeComponent(); // 폼 초기화
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString(); // 현재 날짜와 시간
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false) // groupBox1이 보이지 않는 상태일 때
            {
                groupBox1.Show(); // groupBox1을 화면에 표시

            }
            else // 만약 groupBox1이 보이는 상태라면
            {
                groupBox1.Hide(); // groupBox1을 화면에서 숨김
                textBox1.Text = null; // 초기화
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // monthCalendar1의 선택된 날짜를 문자열로 변환하여 textBox1의 Text 속성에 설정
            textBox1.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == false) //groupBox2가 보이지 않는 상태일때
            {
                groupBox2.Show(); // groupBox2을 화면에 표시

            }
            else
            {
                groupBox2.Hide(); // groupBox2를 화면에 표시
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textBox2, textBox3, textBox4에서 문자열을 가져와 변수에 저장
            string task = textBox2.Text.ToString();
            string todaytask = textBox3.Text.ToString();
            string reminder = textBox4.Text.ToString();

            if (checkBox1.Checked) // checkBox1이 체크되어 있으면 listBox1에 task를,
            {
                listBox1.Items.Add(task);
                listBox2.Items.Add(todaytask);
            }
            else  // 그렇지 않으면 listBox2에 task와 reminder를 추가
            {
                listBox2.Items.Add(task);
                listBox2.Items.Add(reminder);
            }

            // 각각의 textBox를 초기화하고 포커스 설정
            textBox2.Clear();
            textBox2.Focus();

            textBox3.Clear();
            textBox3.Focus();

            textBox4.Clear();
            textBox4.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // 만약 listBox1에서 선택된 항목이 있다면 해당 항목을 제거
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

            if (listBox2.SelectedIndex != -1) // 만약 listBox2에서 선택된 항목이 있다면 해당 항목을 제거
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }
    }
}
