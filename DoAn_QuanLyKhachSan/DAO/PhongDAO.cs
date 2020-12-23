using System.Linq;

namespace DoAn_QuanLyKhachSan.DAO
{
    class PhongDAO : QuanLyDAO<Phong>
    {
        public override void removeData(Phong phong)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Phong removedItem = db.Phongs.Where(elem => elem.soPhong == phong.soPhong).FirstOrDefault();
                db.Phongs.DeleteOnSubmit(removedItem);
                db.SubmitChanges();
            }
        }

        public override void updateData(Phong phong)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Phong selectedItem = db.Phongs.FirstOrDefault(elem => elem.soPhong == phong.soPhong);

                db.Phongs.DeleteOnSubmit(selectedItem);

                db.Phongs.InsertOnSubmit(phong);
                db.SubmitChanges();

                UIQuanLy.Alert("Thay đổi thành công!!!", AlertForm.enmType.Info);
            }
        }
    }
}
