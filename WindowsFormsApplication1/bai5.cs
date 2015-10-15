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
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Boolean check = false;
            int i;
            for (i = 0; i < listBox.Items.Count; i++)
            {
                if (listBox.Items[i].ToString().ToUpper() == editText.Text.ToUpper().Trim())
                {
                    MessageBox.Show("Đã có " + editText.Text + " Trong danh sách");
                    break;
                }
            }
            if (i == listBox.Items.Count)
            {
                listBox.Items.Add(editText.Text);
                editText.Text = "";
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("Danh sách trống");

            }

            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn danh sách cần xóa");
            }
            else
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                MessageBox.Show("Xóa thành công");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Boolean check = false;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (editText.Text.ToUpper().Equals(listBox.Items[i].ToString().ToUpper()))
                {
                    check = true;
                    MessageBox.Show("Tìm Thấy " + editText.Text + " trong list"
                        , "Thông báo"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information
                        );
                    listBox.SelectedIndex = i;
                }
            }
            if (check == false)
            {
                MessageBox.Show("Không Tìm Thấy " + editText.Text + " trong list"
                    , "Thông báo"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information
                    );
            }


        }

        private void bai5_Load(object sender, EventArgs e)
        {
            for(int i=0;i<10;i++)
                listBox.Items.Add("Item "+i);
        }

    }

}

