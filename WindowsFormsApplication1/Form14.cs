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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isTimer)
            {
                if (label1.Left + label1.Width < this.Width)
                {
                    label1.Left = label1.Left + 10;
                }
                else isTimer = false;
            }
            else
            {
                if (label1.Left > 0)
                    label1.Left = label1.Left - 10;
                else isTimer = true;
            }

            Console.WriteLine(label1.Left+"");
        }
        Boolean isTimer;
        private void Form14_Load(object sender, EventArgs e)
        {
            isTimer = true;
            timer1.Start();
        }


    }
}
