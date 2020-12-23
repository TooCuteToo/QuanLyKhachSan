using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_QuanLyKhachSan.POJO;
using DoAn_QuanLyKhachSan.DAO;
using DoAn_QuanLyKhachSan.UI;

namespace DoAn_QuanLyKhachSan
{
    public partial class UIKhachHang : UserControl
    {
        public UIKhachHang()
        {
            InitializeComponent();

            initListView();
            initCombobox();

            rightClickContextMenu.Items.Add("ADD", null, new EventHandler(addBtn_Click));
            rightClickContextMenu.Items.Add("EDIT", null, new EventHandler(editBtn_Click));
            rightClickContextMenu.Items.Add("DELETE", null, new EventHandler(removeBtn_Click));
        }

        private void initListView()
        {
            khachHangGridView.Rows.Clear();

            foreach (KhachHang kh in QuanLyDAO<KhachHang>.getData()) 
            {
                int rowIndex = khachHangGridView.Rows.Add();

                //Obtain a reference to the newly created DataGridViewRow 
                var row = khachHangGridView.Rows[rowIndex++];

                row.Cells["cmnd"].Value = kh.CMND;
                row.Cells["tenKH"].Value = kh.tenKH;

                row.Cells["diaChi"].Value = kh.diaChi;
                row.Cells["gioiTinh"].Value = kh.gioiTinh;

                row.Cells["sdt"].Value = kh.SDT;

                row.Tag = kh;
            };
        }

        private void initCombobox()
        {
            List<string> list = QuanLyDAO<KhachHang>.getTableColumNames();

            foreach (var item in list) 
            {
                thuocTinhCB.Items.Add(item);
            }

            thuocTinhCB.SelectedIndex = 0;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (khachHangGridView.SelectedRows.Count == 0 || khachHangGridView.SelectedRows[0].Tag == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần chỉnh sửa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHang selectedItem = khachHangGridView.SelectedRows[0].Tag as KhachHang;

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
            if (khachHangGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xoá!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult isDelete = MessageBox.Show("Bạn có chắc chắn là muốn xoá dòng hiện tại!!!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (isDelete == DialogResult.No) return;

            UIQuanLy.Alert("Xoá thành công!!!", AlertForm.enmType.Error);
            
            KhachHang selectedItem = khachHangGridView.SelectedRows[0].Tag as KhachHang;
            new KhachHangDAO().removeData(selectedItem);
            //QuanLyDAO<KhachHang>.remove(selectedItem, "CMND");

            khachHangGridView.Rows.Clear();
            initListView();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = thuocTinhCB.SelectedItem;
            
            List<KhachHang> resultList = QuanLyDAO<KhachHang>.searchData(selectedItem.ToString(), searchTxt.Text);

            khachHangGridView.Rows.Clear();

            foreach (KhachHang kh in resultList)
            {
                int rowIndex = khachHangGridView.Rows.Add();

                //Obtain a reference to the newly created DataGridViewRow 
                var row = khachHangGridView.Rows[rowIndex++];

                row.Cells["cmnd"].Value = kh.CMND;
                row.Cells["tenKH"].Value = kh.tenKH;

                row.Cells["diaChi"].Value = kh.diaChi;
                row.Cells["gioiTinh"].Value = kh.gioiTinh;

                row.Cells["sdt"].Value = kh.SDT;

                row.Tag = kh;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.showAdd(new KhachHang());
            edit.FormClosed += new FormClosedEventHandler(form_close);
        }

        private void khachHangGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) return;

            rightClickContextMenu.Show(this, khachHangGridView.PointToClient(Cursor.Position));//places the menu at the pointer position
        }

        private void khachHangGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;

            KhachHang selectedItem = khachHangGridView.SelectedRows[0].Tag as KhachHang;

            EditForm edit = new EditForm();
            edit.showEdit(selectedItem);
            edit.FormClosed += new FormClosedEventHandler(form_close);
        }
    }
}
