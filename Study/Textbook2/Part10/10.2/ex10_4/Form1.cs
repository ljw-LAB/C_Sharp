using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex10_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Point mousPoint = PointToClient(MousePosition);
            string msg = "Mouse Position : " + mousPoint.X + ", " + mousPoint.Y;
            MessageBox.Show(msg);
        }
    }
}
