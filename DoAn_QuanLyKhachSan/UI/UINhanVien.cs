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
            initListViewColumn();

            initListView();
            initCombobox();
        }

        private void initListViewColumn()
        {
            nhanVienLV.Items.Add(new ListViewItem(new string[] { "MÃ NHÂN VIÊN", "TÊN NHÂN VIÊN", "GIỚI TÍNH", "NGÀY SINH", "ĐỊA CHỈ", "SDT" }));
            //rgba(245, 246, 250,1.0)
            nhanVienLV.Items[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            nhanVienLV.Items[0].Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nhanVienLV.Items[0].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
        }

        private void initListView()
        {
            nhanVienLV.Items.Clear();
            initListViewColumn();

            foreach (NhanVien nv in QuanLyDAO<NhanVien>.getData())
            {
                ListViewItem item = new ListViewItem(new string[] {
                        nv.maNV,
                        nv.tenNV,
                        nv.gioiTinh,
                        nv.ngaySinh.Value.ToString("dd/MM/yyyy"),
                        nv.diaChi,
                        nv.SDT
                    });

                item.Tag = nv;

                nhanVienLV.Items.Add(item);
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
            NhanVien selectedNV = nhanVienLV.SelectedItems[0].Tag as NhanVien;
            new NhanVienDAO().removeData(selectedNV);

            nhanVienLV.Items.Clear();
            initListView();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (nhanVienLV.SelectedItems.Count == 0 || nhanVienLV.SelectedItems[0].Tag == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần chỉnh sửa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhanVien selectedItem = nhanVienLV.SelectedItems[0].Tag as NhanVien;
           
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

            nhanVienLV.Items.Clear();
            initListViewColumn();
            
            List<NhanVien> resultList = QuanLyDAO<NhanVien>.searchData(selectedItem.ToString(), searchTxt.Text);

            foreach (NhanVien nv in resultList)
            {
                ListViewItem item = new ListViewItem(new string[] { 
                    nv.maNV, 
                    nv.tenDN, 
                    nv.gioiTinh, 
                    nv.ngaySinh.Value.ToString("dd/MM/yyyy"), 
                    nv.diaChi, 
                    nv.SDT 
                });

                item.Tag = nv;
                nhanVienLV.Items.Add(item);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.showAdd(new NhanVien());
            edit.FormClosed += new FormClosedEventHandler(form_close);
        }


    }
}
