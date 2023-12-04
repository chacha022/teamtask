using System;
using System.Windows.Forms;

namespace MEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 새파일NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(새파일ToolStripMenuItem.Text);
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(열기ToolStripMenuItem.Text);
        }

        private void 닫기CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(닫기ToolStripMenuItem.Text);
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(저장ToolStripMenuItem.Text);
        }

        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(다른이름으로저장ToolStripMenuItem.Text);
        }

        private void 인쇄PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(인쇄ToolStripMenuItem.Text);
        }

        private void 미리보기VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(미리보기ToolStripMenuItem.Text);
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(잘라내기TToolStripMenuItem.Text);
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(복사CToolStripMenuItem.Text);
        }

        private void 붙여놓기PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(붙여놓기PToolStripMenuItem.Text);
        }

        private void 프로그램정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(프로그램정보AToolStripMenuItem.Text);
        }

        private void 실행취소UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(실행취소UToolStripMenuItem.Text);
        }

        private void 잘라내기TToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(잘라내기TToolStripMenuItem1.Text);
        }

        private void 복사CToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(복사CToolStripMenuItem1.Text);
        }

        private void 삭제DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(삭제DToolStripMenuItem.Text);
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(모두선택AToolStripMenuItem.Text);
        }
    }
}