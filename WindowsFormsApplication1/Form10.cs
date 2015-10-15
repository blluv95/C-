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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        String nameContry = "";
        String name1 = "";
        private void rdFrance_CheckedChanged(object sender, EventArgs e)
        {
            setName(rdFrance.Text.ToString(), "Paris");
            setFalseCapital();
        }

        public void setName(String name, String capital)
        {
            name1 = name;
            nameContry = capital;
            label.Text = "Hãy chọn thành phố cho " + name;

        }
        private void rdJapan_CheckedChanged(object sender, EventArgs e)
        {
            setFalseCapital();
            setName(rdJapan.Text.ToString(), "Tokyo");
        }

        private void rdHungary_CheckedChanged(object sender, EventArgs e)
        {
            setFalseCapital();

            setName(rdHungary.Text.ToString(), "Ankara");
        }

        private void rdSpain_CheckedChanged(object sender, EventArgs e)
        {
            setFalseCapital();

            setName(rdSpain.Text.ToString(), "Rome");
        }

        private void rdTurkey_CheckedChanged(object sender, EventArgs e)
        {
            setFalseCapital();

            setName(rdTurkey.Text.ToString(), "Madrid");
        }

        private void rdUK_CheckedChanged(object sender, EventArgs e)
        {
            setFalseCapital();
            setName(rdUK.Text.ToString(), "London");
        }

        private void rdItaly_CheckedChanged(object sender, EventArgs e)
        {
            setFalseCapital();
            setName(rdItaly.Text.ToString(), "Budapest");
        }

        private void rdUSA_CheckedChanged(object sender, EventArgs e)
        {
            setFalseCapital();
            setName(rdUSA.Text.ToString(), "Buenos Aries");
        }

        public void setLabelIsCorrect(String contry, String capital)
        {
            label.Text = "Chúc mừng bạn ,thủ đô của " + contry + " là " + capital;
        }

        public void setLabelFalse(String contry, String capital)
        {
            label.Text = "Bạn sai rồi , thủ đô " + contry + " không phải là " + capital;
        }
        private void rdBuenos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBuenos.Text == nameContry) setLabelIsCorrect("The USA", nameContry);
            else setLabelFalse(name1, nameContry);
        }

        private void rdTokyo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTokyo.Text == nameContry) setLabelIsCorrect(name1, nameContry);
            else setLabelFalse(name1, nameContry);
        }

        private void rdRome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRome.Text == nameContry) setLabelIsCorrect(name1, nameContry);
            else setLabelFalse(name1, nameContry);
        }

        private void rdMadrid_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMadrid.Text == nameContry) setLabelIsCorrect(name1, nameContry);
            else setLabelFalse(name1, nameContry);
        }

        private void rdLondon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLondon.Text == nameContry) setLabelIsCorrect(name1, nameContry);
            else setLabelFalse(name1, nameContry);
        }

        private void rdAnkara_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAnkara.Text == nameContry) setLabelIsCorrect(name1, nameContry);
            else setLabelFalse(name1, nameContry);
        }

        private void rdBudapest_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBudapest.Text == nameContry) setLabelIsCorrect(name1, nameContry);
            else setLabelFalse(name1, nameContry);
        }

        private void rdParis_CheckedChanged(object sender, EventArgs e)
        {
            if (rdParis.Text == nameContry) setLabelIsCorrect(name1, nameContry);
            else setLabelFalse(name1, nameContry);
        }

        public void setFalseCapital()
        {
            rdBuenos.Checked = false;
            rdTokyo.Checked = false;
            rdRome.Checked = false;
            rdMadrid.Checked = false;
            rdLondon.Checked = false;
            rdAnkara.Checked = false;
            rdBudapest.Checked = false;
            rdParis.Checked = false;


        }
    }
}
