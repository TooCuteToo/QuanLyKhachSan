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

namespace DoAn_QuanLyKhachSan
{
    public partial class UINhanVien : UserControl
    {
        public UINhanVien()
        {
            InitializeComponent();
            listView1.Items.Add(new ListViewItem(new string[] { "MÃ NHÂN VIÊN", "TÊN NHÂN VIÊN", "GIỚI TÍNH", "NGÀY SINH", "ĐỊA CHỈ", "SDT" }));
            //rgba(245, 246, 250,1.0)
            listView1.Items[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            listView1.Items[0].Font = new  System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listView1.Items[0].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));

            initListView();
        }

        private void initListView()
        {

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (NhanVien nv in db.NhanViens)
                {
                    ListViewItem item = new ListViewItem(new string[] {
                        nv.maNV,
                        nv.tenNV,
                        nv.gioiTinh,
                        nv.ngSinh.Value.ToString("dd/MM/yyyy"),
                        nv.diaChi,
                        nv.SDT
                    });

                    listView1.Items.Add(item);
                }
            }
        }


    }
}
