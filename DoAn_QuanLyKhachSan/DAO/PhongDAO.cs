using DoAn_QuanLyKhachSan.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyKhachSan.DAO
{
    class PhongDAO
    {
        public static List<PhongPOJO> getDSPhong()
        {
            List<PhongPOJO> listPhong = new List<PhongPOJO>();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (Phong ph in db.Phongs)
                {
                    PhongPOJO phongPOJO = new PhongPOJO()
                    {
                        soPhong = ph.soPhong,
                        maLoai = ph.maLoai,
                        tinhTrang = ph.tinhTrang
                    };

                    listPhong.Add(phongPOJO);
                }
            }

            return listPhong;
        }
    }
}
