using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex11_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeView1.ExpandAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Nodes.Add(new TreeNode(textBox1.Text, 1, 1));
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }
    }
}
