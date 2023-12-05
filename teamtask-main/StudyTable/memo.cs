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
    public partial class memo : Form
    {
        public memo()
        {
            InitializeComponent();
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

        private void memo_Load(object sender, EventArgs e)
        {

        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contents.Text = "";
        }
        string filename = "";

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            string Data = System.IO.File.ReadAllText(filename);
            Contents.Text = Data;
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
                this.saveFileDialog1.ShowDialog();
                System.IO.File.WriteAllText(saveFileDialog1.FileName, Contents.Text);
                filename = saveFileDialog1.FileName;
            }
            else
            {
                System.IO.File.WriteAllText(filename, Contents.Text);
            }
        }

        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            this.saveFileDialog1.ShowDialog();
            System.IO.File.WriteAllText(saveFileDialog1.FileName, Contents.Text);
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 자동줄바꿈WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contents.WordWrap = !Contents.WordWrap;
        }

        private void 글꼴FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            Contents.Font = fontDialog1.Font;
        }

        private void 상태표시줄SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = 상태표시줄SToolStripMenuItem.Checked;
        }

        private void 메모장정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help form = new Help();
            form.ShowDialog();
        }
    }
}
