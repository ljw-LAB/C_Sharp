namespace ex11_3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("MulticastDelegate");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Delegate", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ApplicationException");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("SystemException");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Exception", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Math");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("TextReader");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("TextWriter");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Timer");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("TreeNode");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("MarshalByRefObject", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("String");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Console", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5,
            treeNode6,
            treeNode11,
            treeNode12});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 27);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드6";
            treeNode1.Text = "MulticastDelegate";
            treeNode2.Name = "노드1";
            treeNode2.Text = "Delegate";
            treeNode3.Name = "노드7";
            treeNode3.Text = "ApplicationException";
            treeNode4.Name = "노드9";
            treeNode4.Text = "SystemException";
            treeNode5.Name = "노드2";
            treeNode5.Text = "Exception";
            treeNode6.Name = "노드3";
            treeNode6.Text = "Math";
            treeNode7.Name = "노드10";
            treeNode7.Text = "TextReader";
            treeNode8.Name = "노드11";
            treeNode8.Text = "TextWriter";
            treeNode9.Name = "노드12";
            treeNode9.Text = "Timer";
            treeNode10.Name = "노드13";
            treeNode10.Text = "TreeNode";
            treeNode11.Name = "노드4";
            treeNode11.Text = "MarshalByRefObject";
            treeNode12.Name = "노드5";
            treeNode12.Text = "String";
            treeNode13.Name = "노드0";
            treeNode13.Text = "Console";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(334, 171);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "선택한 노드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "부모 노드";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 259);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "이전 형제 노드";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 286);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "다음 형제 노드";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 313);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(228, 232);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 124);
            this.listBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "자식 노드";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(118, 340);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 397);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "TreeNodeApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
    }
}

