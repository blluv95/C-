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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            convertText();
            if (rdCong.Checked == true)
            {
                editTextKQ.Text = (a + b).ToString() + "";
            }
            else if (rdTru.Checked == true)
            {
                editTextKQ.Text = (a - b).ToString() + "";
            }
            else if (rdNhan.Checked == true)
            {
                editTextKQ.Text = (a * b).ToString() + "";
            }
            else if (rdChia.Checked == true)
            {
                editTextKQ.Text = (a / b).ToString() + "";
            }
        }

        private void edittextA_TextChanged(object sender, EventArgs e)
        {

        }
        double a, b;
        private void cbMax_CheckedChanged(object sender, EventArgs e)
        {

            convertText();
            if (cbMax.Checked == true)
            {
                if (a > b)
                {
                    cbMax.Text = "Max=" + a;
                }
                else
                    cbMax.Text = "Max=" + b;
            }

        }
        public void convertText()
        {
            a = Convert.ToDouble(edittextA.Text);
            b = Convert.ToDouble(edittextB.Text);
        }

        private void cbMin_CheckedChanged(object sender, EventArgs e)
        {
            convertText();
            if (cbMin.Checked == true)
            {
                if (a > b)
                {
                    cbMin.Text = "Min=" + b;
                }
                else
                    cbMin.Text = "Min=" + a;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
