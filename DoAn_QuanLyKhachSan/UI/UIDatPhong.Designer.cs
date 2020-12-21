namespace DoAn_QuanLyKhachSan.UI
{
    partial class UIDatPhong
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
            this.datPhongGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightClickContextMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongGridView)).BeginInit();
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
            this.searchBtn.TabIndex = 12;
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
            this.searchTxt.TabIndex = 11;
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
            this.thuocTinhCB.TabIndex = 10;
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
            // datPhongGridView
            // 
            this.datPhongGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datPhongGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datPhongGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datPhongGridView.BackgroundColor = System.Drawing.Color.White;
            this.datPhongGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datPhongGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datPhongGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datPhongGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datPhongGridView.ColumnHeadersHeight = 21;
            this.datPhongGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datPhongGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.cmnd,
            this.maNV,
            this.soPhong,
            this.ngayDat,
            this.ngayTra,
            this.tienThanhToan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datPhongGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.datPhongGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datPhongGridView.EnableHeadersVisualStyles = false;
            this.datPhongGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datPhongGridView.Location = new System.Drawing.Point(0, 52);
            this.datPhongGridView.Name = "datPhongGridView";
            this.datPhongGridView.ReadOnly = true;
            this.datPhongGridView.RowHeadersVisible = false;
            this.datPhongGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datPhongGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datPhongGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datPhongGridView.ShowCellToolTips = false;
            this.datPhongGridView.ShowEditingIcon = false;
            this.datPhongGridView.Size = new System.Drawing.Size(932, 347);
            this.datPhongGridView.TabIndex = 3;
            this.datPhongGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.datPhongGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datPhongGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datPhongGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datPhongGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datPhongGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datPhongGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datPhongGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datPhongGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datPhongGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datPhongGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datPhongGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datPhongGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datPhongGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.datPhongGridView.ThemeStyle.ReadOnly = true;
            this.datPhongGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datPhongGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datPhongGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datPhongGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datPhongGridView.ThemeStyle.RowsStyle.Height = 22;
            this.datPhongGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datPhongGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datPhongGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datPhongGridView_CellMouseClick);
            this.datPhongGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datPhongGridView_CellMouseDoubleClick);
            // 
            // maHD
            // 
            this.maHD.HeaderText = "MÃ HOÁ ĐƠN";
            this.maHD.Name = "maHD";
            this.maHD.ReadOnly = true;
            // 
            // cmnd
            // 
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            // 
            // maNV
            // 
            this.maNV.HeaderText = "MÃ NHÂN VIÊN";
            this.maNV.Name = "maNV";
            this.maNV.ReadOnly = true;
            // 
            // soPhong
            // 
            this.soPhong.HeaderText = "SỐ PHÒNG";
            this.soPhong.Name = "soPhong";
            this.soPhong.ReadOnly = true;
            // 
            // ngayDat
            // 
            this.ngayDat.HeaderText = "NGÀY ĐẶT";
            this.ngayDat.Name = "ngayDat";
            this.ngayDat.ReadOnly = true;
            // 
            // ngayTra
            // 
            this.ngayTra.HeaderText = "NGÀY TRẢ";
            this.ngayTra.Name = "ngayTra";
            this.ngayTra.ReadOnly = true;
            // 
            // tienThanhToan
            // 
            this.tienThanhToan.HeaderText = "THÀNH TIỀN";
            this.tienThanhToan.Name = "tienThanhToan";
            this.tienThanhToan.ReadOnly = true;
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
            // UIDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datPhongGridView);
            this.Controls.Add(this.panel1);
            this.Name = "UIDatPhong";
            this.Size = new System.Drawing.Size(932, 399);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datPhongGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private Guna.UI2.WinForms.Guna2TextBox searchTxt;
        private Guna.UI2.WinForms.Guna2ComboBox thuocTinhCB;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
        private Guna.UI2.WinForms.Guna2DataGridView datPhongGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn soPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienThanhToan;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip rightClickContextMenu;
    }
}
