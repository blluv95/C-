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
    public partial class BaiTap : Form
    {
        public BaiTap()
        {
            InitializeComponent();
        }
        double[] x;
        double[] y;
        public void loadArr()
        {
            listX = new List<double>();
            listY = new List<double>();
        }
        List<double> listX;
        List<double> listY;
        private void btnThem_Click(object sender, EventArgs e)
        {
            listBox.Items.Add("( " + edX.Text + "," + edY.Text + " )");
            listX.Add(Convert.ToDouble(edX.Text));
            listY.Add(Convert.ToDouble(edY.Text));
            edX.Text = "";
            edY.Text = "";
            if (listBox.Items.Count > 0)
            {
                doDaiDuongGapKhuc();
            }

        }
        //(2,4)
        public void doDaiDuongGapKhuc()
        {
            double s = 0;
            for (int i = 0; i < listBox.Items.Count - 1; i++)
            {

                double x = listX[i];
                double y = listY[i];
                double x1 = listX[i + 1];
                double y1 = listY[i+1];
                Console.WriteLine(x+"");
                Console.WriteLine(y+"");
                Console.WriteLine(x1+""); 
                Console.WriteLine(y1+"");
                s += Math.Sqrt((x1 - x) * (x1 - x) + (y1 - y) * (y1 - y));
            }

            tvDistance.Text = "Độ dài đường gấp khúc :" + s;
        }

        private void BaiTap_Load(object sender, EventArgs e)
        {
            loadArr();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn điểm cần xóa .");
            }
            else
            {
                listX.RemoveAt(listBox.SelectedIndex);
                listY.RemoveAt(listBox.SelectedIndex);
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                MessageBox.Show("Xóa thành công");
                doDaiDuongGapKhuc();
            }
        }
    }
}
