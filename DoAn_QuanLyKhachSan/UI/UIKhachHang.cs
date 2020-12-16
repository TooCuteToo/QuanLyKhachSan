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
            initListViewColumn();

            initListView();
            initCombobox();
        }

        private void initListViewColumn()
        {
            khachHangLV.Items.Add(new ListViewItem(new string[] { "CMND", "TÊN KHÁCH HÀNG", "ĐỊA CHỈ", "GIỚI TÍNH", "SDT" }));
            //rgba(245, 246, 250,1.0)
            khachHangLV.Items[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            khachHangLV.Items[0].Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            khachHangLV.Items[0].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
        }

        private void initListView()
        {
            foreach (KhachHang kh in QuanLyDAO<KhachHang>.getData()) {
                ListViewItem item = new ListViewItem(new string[] { kh.CMND, kh.tenKH, kh.diaChi, kh.gioiTinh, kh.SDT });
                item.Tag = kh;
                khachHangLV.Items.Add(item);
            }
        }

        private void initCombobox()
        {
            var list = QuanLyDAO<KhachHang>.getTableColumNames();

            foreach (var item in list) 
            {
                int startIndex = item.IndexOf(' ');
                string property = item.Substring(startIndex).Trim();
                thuocTinhCB.Items.Add(property);
            }

            thuocTinhCB.SelectedIndex = 0;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (khachHangLV.SelectedItems.Count == 0) return;

            KhachHang selectedItem = khachHangLV.SelectedItems[0].Tag as KhachHang;

            EditForm edit = new EditForm();
            edit.showEdit(selectedItem);

            
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            KhachHang selectedItem = khachHangLV.SelectedItems[0].Tag as KhachHang;
            new KhachHangDAO().removeData(selectedItem);

            khachHangLV.Items.Clear();
            initListView();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = thuocTinhCB.SelectedItem;
            
            List<KhachHang> resultList = QuanLyDAO<KhachHang>.searchData(selectedItem.ToString(), searchTxt.Text);

            khachHangLV.Items.Clear();

            initListViewColumn();

            foreach (KhachHang kh in resultList)
            {
                ListViewItem item = new ListViewItem(new string[] { 
                    kh.CMND, 
                    kh.tenKH, 
                    kh.diaChi, 
                    kh.gioiTinh, 
                    kh.SDT, 
                });

                item.Tag = kh;
                khachHangLV.Items.Add(item);
            }
        }
    }
}
