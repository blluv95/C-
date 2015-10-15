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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            listBox.Items.Add("Kĩ thuật lập trình C");
            for (int i = 0; i < 10; i++)
            {
                listBox.Items.Add(".Net Toàn Tập phần 1" + i);
            }

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            
            String hangmua = listBox.SelectedItem.ToString();
            int d = 0;
            int i;
            for ( i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items[i].ToString().Equals(hangmua))
               // if(listBox2.Items[i].ToString()==hangmua)
                {
                    MessageBox.Show("Bạn đã mua cuốn" + hangmua +"rồi . Mua làm gì nữa .");
                    //d = 1;
                    return ;
                }
            }
            listBox2.Items.Add(hangmua);
           //if (i == listBox2.Items.Count)
           // {
           //          listBox2.Items.Add(hangmua);
           // }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa " + listBox2.SelectedItem + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else this.Close();

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            String s="Họ tên khách:"+edHoten.Text+"\nSố điện thoại"+edDT.Text+"\n";
            for(int i=0;i<listBox2.Items.Count;i++){
                s=s+listBox2.Items[i]+"\n";
            }
            String s1 = "";
            if (rdTienmat.Checked) { s1 = s1 + rdTienmat.Text; }
            else if (rdSec.Checked) { s1 += rdSec.Text; }
            else s1 += rdThe.Text;
            String s2 = "Hình thức thanh toán :";
            if (cbDT.Checked) { s1 = s1 + "\n"+s2 + cbDT.Text; }
            else if (cbEmail.Checked) { s1 = s1 + "\nHình thức thanh toán :" + cbEmail.Text; }
            else s1 = s1 + "\nHình thức thanh toán:" + cbFax.Text;
            s = s + "Phương thức thanh toán :" + s1;

            MessageBox.Show(s,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
