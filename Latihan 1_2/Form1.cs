using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int z = Convert.ToInt32(label1.Text);
            int x = Convert.ToInt32(label2.Text);

            int n = Math.Abs(z - x);
            if (n != 0)
            {
                dateTimePicker1.MinDate = DateTime.Now.AddYears(-(n));
                dateTimePicker1.MaxDate = DateTime.Now.AddYears(n);
            }
            else
            {
                dateTimePicker1.MinDate = DateTime.Now;
                dateTimePicker1.MaxDate = DateTime.Now;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = ((VScrollBar)sender).Value.ToString();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = ((VScrollBar)sender).Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
