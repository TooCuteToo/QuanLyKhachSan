using DoAn_QuanLyKhachSan.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyKhachSan.DAO
{
    class KhachHangDAO : QuanLyDAO<KhachHang>
    {
        public override void removeData(KhachHang kh)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                KhachHang removedItem = db.KhachHangs.Where(elem => elem.CMND == kh.CMND).FirstOrDefault();
                db.KhachHangs.DeleteOnSubmit(removedItem);
                db.SubmitChanges();
            }
        }


        public override void updateData(KhachHang kh)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                KhachHang selectedItem = db.KhachHangs.Where(elem => elem.CMND == kh.CMND).FirstOrDefault();
                
                selectedItem.tenKH = kh.tenKH;
                selectedItem.gioiTinh = kh.gioiTinh;
                
                selectedItem.diaChi = kh.diaChi;
                selectedItem.loai = kh.loai;
                
                selectedItem.SDT = kh.SDT;

                db.SubmitChanges();
            }
        }
    }
}
