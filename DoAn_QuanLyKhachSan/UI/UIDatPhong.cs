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
using System.Globalization;

namespace DoAn_QuanLyKhachSan.UI
{
    public partial class UIDatPhong : UserControl
    {
        public UIDatPhong(object val)
        {
            InitializeComponent();

            initListView();
            initCombobox();

            this.Tag = val;

            checkCV();
        }

        private void initListView()
        {
            datPhongGridView.Rows.Clear();

            foreach (HoaDon datPhong in QuanLyDAO<HoaDon>.getData())
            {
                int rowIndex = datPhongGridView.Rows.Add();

                //Obtain a reference to the newly created DataGridViewRow 
                var row = datPhongGridView.Rows[rowIndex++];

                row.Cells["maHD"].Value = datPhong.maHD;
                row.Cells["cmnd"].Value = datPhong.CMND;

                row.Cells["maNV"].Value = datPhong.maNV;
                row.Cells["soPhong"].Value = datPhong.soPhong;

                row.Cells["ngayDat"].Value = datPhong.ngayDat.Value.ToString("dd/MM/yyyy");
                row.Cells["ngayTra"].Value = datPhong.ngayTra.Value.ToString("dd/MM/yyyy");

                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                row.Cells["tienThanhToan"].Value = datPhong.tienThanhToan.Value.ToString("#,###", cul.NumberFormat);

                row.Tag = datPhong;
            }
        }

        private void checkCV()
        {
            NhanVien nv = this.Tag as NhanVien;

            if (nv.maCV != "CV01")
            {
                removeBtn.Enabled = false;
                rightClickContextMenu.Items.Add("ADD", null, new EventHandler(addBtn_Click));
                rightClickContextMenu.Items.Add("EDIT", null, new EventHandler(editBtn_Click));

                return;
            }

            rightClickContextMenu.Items.Add("ADD", null, new EventHandler(addBtn_Click));
            rightClickContextMenu.Items.Add("EDIT", null, new EventHandler(editBtn_Click));
            rightClickContextMenu.Items.Add("DELETE", null, new EventHandler(removeBtn_Click));

            return;
        }

        private void initCombobox()
        {
            List<string> list = QuanLyDAO<HoaDon>.getTableColumNames();

            foreach (var item in list)
            {
                thuocTinhCB.Items.Add(item);
            }

            thuocTinhCB.SelectedIndex = 0;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (datPhongGridView.SelectedRows.Count == 0 || datPhongGridView.SelectedRows[0].Tag == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần chỉnh sửa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HoaDon selectedItem = datPhongGridView.SelectedRows[0].Tag as HoaDon;

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
            if (datPhongGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xoá!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult isDelete = MessageBox.Show("Bạn có chắc chắn là muốn xoá dòng hiện tại!!!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (isDelete == DialogResult.No) return;

            UIQuanLy.Alert("Xoá thành công!!!", AlertForm.enmType.Error);

            HoaDon selectedItem = datPhongGridView.SelectedRows[0].Tag as HoaDon;
            new DatPhongDAO().removeData(selectedItem);

            //datPhongGridView.Items.Clear();
            initListView();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = thuocTinhCB.SelectedItem;

            List<HoaDon> resultList = QuanLyDAO<HoaDon>.searchData(selectedItem.ToString(), searchTxt.Text);

            datPhongGridView.Rows.Clear();

            foreach (HoaDon datPhong in resultList)
            {
                int rowIndex = datPhongGridView.Rows.Add();

                //Obtain a reference to the newly created DataGridViewRow 
                var row = datPhongGridView.Rows[rowIndex++];

                row.Cells["maHD"].Value = datPhong.maHD;
                row.Cells["cmnd"].Value = datPhong.CMND;

                row.Cells["maNV"].Value = datPhong.maNV;
                row.Cells["soPhong"].Value = datPhong.soPhong;

                row.Cells["ngayDat"].Value = datPhong.ngayDat.Value.ToString("dd/MM/yyyy");
                row.Cells["ngayTra"].Value = datPhong.ngayTra.Value.ToString("dd/MM/yyyy");

                row.Cells["tienThanhToan"].Value = datPhong.tienThanhToan.ToString();
                row.Tag = datPhong;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.showAdd(new HoaDon());
            edit.FormClosed += new FormClosedEventHandler(form_close);
        }

        private void datPhongGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) return;

            rightClickContextMenu.Show(this, datPhongGridView.PointToClient(Cursor.Position));//places the menu at the pointer position
        }

        private void datPhongGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!editBtn.Enabled) return;

            if (e.Button == MouseButtons.Right) return;

            HoaDon selectedItem = datPhongGridView.SelectedRows[0].Tag as HoaDon;

            EditForm edit = new EditForm();
            edit.showEdit(selectedItem);
            edit.FormClosed += new FormClosedEventHandler(form_close);
        }
    }
}
