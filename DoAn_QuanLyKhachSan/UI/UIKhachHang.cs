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

namespace DoAn_QuanLyKhachSan
{
    public partial class UIKhachHang : UserControl
    {
        List<KhachHangPOJO> listKhachHang;

        public UIKhachHang()
        {
            InitializeComponent();
            initListViewColumn();

            listKhachHang = KhachHangDAO.getDSKhachHang();
            initListView();
        }

        private void initListViewColumn()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "CMND", "TÊN KHÁCH HÀNG", "ĐỊA CHỈ", "GIỚI TÍNH", "SDT", "QUỐC TỊCH" }));
            //rgba(245, 246, 250,1.0)
            listView1.Items[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            listView1.Items[0].Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listView1.Items[0].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
        }

        private void initListView()
        {
            foreach (KhachHangPOJO kh in listKhachHang) {
                ListViewItem item = new ListViewItem(new string[] { kh.CMND, kh.tenKH, kh.diaChi, kh.gioiTinh, kh.sdt, kh.quocTich });
                listView1.Items.Add(item);
            }
        }
    }
}
