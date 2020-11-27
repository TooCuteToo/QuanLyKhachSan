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

namespace DoAn_QuanLyKhachSan
{
    public partial class UINhanVien : UserControl
    {
        List<NhanVienPOJO> listNhanVien;

        public UINhanVien()
        {
            InitializeComponent();
            initListViewColumn();
            listNhanVien = NhanVienDAO.getDSNhanVien();
            initListView();
        }

        private void initListViewColumn()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "MÃ NHÂN VIÊN", "TÊN NHÂN VIÊN", "GIỚI TÍNH", "NGÀY SINH", "ĐỊA CHỈ", "SDT" }));
            //rgba(245, 246, 250,1.0)
            listView1.Items[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            listView1.Items[0].Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listView1.Items[0].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
        }

        private void initListView()
        {
            foreach (NhanVienPOJO nv in listNhanVien)
            {
                ListViewItem item = new ListViewItem(new string[] {
                        nv.maNV,
                        nv.tenNV,
                        nv.gioiTinh,
                        nv.ngaySinh,
                        nv.diaChi,
                        nv.sdt
                    });

                listView1.Items.Add(item);
            }
        }


    }
}
