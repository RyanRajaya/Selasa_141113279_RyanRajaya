using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalenderUtama.ScrollChange = 6;

            int n = 2021;
            while (n>=1996)
            {
                DateTime awal = new DateTime(n, 1, 1);
                DateTime akhir = new DateTime(n, 12, 31);
                for (int i = 0; i < akhir.DayOfYear; i++)
                {
                    if (awal.DayOfWeek.ToString()=="Monday"||awal.DayOfWeek.ToString()=="Tuesday")
                    {
                        CalenderUtama.AddBoldedDate(awal);
                    }
                    awal = awal.AddDays(1);
                }

                CalenderUtama.AddBoldedDate(new DateTime(n, 9, 1));
                n--;
            }

            CalenderUtama.UpdateBoldedDates();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z = 2021;
            int tanggal = Convert.ToInt32(numericUpDown1.Value.ToString());
            int bulan = domainUpDown1.SelectedIndex;

            int[] bulanLengkap = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            while (z>=1996)
            {
                CalenderUtama.AddBoldedDate(new DateTime(z, bulanLengkap[bulan], tanggal));
                z--;
            }

            CalenderUtama.UpdateBoldedDates();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int z = 2021;
            int tanggal = Convert.ToInt32(numericUpDown1.Value.ToString());
            int bulan = domainUpDown1.SelectedIndex;

            int[] bulanLengkap = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            while (z >= 1996)
            {
                CalenderUtama.RemoveBoldedDate(new DateTime(z, bulanLengkap[bulan], tanggal));
                z--;
            }

            CalenderUtama.UpdateBoldedDates();
        }
    }
}
