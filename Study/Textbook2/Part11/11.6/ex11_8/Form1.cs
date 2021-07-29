using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex11_8
{
    public partial class Form1 : Form
    {
        private int index;
        private Image[] images;

        public Form1()
        {
            InitializeComponent();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            images = new Image[8];

            string imagePath = @"D:\study\C#\Study\Textbook2\Part11\11.6\ex11_8\tiger\tiger";

            for (int i = 0; i < 8; i++)
            {
                images[i] = Image.FromFile(imagePath + i + ".jpg");

            }


            if (index < 8)
                label1.Image = images[index++];
            else
            {
                index = 0;
                label1.Image = images[index++];
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
