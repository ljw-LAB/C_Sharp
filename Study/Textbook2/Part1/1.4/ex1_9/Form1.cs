﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1_9
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            this.Click += new EventHandler(ClickEvent);
            InitializeComponent();

            void ClickEvent(object sender, EventArgs s)
            {
                MessageBox.Show("Hello world");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
