using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_QuanLyKhachSan.DAO;
using DoAn_QuanLyKhachSan.POJO;

namespace DoAn_QuanLyKhachSan.UI
{
    public partial class UIPhong : UserControl
    {
        public UIPhong()
        {
            InitializeComponent();
            initListViewColumn();

            initListView();
            initCombobox();
        }

        private void initListViewColumn()
        {
            phongLV.Items.Add(new ListViewItem(new string[] { "SỐ PHÒNG", "TÌNH TRẠNG", "MÃ LOẠI" }));
            //rgba(245, 246, 250,1.0)
            phongLV.Items[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            phongLV.Items[0].Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phongLV.Items[0].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
        }

        private void initListView()
        {
            phongLV.Items.Clear();
            initListViewColumn();

            foreach (Phong phong in QuanLyDAO<Phong>.getData()) {
                ListViewItem item = new ListViewItem(new string[] { phong.soPhong, phong.tinhTrang, phong.maLoai });
                item.Tag = phong;
                phongLV.Items.Add(item);
            }
        }

        private void initCombobox()
        {
            var list = QuanLyDAO<Phong>.getTableColumNames();

            foreach (var item in list)
            {
                string name = item.ToString();
                int startIndex = name.IndexOf(' ');
                string property = name.Substring(startIndex).Trim();
                thuocTinhCB.Items.Add(property);
            }

            thuocTinhCB.SelectedIndex = 0;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (phongLV.SelectedItems.Count == 0 || phongLV.SelectedItems[0].Tag == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần chỉnh sửa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Phong selectedItem = phongLV.SelectedItems[0].Tag as Phong;

            EditForm edit = new EditForm();
            edit.showEdit(selectedItem);
            edit.FormClosed += new FormClosedEventHandler(form_close);
        }

        private void form_close(object sender, FormClosedEventArgs e)
        {
            initListView();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            Phong selectedItem = phongLV.SelectedItems[0].Tag as Phong;
            new PhongDAO().removeData(selectedItem);

            phongLV.Items.Clear();
            initListView();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = thuocTinhCB.SelectedItem;

            List<Phong> resultList = QuanLyDAO<Phong>.searchData(selectedItem.ToString(), searchTxt.Text);

            phongLV.Items.Clear();

            initListViewColumn();

            foreach (Phong phong in resultList)
            {
                ListViewItem item = new ListViewItem(new string[] { phong.soPhong, phong.tinhTrang, phong.maLoai });
                item.Tag = phong;
                phongLV.Items.Add(item);
            }
        }
    }
}
