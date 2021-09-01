namespace ex_154
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일 = new System.Windows.Forms.ToolStripMenuItem();
            this.폰트와색 = new System.Windows.Forms.ToolStripMenuItem();
            this.폰트 = new System.Windows.Forms.ToolStripMenuItem();
            this.배경색 = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일,
            this.폰트와색});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일
            // 
            this.파일.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.끝내기});
            this.파일.Name = "파일";
            this.파일.Size = new System.Drawing.Size(43, 20);
            this.파일.Text = "파일";
            // 
            // 폰트와색
            // 
            this.폰트와색.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폰트,
            this.배경색});
            this.폰트와색.Name = "폰트와색";
            this.폰트와색.Size = new System.Drawing.Size(71, 20);
            this.폰트와색.Text = "폰트와 색";
            this.폰트와색.Click += new System.EventHandler(this.폰트와색_Click);
            // 
            // 폰트
            // 
            this.폰트.Name = "폰트";
            this.폰트.Size = new System.Drawing.Size(152, 22);
            this.폰트.Text = "폰트";
            // 
            // 배경색
            // 
            this.배경색.Name = "배경색";
            this.배경색.Size = new System.Drawing.Size(152, 22);
            this.배경색.Text = "배경색";
            this.배경색.Click += new System.EventHandler(this.배경색_Click);
            // 
            // 끝내기
            // 
            this.끝내기.Name = "끝내기";
            this.끝내기.Size = new System.Drawing.Size(152, 22);
            this.끝내기.Text = "끝내기";
            this.끝내기.Click += new System.EventHandler(this.끝내기_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(53, 85);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 12);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "lblTime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일;
        private System.Windows.Forms.ToolStripMenuItem 끝내기;
        private System.Windows.Forms.ToolStripMenuItem 폰트와색;
        private System.Windows.Forms.ToolStripMenuItem 폰트;
        private System.Windows.Forms.ToolStripMenuItem 배경색;
        private System.Windows.Forms.Label lblTime;
    }
}

