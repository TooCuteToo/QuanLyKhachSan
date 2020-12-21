﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

                foreach (var column in columns)
                {
                    string propertyInfo = column.ToString();

                    if (!propertyInfo.EndsWith("s"))
                    {
                        columnNames.Add(propertyInfo);
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

        public static void addData(T t)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                try 
                {
                    db.DeferredLoadingEnabled = false;
                    db.GetTable<T>().InsertOnSubmit(t);
                    db.SubmitChanges();
                }
                catch (SqlException sqlex)
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

                    if (sqlex.Message.Contains("Ngay"))
                    {
                        MessageBox.Show("Ngày trả phải lớn hơn ngày đặt!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                
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
