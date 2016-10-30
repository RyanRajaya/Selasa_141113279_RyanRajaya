using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Font Cek = richTextBox1.SelectionFont;
            if (Cek != null)
            {
                richTextBox1.SelectionFont = new Font(Cek, Cek.Style ^ FontStyle.Bold);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Font Cek = richTextBox1.SelectionFont;
            if (Cek != null)
            {
                richTextBox1.SelectionFont = new Font(Cek, Cek.Style ^ FontStyle.Italic);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Font Cek = richTextBox1.SelectionFont;
            if (Cek != null)
            {
                richTextBox1.SelectionFont = new Font(Cek, Cek.Style ^ FontStyle.Underline);
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void UbahSetUkuran()
        {
            Font Lama, Baru;
            string NamaFont;
            float ukuran = 12;
            FontStyle jenis = 0;
            byte charset = 0;

            NamaFont = toolStripComboBox1.Text;
            if (string.IsNullOrEmpty(toolStripComboBox2.Text))
            {
                ukuran = 12;
            }
            else
            {
                ukuran = float.Parse(toolStripComboBox2.Text);
            }

            Lama = richTextBox1.SelectionFont;
            
            if (Lama == null)
            {
                jenis = FontStyle.Regular;
            }
            else
            {
                jenis = Lama.Style;
                charset = Lama.GdiCharSet;
            }

            Baru = new Font(NamaFont, ukuran, jenis, GraphicsUnit.Point, charset);
            richTextBox1.SelectionFont = Baru;
            richTextBox1.Focus();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily tulisan in FontFamily.Families)
            {
                toolStripComboBox1.Items.Add(tulisan.Name);
            }

            for (int i = 0 ;i < 73 ; i++)
            {
                toolStripComboBox2.Items.Add(i);
            }

            toolStripComboBox1.Text = richTextBox1.Font.Name.ToString();
            toolStripComboBox2.Text = richTextBox1.Font.Size.ToString();

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UbahSetUkuran();
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UbahSetUkuran();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var warna = new ColorDialog();
            if (warna.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = warna.Color;
            }
        }
    }
}
