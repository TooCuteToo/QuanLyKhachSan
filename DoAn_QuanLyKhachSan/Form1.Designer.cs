namespace DoAn_QuanLyKhachSan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiDangNhap1 = new DoAn_QuanLyKhachSan.UIDangNhap();
            this.uiQuanLy = new DoAn_QuanLyKhachSan.UIQuanLy();
            this.SuspendLayout();
            // 
            // uiDangNhap1
            // 
            this.uiDangNhap1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.uiDangNhap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDangNhap1.Location = new System.Drawing.Point(0, 0);
            this.uiDangNhap1.Name = "uiDangNhap1";
            this.uiDangNhap1.Size = new System.Drawing.Size(1116, 541);
            this.uiDangNhap1.TabIndex = 0;
            this.uiDangNhap1.Load += new System.EventHandler(this.uiDangNhap1_Load);
            // 
            // uiQuanLy
            // 
            this.uiQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.uiQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiQuanLy.Location = new System.Drawing.Point(0, 0);
            this.uiQuanLy.Name = "uiQuanLy";
            this.uiQuanLy.Size = new System.Drawing.Size(1116, 541);
            this.uiQuanLy.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 541);
            this.Controls.Add(this.uiDangNhap1);
            this.Controls.Add(this.uiQuanLy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UIQuanLy uiQuanLy;
        private UIDangNhap uiDangNhap1;

        //private UIDangNhap uiDangNhap1;
    }
}

