using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormScroll : Form
    {
        public FormScroll()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lbRed.Text = hScrollBar1.Value.ToString();
            richTextBox1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = hScrollBar2.Value.ToString();
            richTextBox1.BackColor = Color.FromArgb(hScrollBar2.Value, hScrollBar1.Value, hScrollBar3.Value);
        }

        private void FormScroll_Load(object sender, EventArgs e)
        {
            hScrollBar1.Value = 25;
            hScrollBar2.Value = 25;
            hScrollBar3.Value = 25;
            richTextBox1.BackColor = Color.FromArgb(25, 25, 25);
            lbRed.Text = "25";
            label2.Text = "25";
            label3.Text = "25";
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = hScrollBar3.Value.ToString();
            richTextBox1.BackColor = Color.FromArgb(hScrollBar3.Value, hScrollBar1.Value, hScrollBar3.Value);
        }
    }
}
