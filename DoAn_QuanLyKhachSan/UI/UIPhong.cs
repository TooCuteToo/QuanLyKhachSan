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

            initListView();
            initCombobox();

            rightClickContextMenu.Items.Add("ADD", null, new EventHandler(addBtn_Click));
            rightClickContextMenu.Items.Add("EDIT", null, new EventHandler(editBtn_Click));
            rightClickContextMenu.Items.Add("DELETE", null, new EventHandler(removeBtn_Click));
        }

        private void initListView()
        {
            phongGridView.Rows.Clear();

            foreach (Phong phong in QuanLyDAO<Phong>.getData())
            {
                int rowIndex = phongGridView.Rows.Add();

                //Obtain a reference to the newly created DataGridViewRow 
                var row = phongGridView.Rows[rowIndex++];

                row.Cells["soPhong"].Value = phong.soPhong;
                row.Cells["tinhTrang"].Value = phong.tinhTrang;
                row.Cells["maLoai"].Value = phong.maLoai;

                row.Tag = phong;
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
            if (phongGridView.SelectedRows.Count == 0 || phongGridView.SelectedRows[0].Tag == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần chỉnh sửa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Phong selectedItem = phongGridView.SelectedRows[0].Tag as Phong;

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
            if (phongGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xoá!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult isDelete = MessageBox.Show("Bạn có chắc chắn là muốn xoá dòng hiện tại!!!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (isDelete == DialogResult.No) return;

            UIQuanLy.Alert("Xoá thành công!!!", AlertForm.enmType.Error);

            Phong selectedItem = phongGridView.SelectedRows[0].Tag as Phong;
            new PhongDAO().removeData(selectedItem);

            phongGridView.Rows.Clear();
            initListView();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = thuocTinhCB.SelectedItem;

            List<Phong> resultList = QuanLyDAO<Phong>.searchData(selectedItem.ToString(), searchTxt.Text);

            phongGridView.Rows.Clear();

            foreach (Phong phong in resultList)
            {
                int rowIndex = phongGridView.Rows.Add();

                //Obtain a reference to the newly created DataGridViewRow 
                var row = phongGridView.Rows[rowIndex++];

                row.Cells["soPhong"].Value = phong.soPhong;
                row.Cells["tinhTrang"].Value = phong.tinhTrang;
                row.Cells["maLoai"].Value = phong.maLoai;

                row.Tag = phong;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.showAdd(new Phong());
            edit.FormClosed += new FormClosedEventHandler(form_close);
        }

        private void phongGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) return;

            rightClickContextMenu.Show(this, phongGridView.PointToClient(Cursor.Position));//places the menu at the pointer position
        }

        private void phongGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;

            Phong selectedItem = phongGridView.SelectedRows[0].Tag as Phong;

            EditForm edit = new EditForm();
            edit.showEdit(selectedItem);
            edit.FormClosed += new FormClosedEventHandler(form_close);
        }

        private void UIPhong_Enter(object sender, EventArgs e)
        {
            initListView();
        }
    }
}
