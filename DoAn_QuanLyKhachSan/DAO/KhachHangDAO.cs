using DoAn_QuanLyKhachSan.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyKhachSan.DAO
{
    class KhachHangDAO
    {
        public static List<KhachHangPOJO> getDSKhachHang()
        {
            List<KhachHangPOJO> listKhachHang = new List<KhachHangPOJO>();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (KhachHang kh in db.KhachHangs)
                {
                    KhachHangPOJO khPOJO = new KhachHangPOJO()
                    {
                        CMND = kh.CMND,
                        tenKH = kh.tenKH,
                        diaChi = kh.diaChi,
                        gioiTinh = kh.gioiTinh,
                        sdt = kh.SDT,
                        quocTich = kh.quocTich,
                        loai = kh.loai
                    };

                    listKhachHang.Add(khPOJO);
                }
            }

            return listKhachHang;
        }
    }
}
