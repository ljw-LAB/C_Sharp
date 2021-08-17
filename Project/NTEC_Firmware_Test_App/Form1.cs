using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NTEC_Firmware_Test_App
{

    public partial class NTEC_Form : Form
    {
        int test_data = 0;
        
        public NTEC_Form()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            DomainUpDown.DomainUpDownItemCollection NRT40_domainUpDown_1_collection = this.NRT40_domainUpDown_1.Items;
            DomainUpDown.DomainUpDownItemCollection NRT40_domainUpDown_10_collection = this.NRT40_domainUpDown_10.Items;
            DomainUpDown.DomainUpDownItemCollection NRT16_domainUpDown_1_collection  =  this.NRT16_domainUpDown_1.Items;
            DomainUpDown.DomainUpDownItemCollection NRT16_domainUpDown_10_collection =  this.NRT16_domainUpDown_10.Items;
            DomainUpDown.DomainUpDownItemCollection NRG16_domainUpDown_1_collection = this.NRG16_domainUpDown_1.Items;
            DomainUpDown.DomainUpDownItemCollection NRG16_domainUpDown_10_collection = this.NRG16_domainUpDown_10.Items;

            NRT40_domainUpDown_1_collection.Add("0"); NRT40_domainUpDown_1_collection.Add("1"); NRT40_domainUpDown_1_collection.Add("2");
            NRT40_domainUpDown_1_collection.Add("3"); NRT40_domainUpDown_1_collection.Add("4"); NRT40_domainUpDown_1_collection.Add("5");
            NRT40_domainUpDown_1_collection.Add("6"); NRT40_domainUpDown_1_collection.Add("7"); NRT40_domainUpDown_1_collection.Add("8");
            NRT40_domainUpDown_1_collection.Add("9"); NRT40_domainUpDown_1_collection.Add("A"); NRT40_domainUpDown_1_collection.Add("B");
            NRT40_domainUpDown_1_collection.Add("C"); NRT40_domainUpDown_1_collection.Add("D"); NRT40_domainUpDown_1_collection.Add("E");
            NRT40_domainUpDown_1_collection.Add("F");

            NRT40_domainUpDown_10_collection.Add("0"); NRT40_domainUpDown_10_collection.Add("1"); NRT40_domainUpDown_10_collection.Add("2");
            NRT40_domainUpDown_10_collection.Add("3"); NRT40_domainUpDown_10_collection.Add("4"); NRT40_domainUpDown_10_collection.Add("5");
            NRT40_domainUpDown_10_collection.Add("6"); NRT40_domainUpDown_10_collection.Add("7"); NRT40_domainUpDown_10_collection.Add("8");
            NRT40_domainUpDown_10_collection.Add("9"); NRT40_domainUpDown_10_collection.Add("A"); NRT40_domainUpDown_10_collection.Add("B");
            NRT40_domainUpDown_10_collection.Add("C"); NRT40_domainUpDown_10_collection.Add("D"); NRT40_domainUpDown_10_collection.Add("E");
            NRT40_domainUpDown_10_collection.Add("F");

            NRT16_domainUpDown_1_collection.Add("0"); NRT16_domainUpDown_1_collection.Add("1"); NRT16_domainUpDown_1_collection.Add("2");
            NRT16_domainUpDown_1_collection.Add("3"); NRT16_domainUpDown_1_collection.Add("4"); NRT16_domainUpDown_1_collection.Add("5");
            NRT16_domainUpDown_1_collection.Add("6"); NRT16_domainUpDown_1_collection.Add("7"); NRT16_domainUpDown_1_collection.Add("8");
            NRT16_domainUpDown_1_collection.Add("9"); NRT16_domainUpDown_1_collection.Add("A"); NRT16_domainUpDown_1_collection.Add("B");
            NRT16_domainUpDown_1_collection.Add("C"); NRT16_domainUpDown_1_collection.Add("D"); NRT16_domainUpDown_1_collection.Add("E");
            NRT16_domainUpDown_1_collection.Add("F");

            NRT16_domainUpDown_10_collection.Add("0"); NRT16_domainUpDown_10_collection.Add("1"); NRT16_domainUpDown_10_collection.Add("2");
            NRT16_domainUpDown_10_collection.Add("3"); NRT16_domainUpDown_10_collection.Add("4"); NRT16_domainUpDown_10_collection.Add("5");
            NRT16_domainUpDown_10_collection.Add("6"); NRT16_domainUpDown_10_collection.Add("7"); NRT16_domainUpDown_10_collection.Add("8");
            NRT16_domainUpDown_10_collection.Add("9"); NRT16_domainUpDown_10_collection.Add("A"); NRT16_domainUpDown_10_collection.Add("B");
            NRT16_domainUpDown_10_collection.Add("C"); NRT16_domainUpDown_10_collection.Add("D"); NRT16_domainUpDown_10_collection.Add("E");
            NRT16_domainUpDown_10_collection.Add("F");

            NRG16_domainUpDown_1_collection.Add("0"); NRG16_domainUpDown_1_collection.Add("1"); NRG16_domainUpDown_1_collection.Add("2");
            NRG16_domainUpDown_1_collection.Add("3"); NRG16_domainUpDown_1_collection.Add("4"); NRG16_domainUpDown_1_collection.Add("5");
            NRG16_domainUpDown_1_collection.Add("6"); NRG16_domainUpDown_1_collection.Add("7"); NRG16_domainUpDown_1_collection.Add("8");
            NRG16_domainUpDown_1_collection.Add("9"); NRG16_domainUpDown_1_collection.Add("A"); NRG16_domainUpDown_1_collection.Add("B");
            NRG16_domainUpDown_1_collection.Add("C"); NRG16_domainUpDown_1_collection.Add("D"); NRG16_domainUpDown_1_collection.Add("E");
            NRG16_domainUpDown_1_collection.Add("F");

            NRG16_domainUpDown_10_collection.Add("0"); NRG16_domainUpDown_10_collection.Add("1"); NRG16_domainUpDown_10_collection.Add("2");
            NRG16_domainUpDown_10_collection.Add("3"); NRG16_domainUpDown_10_collection.Add("4"); NRG16_domainUpDown_10_collection.Add("5");
            NRG16_domainUpDown_10_collection.Add("6"); NRG16_domainUpDown_10_collection.Add("7"); NRG16_domainUpDown_10_collection.Add("8");
            NRG16_domainUpDown_10_collection.Add("9"); NRG16_domainUpDown_10_collection.Add("A"); NRG16_domainUpDown_10_collection.Add("B");
            NRG16_domainUpDown_10_collection.Add("C"); NRG16_domainUpDown_10_collection.Add("D"); NRG16_domainUpDown_10_collection.Add("E");
            NRG16_domainUpDown_10_collection.Add("F");

            NRT40_domainUpDown_1.SelectedIndex = 0;
            NRT40_domainUpDown_10.SelectedIndex = 0;
            NRT16_domainUpDown_1.SelectedIndex = 0;
            NRT16_domainUpDown_10.SelectedIndex = 0;
            NRG16_domainUpDown_1.SelectedIndex = 0;
            NRG16_domainUpDown_10.SelectedIndex = 0;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox61_CheckedChanged(object sender, EventArgs e)
        {
            if(test_data >= 0 && test_data <= 15)
            { 
                if (checkBox61.Checked)
                {
                    test_data += 1;

                }
                else
                {
                    test_data -= 1;
                }
            }
            textBox3.Text = test_data.ToString("X").ToLower();

        }

        private void checkBox62_CheckedChanged(object sender, EventArgs e)
        {
            if (test_data >= 0 && test_data <= 15)
            {
                if (checkBox62.Checked)
                {
                    test_data += 2;

                }
                else
                {
                    test_data -= 2;
                }
            }
            textBox3.Text = test_data.ToString("X").ToLower();
        }

        private void checkBox63_CheckedChanged(object sender, EventArgs e)
        {
            if (test_data >= 0 && test_data <= 15)
            {
                if (checkBox63.Checked)
                {
                    test_data += 4;

                }
                else
                {
                    test_data -= 4;
                }
            }
            textBox3.Text = test_data.ToString("X").ToLower();
        }

        private void checkBox64_CheckedChanged(object sender, EventArgs e)
        {
            if (test_data >= 0 && test_data <= 15)
            {
                if (checkBox64.Checked)
                {
                    test_data += 8;

                }
                else
                {
                    test_data -= 8;
                }
            }
            textBox3.Text = test_data.ToString("X").ToLower();
        }

        private void checkBox59_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox60_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox57_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox58_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox53_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox54_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox55_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox56_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox51_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox52_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox49_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox50_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
