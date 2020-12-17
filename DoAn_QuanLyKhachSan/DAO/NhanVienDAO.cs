using DoAn_QuanLyKhachSan.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyKhachSan.DAO
{
    class NhanVienDAO : QuanLyDAO<NhanVien>
    {
        public override void removeData(NhanVien nv)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                NhanVien removedItem = db.NhanViens.Where(elem => elem.maNV == nv.maNV).FirstOrDefault();
                db.NhanViens.DeleteOnSubmit(removedItem);
                db.SubmitChanges();
            }
        }


        public override void updateData(NhanVien nv)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                NhanVien selectedItem = db.NhanViens.Where(elem => elem.maNV == nv.maNV).FirstOrDefault();

                selectedItem.tenNV = nv.tenNV;
                selectedItem.SDT = nv.SDT;

                selectedItem.diaChi = nv.diaChi;
                selectedItem.gioiTinh = nv.gioiTinh;

                selectedItem.ngaySinh = nv.ngaySinh;
                selectedItem.ngayVaoLam = nv.ngayVaoLam;

                db.SubmitChanges();
            }
        }
    }
}
