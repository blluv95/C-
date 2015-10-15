using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class OpenFile : Form
    {
        public OpenFile()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Bitmap(*.bmp) |*bmp |Gif(*.gif)|*gif|All files(*.*)|*.*";
            open.InitialDirectory = "D:\\HinhNen";  // mở thư mục mặc định
            open.FilterIndex = 3;  // đuôi file thứ 3 trong filter
            open.Title = "Open Image";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgBox.Image = Image.FromFile(open.FileName);
            }
              
            else MessageBox.Show("Cannel", "OpenFile Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
          textBox1.Text=open.FileName;
        }

        private void imgBox_Click(object sender, EventArgs e)
        {

        }

        private void OpenFile_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            StreamWriter write = new StreamWriter("E:\\file.rtf");
            try
            {
                write.Write(edittext.Text.ToString());
                MessageBox.Show("Save Success !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (write != null) write.Close();
            }


        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files(*.*)|*.*";
            open.InitialDirectory = "E:\\";  // mở thư mục mặc định
            open.FilterIndex = 1;  // đuôi file thứ 3 trong filter
            open.Title = "Open File";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                edittext.LoadFile(open.FileName);
                //StreamReader read = new StreamReader(open.FileName);
                //Console.WriteLine(read.ReadLine() + "------->");
                //edittext.Text= read.ReadLine()+"";
            }
            //Console.WriteLine(open.FileName + "");
            //StreamReader read = new StreamReader(open.FileName);

            //read.Read();
            
            //read.Read(open.FileName);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;
            if (font.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                edittext.Font = font.Font;
                edittext.ForeColor = font.Color;
            }
            else
            {
                MessageBox.Show("You click Canel !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.ShowDialog();  // chỉ thực hiện đc form đang mở 
            //t.Show(); // thực thi nhiều form đồng thời
        }
    }
}
