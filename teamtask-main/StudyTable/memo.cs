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
            // 1. 사용자에게 열 파일을 선택하게 함
            openFileDialog1.ShowDialog();
            // 1-1. 선택한 파일명을 변수에 저장함
            filename = openFileDialog1.FileName;
            // 2. 파일의 내용을 읽음
            string Data = System.IO.File.ReadAllText(filename);
            // 3. 화면에 표시함
            Contents.Text = Data;
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 그렇지 않으면 다른이름으로 저장과 동일
            if (filename == "")
            {
                // 1. 사용자에게 저장할 파일을 선택하게 함
                this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
                this.saveFileDialog1.ShowDialog();
                // 2. 파일을 저장함
                System.IO.File.WriteAllText(saveFileDialog1.FileName, Contents.Text);
                // 3. 파일명을 기억함
                filename = saveFileDialog1.FileName;
            }
            else
            {
                // 1. 해당 파일명으로 현재 내용을 저장

                // 2. 파일을 저장함
                System.IO.File.WriteAllText(filename, Contents.Text);
            }
        }

        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. 사용자에게 저장할 파일을 선택하게 함
            this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            this.saveFileDialog1.ShowDialog();
            // 2. 파일을 저장함
            System.IO.File.WriteAllText(saveFileDialog1.FileName, Contents.Text);
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 프로그램 종료
            Close();
        }

        private void 자동줄바꿈WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contents.WordWrap = !Contents.WordWrap;
            /* 
            if(Contents.WordWrap == true)
            {
              Contents.WordWrap = false;
             }
            else
            {
              Contents.WordWrap= true;
             } 
             */
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
