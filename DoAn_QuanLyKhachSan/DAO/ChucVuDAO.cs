using DoAn_QuanLyKhachSan.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyKhachSan.DAO
{
    class ChucVuDAO
    {
        public static List<ChucVuPOJO> getDSChucVu()
        {
            List<ChucVuPOJO> listChucVu = new List<ChucVuPOJO>();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (ChucVu cv in db.ChucVus)
                {
                    ChucVuPOJO ChucVuPOJO = new ChucVuPOJO()
                    {
                        maCV = cv.maCV,
                        tenCV = cv.tenCV
                    };

                    listChucVu.Add(ChucVuPOJO);
                }
            }

            return listChucVu;
        }
    }
}
