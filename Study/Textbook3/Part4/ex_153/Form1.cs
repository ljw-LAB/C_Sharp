using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Diagnostics;
using System.IO;

namespace ex_153
{
    public partial class Form1 : Form
    {
        private OpenFileDialog OpenFileDialog1;
        public Form1()
        {
            InitializeComponent();

            OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.FileName = "Select a text file";
            OpenFileDialog1.Filter = "Text files(*.txt)|*.txt";
            OpenFileDialog1.Title = "Open text file";

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if(OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = OpenFileDialog1.FileName;
                    using (FileStream fs = File.Open(filePath, FileMode.Open))
                    {
                        Process.Start("notepad.exe", filePath);
                    }
                }
                catch(SecurityException ex)
                {
                    MessageBox.Show($"Security error. \n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
            
        }
    }
}
