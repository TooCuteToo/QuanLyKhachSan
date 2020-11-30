using DoAn_QuanLyKhachSan.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyKhachSan.DAO
{
    class PhieuDichVuDAO
    {
        public static List<PhieuDichVuPOJO> getDSPhieuDichVu()
        {
            List<PhieuDichVuPOJO> listPhieuDichVu = new List<PhieuDichVuPOJO>();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (PhieuDichVu phieuDV in db.PhieuDichVus)
                {
                    PhieuDichVuPOJO PhieuDichVuPOJO = new PhieuDichVuPOJO()
                    {
                        maDV = phieuDV.maDV,
                        tenDV = phieuDV.tenDV,
                        giaDV = phieuDV.giaDV
                    };

                    listPhieuDichVu.Add(PhieuDichVuPOJO);
                }
            }

            return listPhieuDichVu;
        }
    }
}
