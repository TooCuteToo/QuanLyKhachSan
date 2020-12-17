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

namespace DoAn_QuanLyKhachSan.UI
{
    public partial class UIDatPhong : UserControl
    {
        public UIDatPhong()
        {
            InitializeComponent();
            initListViewColumn();

            initListView();
            initCombobox();
        }


        private void initListViewColumn()
        {
            datPhongLV.Items.Add(new ListViewItem(new string[] { "MÃ HOÁ ĐƠN", "CMND", "MÃ NHÂN VIÊN", "SỐ PHÒNG", "NGÀY ĐẶT", "NGÀY TRẢ", "THÀNH TIỀN" }));
            //rgba(245, 246, 250,1.0)
            datPhongLV.Items[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            datPhongLV.Items[0].Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datPhongLV.Items[0].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
        }

        private void initListView()
        {
            datPhongLV.Items.Clear();
            initListViewColumn();

            foreach (HoaDon datPhong in QuanLyDAO<HoaDon>.getData()) {
                ListViewItem item = new ListViewItem(new string[] { 
                    datPhong.maHD, 
                    datPhong.CMND, 

                    datPhong.maNV, 
                    datPhong.soPhong, 

                    datPhong.ngayDat.Value.ToString("dd/MM/yyyy"),
                    datPhong.ngayTra.Value.ToString("dd/MM/yyyy"),

                    datPhong.tienThanhToan.ToString()
                });

                item.Tag = datPhong;
                datPhongLV.Items.Add(item);
            }
        }

        private void initCombobox()
        {
            var list = QuanLyDAO<HoaDon>.getTableColumNames();

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
            if (datPhongLV.SelectedItems.Count == 0 || datPhongLV.SelectedItems[0].Tag == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần chỉnh sửa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
 
            HoaDon selectedItem = datPhongLV.SelectedItems[0].Tag as HoaDon;

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
            HoaDon selectedItem = datPhongLV.SelectedItems[0].Tag as HoaDon;
            new DatPhongDAO().removeData(selectedItem);

            datPhongLV.Items.Clear();
            initListView();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = thuocTinhCB.SelectedItem;

            List<HoaDon> resultList = QuanLyDAO<HoaDon>.searchData(selectedItem.ToString(), searchTxt.Text);

            datPhongLV.Items.Clear();

            initListViewColumn();

            foreach (HoaDon hd in resultList)
            {
                ListViewItem item = new ListViewItem(new string[] { 
                    hd.maHD, 
                    hd.CMND, 
                    hd.maNV, 
                    hd.soPhong, 
                    hd.ngayDat.Value.ToString("dd/MM/yyyy"), 
                    hd.ngayTra.Value.ToString("dd/MM/yyyy"), 
                    hd.tienThanhToan.ToString()
                });

                item.Tag = hd;
                datPhongLV.Items.Add(item);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.showAdd(new HoaDon());
            edit.FormClosed += new FormClosedEventHandler(form_close);
        }
    }
}
