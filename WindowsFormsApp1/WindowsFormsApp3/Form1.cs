using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(groupBox1.Visible == false)
            {
                groupBox1.Show();

            }
            else
            {
                groupBox1.Hide();
                textBox1.Text = null;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == false)
            {
                groupBox2.Show();

            }
            else
            {
                groupBox2.Hide();
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string task = textBox2.Text.ToString();
            string todaytask = textBox3.Text.ToString();
            string reminder = textBox4.Text.ToString();

            if(checkBox1.Checked )
            {
                listBox1.Items.Add(task);
                listBox2.Items.Add(todaytask);
            }
            else
            {
                listBox2.Items.Add(task);
                listBox2.Items.Add(reminder);
            }
            
            textBox2.Clear();
            textBox2.Focus();

            textBox3.Clear();
            textBox3.Focus();

            textBox4.Clear();
            textBox4.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

            if (listBox2.SelectedIndex != -1)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

       
    }
}
