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
    public partial class Form24_PhepCong : Form
    {
        public Form24_PhepCong()
        {
            InitializeComponent();
        }

        private void Form24_PhepCong_Load(object sender, EventArgs e)
        {
            rd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                if (Convert.ToInt16(lb1.Tag) == i)
                {
                   result[1]= ranDomQuestion(lb1);
                }
                else if (Convert.ToInt16(lb2.Tag) == i)
                {
                  result[2]=  ranDomQuestion(lb2);
                }
                else if (Convert.ToInt16(lb3.Tag) == i)
                {
                   result[3]= ranDomQuestion(lb3);
                }
                else if (Convert.ToInt16(lb4.Tag) == i)
                {
                    result[4] = ranDomQuestion(lb4);
                }
                else if (Convert.ToInt16(lb5.Tag) == i)
                {
                    result[5] = ranDomQuestion(lb5);
                }
                else if (Convert.ToInt16(lb6.Tag) == i)
                {
                    result[6] = ranDomQuestion(lb6);
                }
                else if (Convert.ToInt16(lb7.Tag) == i)
                {
                    result[7] = ranDomQuestion(lb7);
                }
                else if (Convert.ToInt16(lb8.Tag) == i)
                {
                    result[8] = ranDomQuestion(lb8);
                }
                else if (Convert.ToInt16(lb9.Tag) == i)
                {
                    result[9] = ranDomQuestion(lb9);
                }
                else if (Convert.ToInt16(lb10.Tag) == i)
                {
                    result[10] = ranDomQuestion(lb10);
                }
            }
         
        }

        int a, b;
        Random rd;
        int[] result = new int[11];
        public int ranDomQuestion(Label lb)
        {
            a = rd.Next(100);
            b = rd.Next(100);
            lb.Text = a + " + " + b;
            int s = a + b;
            //lb.Tag = s;
            return s;
        }
        int score = 0;
        private void btnHoanthanh_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ed1.Text.ToString())==result[1])
            {
                score++;
            }
            else if (Convert.ToInt32(ed2.Text.ToString()) == result[2])
            {
                score++;
            }
            else if (Convert.ToInt32(ed3.Text.ToString()) == result[3])
            {
                score++;
            }
            else if (Convert.ToInt32(ed4.Text.ToString()) == result[4])
            {
                score++;
            }
            else if (Convert.ToInt32(ed5.Text.ToString()) == result[5])
            {
                score++;
            }
            else if (Convert.ToInt32(ed6.Text.ToString()) == result[6])
            {
                score++;
            }
            else if (Convert.ToInt32(ed7.Text.ToString()) == result[7])
            {
                score++;
            }
            else if (Convert.ToInt32(ed8.Text.ToString()) == result[8])
            {
                score++;
            }
            else if (Convert.ToInt32(ed9.Text.ToString()) == result[9])
            {
                score++;
            }
            else if (Convert.ToInt32(ed10.Text.ToString()) == result[10])
            {
                score++;
            }
            lbScore.Text = "Bạn Làm Đúng " + score + " Câu";
        }

        private void ed1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
