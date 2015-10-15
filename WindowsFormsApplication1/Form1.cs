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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
        m = Convert.ToInt32(editTextMonth.Text);
            y = Convert.ToInt32(editTextYear.Text);
            }
            catch (Exception exx)
            {
                txtShow.Text = "Lỗi Nhập dữ liệu";
            }
    


            if (m < 0 || m > 12)
            {
                txtShow.Text = "Lỗi Nhập dữ liệu";
            }else
            if (y < 1000 || y > 9999)
            {
                txtShow.Text = "Lỗi Nhập dữ liệu";
            }
            else
            {
                txtShow.Text = "Tháng " + m + " Năm " + y;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
          
        }
        int check_button = 0;
        int m;
        private void editTextMonth_TextChanged(object sender, EventArgs e)
        {
           
            /*
            check_button = 1;
            try
            {
                m = Convert.ToInt32(editTextMonth.Text);
            }
            catch (Exception ex)
            {
                editTextMonth.Text = "";
                MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
               
            }
              */

            }



        int y;
        private void editTextYear_TextChanged(object sender, EventArgs e)
        {
           
            /*
            if (check_button == 1)
            {
                btnKQ.Enabled = true;
                try
                {
                    y = Convert.ToInt32(editTextYear.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }*/
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            editTextMonth.Text = "";
            editTextYear.Text = "";
            m = 0;
            y = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn Có chắc chắn thoát", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==System.Windows.Forms.DialogResult.Yes)
                this.Close();
            
        }

        private void txtShow_Click(object sender, EventArgs e)
        {

        }
    }
}
