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
    public partial class Timer : Form
    {

        //hp=true chuyển động sang phải ,gp=false chuyển động sang trái
        Boolean hp;
        public Timer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Load(object sender, EventArgs e)
        {
            //hp = true;
            //tmrClock.Start();
        }
        int s, m;
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            s = Convert.ToInt16(edittext_second.Text);
            m = Convert.ToInt16(edittex_minute.Text);
            
            
                if (s > 0 && s < 60)
                {
                    s--;
                }
                if (s == 0 && m>0)
                {
                    m--;
                    s = 59;
                } if (s == 0 && m == 0)
                {
                    edittext_second.Text = s.ToString();
                    tmrClock.Stop();
                    MessageBox.Show("Kết thúc !");
                }
            
            edittext_second.Text = s.ToString();
            edittex_minute.Text = m.ToString();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrClock.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            tmrClock.Stop();
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            tmrClock.Stop();
            edittext_second.Text = 0+"";
            edittex_minute.Text = 0+"";
        }

    }
}
