using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan.DAO
{
    class DatPhongDAO : QuanLyDAO<HoaDon>
    {
        public override void removeData(HoaDon hd)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                HoaDon removedItem = db.HoaDons.Where(elem => elem.maHD == hd.maHD).FirstOrDefault();
                db.HoaDons.DeleteOnSubmit(removedItem);
                db.SubmitChanges();
            }
        }


        public override void updateData(HoaDon hd)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                try
                {
                    HoaDon selectedItem = db.HoaDons.Where(elem => elem.maHD == hd.maHD).FirstOrDefault();

                    selectedItem.soPhong = hd.soPhong;
                    selectedItem.CMND = hd.CMND;

                    selectedItem.maNV = hd.maNV;
                    selectedItem.ngayDat = hd.ngayDat;

                    selectedItem.ngayTra = hd.ngayTra;
                    selectedItem.tienThanhToan = hd.tienThanhToan;

                    db.SubmitChanges();

                    UIQuanLy.Alert("Thay đổi thành công!!!", AlertForm.enmType.Info);
                }

                catch (SqlException sqlex)
                {
                    if (sqlex.Message.Contains("Ngay"))
                    {
                        MessageBox.Show("Ngày trả phải lớn hơn ngày đặt!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (sqlex.Message.Contains("Phòng"))
                    {
                        MessageBox.Show("Phòng này đã có khách!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
    }
}
