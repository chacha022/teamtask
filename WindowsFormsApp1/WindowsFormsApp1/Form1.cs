using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            monthCalendar1.Size = new Size(300, 300);
            Controls.Add(monthCalendar1);
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar1.SelectionRange.Start == monthCalendar1.SelectionRange.End)
                textBox1.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            else
                textBox1.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "~" + monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value.ToString("yyyy'-'MM'-'dd tttt HH':'mm':'ss");
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           //dateTimePicker2.Format = DateTimePickerFormat.Time;
            //dateTimePicker2.ShowUpDown = true;
            ///dateTimePicker2.Format = DateTimePickerFormat.Custom;
            //dateTimePicker2.ShowUpDown = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
