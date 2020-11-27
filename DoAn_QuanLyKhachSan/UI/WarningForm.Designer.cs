namespace DoAn_QuanLyKhachSan
{
    partial class WarningForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.koBtn = new System.Windows.Forms.Button();
            this.coBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 283);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.koBtn);
            this.panel2.Controls.Add(this.coBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 89);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bạn có muốn thoát chương trình không ?";
            // 
            // koBtn
            // 
            this.koBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.koBtn.FlatAppearance.BorderSize = 0;
            this.koBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.koBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.koBtn.Image = global::DoAn_QuanLyKhachSan.Properties.Resources.no;
            this.koBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.koBtn.Location = new System.Drawing.Point(323, 29);
            this.koBtn.Name = "koBtn";
            this.koBtn.Size = new System.Drawing.Size(179, 42);
            this.koBtn.TabIndex = 4;
            this.koBtn.Text = "    KHÔNG";
            this.koBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.koBtn.UseVisualStyleBackColor = false;
            this.koBtn.Click += new System.EventHandler(this.koBtn_Click);
            // 
            // coBtn
            // 
            this.coBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.coBtn.FlatAppearance.BorderSize = 0;
            this.coBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coBtn.Image = global::DoAn_QuanLyKhachSan.Properties.Resources.yes;
            this.coBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coBtn.Location = new System.Drawing.Point(116, 29);
            this.coBtn.Name = "coBtn";
            this.coBtn.Size = new System.Drawing.Size(179, 42);
            this.coBtn.TabIndex = 3;
            this.coBtn.Text = "    CÓ";
            this.coBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.coBtn.UseVisualStyleBackColor = false;
            this.coBtn.Click += new System.EventHandler(this.coBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::DoAn_QuanLyKhachSan.Properties.Resources.warn_1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(209, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 108);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(619, 18);
            this.panel4.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(619, 283);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button koBtn;
        private System.Windows.Forms.Button coBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;

    }
}