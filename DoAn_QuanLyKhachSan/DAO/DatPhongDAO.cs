using DoAn_QuanLyKhachSan.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyKhachSan.DAO
{
    class DatPhongDAO
    {
        public static List<DatPhongPOJO> getDSDatPhong()
        {
            List<DatPhongPOJO> listDatPhong = new List<DatPhongPOJO>();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (HoaDon hd in db.HoaDons)
                {
                    DatPhongPOJO dpPOJO = new DatPhongPOJO()
                    {
                        maHD = hd.maHD,
                        CMND = hd.CMND,
                        maNV = hd.maNV,
                        soPhong = hd.soPhong,
                        ngayDat = hd.ngayDat.Value.ToString("dd/MM/yyyy"),
                        ngayTra = hd.ngayTra.Value.ToString("dd/MM/yyyy"),
                        thanhTien = hd.tienThanhToan
                    };

                    listDatPhong.Add(dpPOJO);
                }
            }

            return listDatPhong;
        }
    }
}
