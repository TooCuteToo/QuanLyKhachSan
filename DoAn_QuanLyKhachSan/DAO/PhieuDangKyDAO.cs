using DoAn_QuanLyKhachSan.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyKhachSan.DAO
{
    class PhieuDangKyDAO
    {
        public static List<PhieuDangKyPOJO> getDSPhieuDangKy()
        {
            List<PhieuDangKyPOJO> listPhieuDangKy = new List<PhieuDangKyPOJO>();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (PhieuDangKy phieuDK in db.PhieuDangKies)
                {
                    PhieuDangKyPOJO PhieuDangKyPOJO = new PhieuDangKyPOJO()
                    {
                        maDK = phieuDK.maDK,
                        maDV = phieuDK.maDV,
                        CMND = phieuDK.CMND,
                        soPhong = phieuDK.soPhong,
                        soTienDat = phieuDK.soTienDatCoc
                    };

                    listPhieuDangKy.Add(PhieuDangKyPOJO);
                }
            }

            return listPhieuDangKy;
        }
    }
}
