namespace DoAn_QuanLyKhachSan
{
    partial class UIKhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.searchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.thuocTinhCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.khachHangGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightClickContextMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchTxt);
            this.panel1.Controls.Add(this.thuocTinhCB);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 52);
            this.panel1.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Animated = true;
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.CheckedState.Parent = this.searchBtn;
            this.searchBtn.CustomImages.Parent = this.searchBtn;
            this.searchBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.HoverState.Parent = this.searchBtn;
            this.searchBtn.Location = new System.Drawing.Point(738, 9);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.ShadowDecoration.Parent = this.searchBtn;
            this.searchBtn.Size = new System.Drawing.Size(148, 36);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "TÌM KIẾM";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxt.DefaultText = "";
            this.searchTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxt.DisabledState.Parent = this.searchTxt;
            this.searchTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTxt.FocusedState.Parent = this.searchTxt;
            this.searchTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTxt.HoverState.Parent = this.searchTxt;
            this.searchTxt.Location = new System.Drawing.Point(539, 9);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PasswordChar = '\0';
            this.searchTxt.PlaceholderText = "";
            this.searchTxt.SelectedText = "";
            this.searchTxt.ShadowDecoration.Parent = this.searchTxt;
            this.searchTxt.Size = new System.Drawing.Size(193, 36);
            this.searchTxt.TabIndex = 14;
            // 
            // thuocTinhCB
            // 
            this.thuocTinhCB.Animated = true;
            this.thuocTinhCB.BackColor = System.Drawing.Color.Transparent;
            this.thuocTinhCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.thuocTinhCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thuocTinhCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thuocTinhCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thuocTinhCB.FocusedState.Parent = this.thuocTinhCB;
            this.thuocTinhCB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thuocTinhCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.thuocTinhCB.HoverState.Parent = this.thuocTinhCB;
            this.thuocTinhCB.ItemHeight = 30;
            this.thuocTinhCB.ItemsAppearance.Parent = this.thuocTinhCB;
            this.thuocTinhCB.Location = new System.Drawing.Point(408, 9);
            this.thuocTinhCB.Name = "thuocTinhCB";
            this.thuocTinhCB.ShadowDecoration.Parent = this.thuocTinhCB;
            this.thuocTinhCB.Size = new System.Drawing.Size(125, 36);
            this.thuocTinhCB.TabIndex = 13;
            // 
            // editBtn
            // 
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Image = global::DoAn_QuanLyKhachSan.Properties.Resources.edit_32px;
            this.editBtn.Location = new System.Drawing.Point(96, 8);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(28, 34);
            this.editBtn.TabIndex = 5;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Image = global::DoAn_QuanLyKhachSan.Properties.Resources.remove_new_32px;
            this.removeBtn.Location = new System.Drawing.Point(62, 8);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(28, 34);
            this.removeBtn.TabIndex = 6;
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Image = global::DoAn_QuanLyKhachSan.Properties.Resources.add_32px;
            this.addBtn.Location = new System.Drawing.Point(19, 8);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(28, 34);
            this.addBtn.TabIndex = 7;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // khachHangGridView
            // 
            this.khachHangGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.khachHangGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.khachHangGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.khachHangGridView.BackgroundColor = System.Drawing.Color.White;
            this.khachHangGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.khachHangGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.khachHangGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.khachHangGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.khachHangGridView.ColumnHeadersHeight = 21;
            this.khachHangGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.khachHangGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnd,
            this.tenKH,
            this.diaChi,
            this.gioiTinh,
            this.sdt});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.khachHangGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.khachHangGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachHangGridView.EnableHeadersVisualStyles = false;
            this.khachHangGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.khachHangGridView.Location = new System.Drawing.Point(0, 52);
            this.khachHangGridView.Name = "khachHangGridView";
            this.khachHangGridView.ReadOnly = true;
            this.khachHangGridView.RowHeadersVisible = false;
            this.khachHangGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.khachHangGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.khachHangGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.khachHangGridView.ShowCellToolTips = false;
            this.khachHangGridView.ShowEditingIcon = false;
            this.khachHangGridView.Size = new System.Drawing.Size(932, 347);
            this.khachHangGridView.TabIndex = 3;
            this.khachHangGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.khachHangGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.khachHangGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.khachHangGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.khachHangGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.khachHangGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.khachHangGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.khachHangGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.khachHangGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.khachHangGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.khachHangGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.khachHangGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.khachHangGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.khachHangGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.khachHangGridView.ThemeStyle.ReadOnly = true;
            this.khachHangGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.khachHangGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.khachHangGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.khachHangGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.khachHangGridView.ThemeStyle.RowsStyle.Height = 22;
            this.khachHangGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.khachHangGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.khachHangGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.khachHangGridView_CellMouseClick);
            this.khachHangGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.khachHangGridView_CellMouseDoubleClick);
            // 
            // cmnd
            // 
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            // 
            // tenKH
            // 
            this.tenKH.HeaderText = "TÊN KHÁCH HÀNG";
            this.tenKH.Name = "tenKH";
            this.tenKH.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.HeaderText = "ĐỊA CHỈ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // gioiTinh
            // 
            this.gioiTinh.HeaderText = "GIỚI TÍNH";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "SDT";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // rightClickContextMenu
            // 
            this.rightClickContextMenu.Name = "rightClickContextMenu";
            this.rightClickContextMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.rightClickContextMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.rightClickContextMenu.RenderStyle.ColorTable = null;
            this.rightClickContextMenu.RenderStyle.RoundedEdges = true;
            this.rightClickContextMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.rightClickContextMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rightClickContextMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.rightClickContextMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.rightClickContextMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.rightClickContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // UIKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.khachHangGridView);
            this.Controls.Add(this.panel1);
            this.Name = "UIKhachHang";
            this.Size = new System.Drawing.Size(932, 399);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
        private Guna.UI2.WinForms.Guna2TextBox searchTxt;
        private Guna.UI2.WinForms.Guna2ComboBox thuocTinhCB;
        private Guna.UI2.WinForms.Guna2DataGridView khachHangGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip rightClickContextMenu;
    }
}
