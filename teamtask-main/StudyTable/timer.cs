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
    public partial class timer : Form
    {
        public timer()
        {
            InitializeComponent();
        }

        // 폼이 로드될 때,  첫 번째 사용자 정의 컨트롤을 보이게 하고 나머지는 숨김
        private void radioButton1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Show();
            userControl11.BringToFront();
        }

        // 첫 번째 라디오 버튼이 클릭되면, 첫 번째 사용자 정의 컨트롤을 보이게 하고 나머지는 숨김
        private void radioButton2_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }

        // 두 번째 라디오 버튼이 클릭되면, 두번째 사용자 정의 컨트롤을 보이게 하고 나머지는 숨김
        private void radioButton3_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl11.Hide();
            userControl31.Show();
            userControl31.BringToFront();
        }

        // 세 번째 라디오 버튼이 클릭되면, 세 번째 사용자 정의 컨트롤을 보이게 하고 나머지는 숨김
        private void Form3_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }
    }
}
