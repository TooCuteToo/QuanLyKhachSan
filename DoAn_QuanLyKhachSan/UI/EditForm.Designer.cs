﻿namespace DoAn_QuanLyKhachSan.UI
{
    partial class EditForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.thoatBtn = new System.Windows.Forms.Button();
            this.editBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.thoatBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 500);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // thoatBtn
            // 
            this.thoatBtn.FlatAppearance.BorderSize = 0;
            this.thoatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thoatBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoatBtn.Image = global::DoAn_QuanLyKhachSan.Properties.Resources.power_1_;
            this.thoatBtn.Location = new System.Drawing.Point(820, 24);
            this.thoatBtn.Name = "thoatBtn";
            this.thoatBtn.Size = new System.Drawing.Size(28, 34);
            this.thoatBtn.TabIndex = 4;
            this.thoatBtn.UseVisualStyleBackColor = true;
            this.thoatBtn.Click += new System.EventHandler(this.thoatBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.CheckedState.Parent = this.editBtn;
            this.editBtn.CustomImages.Parent = this.editBtn;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.HoverState.Parent = this.editBtn;
            this.editBtn.Location = new System.Drawing.Point(592, 295);
            this.editBtn.Name = "editBtn";
            this.editBtn.ShadowDecoration.Parent = this.editBtn;
            this.editBtn.Size = new System.Drawing.Size(180, 45);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "EDIT";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.CheckedState.Parent = this.addBtn;
            this.addBtn.CustomImages.Parent = this.addBtn;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.HoverState.Parent = this.addBtn;
            this.addBtn.Location = new System.Drawing.Point(592, 205);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.Parent = this.addBtn;
            this.addBtn.Size = new System.Drawing.Size(180, 45);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "ADD";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 18);
            this.panel2.TabIndex = 2;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button editBtn;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button thoatBtn;
    }
}