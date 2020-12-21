using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_QuanLyKhachSan;
using DoAn_QuanLyKhachSan.POJO;
using DoAn_QuanLyKhachSan.DAO;
using DoAn_QuanLyKhachSan.UI;

namespace DoAn_QuanLyKhachSan
{
    public partial class UINhanVien : UserControl
    {
        public UINhanVien()
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
            nhanVienGridView.Rows.Clear();
            
            foreach (NhanVien nv in QuanLyDAO<NhanVien>.getData())
            {
                int rowIndex = nhanVienGridView.Rows.Add();

                //Obtain a reference to the newly created DataGridViewRow 
                var row = nhanVienGridView.Rows[rowIndex++];

                row.Cells["maNV"].Value = nv.maNV;
                row.Cells["tenNV"].Value = nv.tenNV;

                row.Cells["gioiTinh"].Value = nv.gioiTinh;
                row.Cells["ngaySinh"].Value = nv.ngaySinh.Value.ToString("dd/MM/yyyy");

                row.Cells["ngayVaoLam"].Value = nv.ngayVaoLam.Value.ToString("dd/MM/yyyy");
                row.Cells["diaChi"].Value = nv.diaChi;

                row.Cells["sdt"].Value = nv.SDT;
                row.Tag = nv;
            }
        }

        private void initCombobox()
        {
            var list = QuanLyDAO<NhanVien>.getTableColumNames();

            foreach (var item in list)
            {
                string name = item.ToString();
                int startIndex = name.IndexOf(' ');
                string property = name.Substring(startIndex).Trim();
                thuocTinhCB.Items.Add(property);
            }

            thuocTinhCB.SelectedIndex = 0;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (nhanVienGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xoá!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult isDelete = MessageBox.Show("Bạn có chắc chắn là muốn xoá dòng hiện tại!!!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (isDelete == DialogResult.No) return;

            UIQuanLy.Alert("Xoá thành công!!!", AlertForm.enmType.Error);

            NhanVien selectedNV = nhanVienGridView.SelectedRows[0].Tag as NhanVien;
            new NhanVienDAO().removeData(selectedNV);

            initListView();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (nhanVienGridView.SelectedRows.Count == 0 || nhanVienGridView.SelectedRows[0].Tag == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần chỉnh sửa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhanVien selectedItem = nhanVienGridView.SelectedRows[0].Tag as NhanVien;
           
            EditForm edit = new EditForm();
            edit.showEdit(selectedItem);
            edit.FormClosed += new FormClosedEventHandler(form_close);
        }

        private void form_close(object sender, FormClosedEventArgs e)
        {
            initListView();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = thuocTinhCB.SelectedItem;

            nhanVienGridView.Rows.Clear();
            
            List<NhanVien> resultList = QuanLyDAO<NhanVien>.searchData(selectedItem.ToString(), searchTxt.Text);

            foreach (NhanVien nv in resultList)
            {
                int rowIndex = nhanVienGridView.Rows.Add();

                //Obtain a reference to the newly created DataGridViewRow 
                var row = nhanVienGridView.Rows[rowIndex++];

                row.Cells["maNV"].Value = nv.maNV;
                row.Cells["tenNV"].Value = nv.tenNV;

                row.Cells["gioiTinh"].Value = nv.gioiTinh;
                row.Cells["ngaySinh"].Value = nv.ngaySinh.Value.ToString("dd/MM/yyyy");

                row.Cells["ngayVaoLam"].Value = nv.ngayVaoLam.Value.ToString("dd/MM/yyyy");
                row.Cells["diaChi"].Value = nv.diaChi;

                row.Cells["sdt"].Value = nv.SDT;
                row.Tag = nv;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.showAdd(new NhanVien());
            edit.FormClosed += new FormClosedEventHandler(form_close);
        }

        private void nhanVienGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) return;

            rightClickContextMenu.Show(this, nhanVienGridView.PointToClient(Cursor.Position));//places the menu at the pointer position
        }

        private void nhanVienGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;

            NhanVien selectedItem = nhanVienGridView.SelectedRows[0].Tag as NhanVien;

            EditForm edit = new EditForm();
            edit.showEdit(selectedItem);
            edit.FormClosed += new FormClosedEventHandler(form_close);
        }
    }
}
