﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This form is loaded");
        }

        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("This form is closed");
            // Closed 없음, FormClosed로 찾아야함, Closing도 동일
        }
    }
}
