using DoAn_QuanLyKhachSan.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyKhachSan.DAO
{
    class NhanVienDAO
    {
        public static List<NhanVienPOJO> getDSNhanVien()
        {
            List<NhanVienPOJO> listNhanVien = new List<NhanVienPOJO>();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (NhanVien nv in db.NhanViens)
                {
                    NhanVienPOJO nvPOJO = new NhanVienPOJO()
                    {
                        maNV = nv.maNV,
                        tenNV = nv.tenNV,
                        gioiTinh = nv.gioiTinh,
                        ngaySinh = nv.ngSinh.Value.ToString("dd/MM/yyyy"),
                        diaChi = nv.diaChi,
                        sdt = nv.SDT
                    };

                    listNhanVien.Add(nvPOJO);
                }
            }

            return listNhanVien;
        }
    }
}
