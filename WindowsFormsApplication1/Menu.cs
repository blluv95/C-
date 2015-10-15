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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        String msg = "";
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rb1.SelectedText);

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb2.Text = Clipboard.GetText();
        }

      


    }
}
