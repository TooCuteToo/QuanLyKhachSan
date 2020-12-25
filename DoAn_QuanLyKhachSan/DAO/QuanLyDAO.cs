using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan.DAO
{
    abstract class QuanLyDAO<T> where T : class
    {
        public static List<T> getData()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                db.DeferredLoadingEnabled = false;
                return db.GetTable<T>().ToList();
            }
        }

        public static List<string> getTableColumNames()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                db.DeferredLoadingEnabled = false;
                var columns = typeof(T).GetProperties();
                List<string> columnNames = new List<string>();

                foreach (PropertyInfo column in columns)
                {
                    if (!column.Name.EndsWith("s") && !Char.IsUpper(column.Name[0]) && !column.Name.Contains("tenDN") || column.Name.Contains("CMND") || column.Name.Contains("SDT"))
                    {
                        columnNames.Add(column.Name);
                    }
                }

                return columnNames;
            }
        }

        public static List<T> searchData(string columnName, string value)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                db.DeferredLoadingEnabled = false;
                List<T> tList = db.GetTable<T>().ToList();
                List<T> resultList = tList.Where(item => typeof(T).GetProperty(columnName).GetValue(item).ToString().Contains(value)).ToList();

                return resultList;
            }
        }

        public static int countDataRow(T t)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                return db.GetTable<T>().Count();
            }
        }

        public static T getData(T t, string columnName, string val)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                db.DeferredLoadingEnabled = false;
                List<T> tList = db.GetTable<T>().ToList();
                var result = tList.FirstOrDefault(item => typeof(T).GetProperty(columnName).GetValue(item).ToString().Contains(val));

                return result;
            }
        }

        public static void addData(T t)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                try
                {
                    db.DeferredLoadingEnabled = false;
                    db.GetTable<T>().InsertOnSubmit(t);
                    db.SubmitChanges();

                    UIQuanLy.Alert("Thêm dữ liệu thành công!!!", AlertForm.enmType.Info);
                }
                catch (SqlException sqlex)
                {
                    handleHoaDonSqlex(sqlex);

                    if (sqlex.Message.Contains("Ngay"))
                    {
                        MessageBox.Show("Ngày trả phải lớn hơn ngày đặt!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (sqlex.Message.Contains("PK__KhachHan__"))
                    {
                        MessageBox.Show("Khách hàng này đã tồn tại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (sqlex.Message.Contains("PK__NhanVien__"))
                    {
                        MessageBox.Show("Nhân viên này đã tồn tại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (sqlex.Message.Contains("PK__Phong__"))
                    {
                        MessageBox.Show("Phòng này đã tồn tại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private static void handleHoaDonSqlex(SqlException sqlex)
        {
            if (sqlex.Message.Contains("Phòng"))
            {
                MessageBox.Show("Phòng này đã có khách!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sqlex.Message.Contains("PK__HoaDon__"))
            {
                MessageBox.Show("Hoá đơn này đã tồn tại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sqlex.Message.Contains("Hoadon_CMND"))
            {
                MessageBox.Show("Khách hàng không tồn tại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sqlex.Message.Contains("Hoadon_maNV"))
            {
                MessageBox.Show("Nhân viên không tồn tại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //public static void remove(T t, string columnName)
        //{
        //    using (DataClasses1DataContext db = new DataClasses1DataContext())
        //    {
        //        var item = db.GetTable<T>().FirstOrDefault(elem => typeof(T).GetProperty(columnName).GetValue(elem).ToString().Contains(""));
        //        db.DeferredLoadingEnabled = false;
        //        db.GetTable<T>().DeleteOnSubmit(item);
        //        db.SubmitChanges();
        //    }
        //}


        public abstract void removeData(T t);
        public abstract void updateData(T t);
    }
}
