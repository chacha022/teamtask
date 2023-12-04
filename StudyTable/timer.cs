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

        private void radioButton1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl11.Hide();
            userControl31.Show();
            userControl31.BringToFront();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }
    }
}
