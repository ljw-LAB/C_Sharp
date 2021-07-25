using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox3.Text = "Name : " + textBox1.Text + "\r\nPassword : " + textBox2.Text;
            textBox3.AppendText("Name : " + textBox1.Text);
            textBox3.AppendText("\r\nPassword : " + textBox2.Text + "\r\n");
            //textBox1.AppendText
            //add
        }
    }
}
