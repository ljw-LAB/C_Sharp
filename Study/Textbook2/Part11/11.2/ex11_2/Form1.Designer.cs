﻿namespace ex11_2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("베토벤");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("슈베르트");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("모짜르트");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("클래식", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Britney Spears");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Mariah Carey");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Carpenters");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("팝", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("이승철");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("이미자");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("송대관");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("가요", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(68, 60);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "노드10";
            treeNode1.Text = "베토벤";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "노드11";
            treeNode2.Text = "슈베르트";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "노드12";
            treeNode3.Text = "모짜르트";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "노드0";
            treeNode4.Text = "클래식";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "노드13";
            treeNode5.Text = "Britney Spears";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "노드14";
            treeNode6.Text = "Mariah Carey";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "노드15";
            treeNode7.Text = "Carpenters";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "노드1";
            treeNode8.Text = "팝";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "노드17";
            treeNode9.Text = "이승철";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "노드18";
            treeNode10.Text = "이미자";
            treeNode11.ImageIndex = 1;
            treeNode11.Name = "노드19";
            treeNode11.Text = "송대관";
            treeNode12.Name = "노드16";
            treeNode12.Text = "가요";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(230, 182);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CLSFOLD.ICO");
            this.imageList1.Images.SetKeyName(1, "AUDIO.ICO");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "노드추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "노드삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 389);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "TreeViewApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

