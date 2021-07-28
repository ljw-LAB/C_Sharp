using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(mnuFileNew.Text);
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(mnuFileOpen.Text);
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {

        }

        
    }
}
