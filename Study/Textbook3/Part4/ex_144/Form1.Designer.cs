namespace ex_144
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
            this.rb_Detail = new System.Windows.Forms.RadioButton();
            this.rb_List = new System.Windows.Forms.RadioButton();
            this.rb_Small = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.myListView = new System.Windows.Forms.ListView();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rb_Detail
            // 
            this.rb_Detail.AutoSize = true;
            this.rb_Detail.Location = new System.Drawing.Point(75, 44);
            this.rb_Detail.Name = "rb_Detail";
            this.rb_Detail.Size = new System.Drawing.Size(59, 16);
            this.rb_Detail.TabIndex = 0;
            this.rb_Detail.TabStop = true;
            this.rb_Detail.Text = "자세히";
            this.rb_Detail.UseVisualStyleBackColor = true;
            this.rb_Detail.CheckedChanged += new System.EventHandler(this.rb_Detail_CheckedChanged);
            // 
            // rb_List
            // 
            this.rb_List.AutoSize = true;
            this.rb_List.Location = new System.Drawing.Point(243, 44);
            this.rb_List.Name = "rb_List";
            this.rb_List.Size = new System.Drawing.Size(59, 16);
            this.rb_List.TabIndex = 1;
            this.rb_List.TabStop = true;
            this.rb_List.Text = "리스트";
            this.rb_List.UseVisualStyleBackColor = true;
            this.rb_List.CheckedChanged += new System.EventHandler(this.rb_List_CheckedChanged);
            // 
            // rb_Small
            // 
            this.rb_Small.AutoSize = true;
            this.rb_Small.Location = new System.Drawing.Point(408, 44);
            this.rb_Small.Name = "rb_Small";
            this.rb_Small.Size = new System.Drawing.Size(87, 16);
            this.rb_Small.TabIndex = 3;
            this.rb_Small.TabStop = true;
            this.rb_Small.Text = "작은 아이콘";
            this.rb_Small.UseVisualStyleBackColor = true;
            this.rb_Small.CheckedChanged += new System.EventHandler(this.rb_Small_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(565, 44);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(75, 16);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "큰 아이콘";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // myListView
            // 
            this.myListView.Location = new System.Drawing.Point(75, 96);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(582, 225);
            this.myListView.TabIndex = 4;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.SelectedIndexChanged += new System.EventHandler(this.myListView_SelectedIndexChanged);
            // 
            // txtSelected
            // 
            this.txtSelected.Location = new System.Drawing.Point(408, 338);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(248, 21);
            this.txtSelected.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selected:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSelected);
            this.Controls.Add(this.myListView);
            this.Controls.Add(this.rb_Small);
            this.Controls.Add(this.rbLarge);
            this.Controls.Add(this.rb_List);
            this.Controls.Add(this.rb_Detail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Detail;
        private System.Windows.Forms.RadioButton rb_List;
        private System.Windows.Forms.RadioButton rb_Small;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.ListView myListView;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.Label label1;
    }
}

