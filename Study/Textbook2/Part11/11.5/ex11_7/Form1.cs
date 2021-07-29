using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ex11_7
{
    public partial class Form1 : Form
    {
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            for (int i = 0; i < progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
                label1.Text = progressBar1.Value.ToString();
                this.label1.Update();
                //Thread.Sleep(50);
                //thre
                //if (progressBar1.Value == 990)
                //{
                //    timer1.Stop();
                //    
                //}

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < progressBar1.Maximum; i++)
        //    {
        //        progressBar1.Value = i;
        //        label1.Text = progressBar1.Value.ToString();
        //        this.label1.Update();
        //        //thre
        //        //if (progressBar1.Value == 990)
        //        //{
        //        //    timer1.Stop();
        //        //    
        //        //}

        //    }
        //}
    }
}
