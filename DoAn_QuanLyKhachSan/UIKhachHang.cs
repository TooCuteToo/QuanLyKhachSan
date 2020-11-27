using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan
{
    public partial class UIKhachHang : UserControl
    {
        public UIKhachHang()
        {
            InitializeComponent();
            listView1.Items.Add(new ListViewItem(new string[] { "CMND", "TÊN KHÁCH HÀNG", "ĐỊA CHỈ", "GIỚI TÍNH", "SDT", "QUỐC TỊCH" }));
            //rgba(245, 246, 250,1.0)
            listView1.Items[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            listView1.Items[0].Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listView1.Items[0].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));

            initListView(); InitializeComponent();
        }

        private void initListView()
        {

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (KhachHang kh in db.KhachHangs)
                {
                    ListViewItem item = new ListViewItem(new string[] {
                        kh.CMND,
                        kh.tenKH,
                        kh.diaChi,
                        kh.gioiTinh,
                        kh.SDT,
                        kh.quocTich
                    });

                    listView1.Items.Add(item);
                }
            }
        }
    }
}
