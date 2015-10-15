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
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
        }

        private void rdVnTime_CheckedChanged(object sender, EventArgs e)
        {
            editText.Font = new Font("VnTime",17,editText.Font.Style);
        }

        private void rdVnUniverec_CheckedChanged(object sender, EventArgs e)
        {
            editText.Font = new Font("VnUniverese", 12,editText.Font.Style);
        }

        private void cbBold_Click(object sender, EventArgs e)
        {
            editText.Font = new Font(editText.Font,editText.Font.Style^FontStyle.Bold);
        }

        private void rdTahoma_CheckedChanged(object sender, EventArgs e)
        {
            editText.Font = new Font("Mistral", 14, editText.Font.Style);

        }


    }
}
