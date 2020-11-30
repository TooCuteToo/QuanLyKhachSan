using DoAn_QuanLyKhachSan.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyKhachSan.DAO
{
    class LoaiPhongDAO
    {
        public static List<LoaiPhongPOJO> getDSLoaiPhong()
        {
            List<LoaiPhongPOJO> listLoaiPhong = new List<LoaiPhongPOJO>();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (LoaiPhong loaiPhong in db.LoaiPhongs)
                {
                    LoaiPhongPOJO LoaiPhongPOJO = new LoaiPhongPOJO()
                    {
                        maLoai = loaiPhong.maLoai,
                        tenLoai = loaiPhong.tenLP,
                        gia = loaiPhong.gia
                    };

                    listLoaiPhong.Add(LoaiPhongPOJO);
                }
            }

            return listLoaiPhong;
        }
    }
}
