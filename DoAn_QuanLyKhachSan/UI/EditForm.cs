using DoAn_QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan.UI
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        public void showAdd<T>(T t)
        {
            initTextBox(t);
            Show();
        }

        private void initTextBox<T>(T t)
        {
            int y = 0;

            if (t == null) return;

            var keys = t.GetType().GetProperties();

            foreach (PropertyInfo property in keys)
            {
                Label label = new Label()
                {
                    Location = new System.Drawing.Point(10, y += 50),
                    Text = property.Name,
                };

                if (property.Name.Contains("ngay"))
                {
                    DateTimePicker datePicker = new DateTimePicker()
                    {
                        Location = new System.Drawing.Point(200, y),
                        Tag = property,
                        CustomFormat = "dd/MM/yyyy",
                        Format = DateTimePickerFormat.Custom,
                    };

                    panel1.Controls.Add(label);
                    panel1.Controls.Add(datePicker);
                    continue;
                }

                if (!property.Name.EndsWith("s") && !property.ToString().Contains("DoAn"))
                {
                    TextBox textBox = new TextBox()
                    {
                        Location = new System.Drawing.Point(200, y),
                        Tag = property,
                        //Size = new Size(200, 120),
                    };

                    panel1.Controls.Add(label);
                    panel1.Controls.Add(textBox);
                }
            }

            addBtn.Tag = t;
        }

        public void showEdit<T>(T t)
        {
            initTextBoxValue(t);
            Show();
        }

        private void initTextBoxValue<T>(T t)
        {
            int x = 0;
            int y = 0;

            if (t == null) return;

            var keys = t.GetType().GetProperties();

            foreach (PropertyInfo property in keys)
            {
                Label label = new Label()
                {
                    Location = new System.Drawing.Point(10, y += 50),
                    Text = property.Name,
                };

                var value = property.GetValue(t);

                if (value != null && !value.ToString().Contains("System"))
                {
                    if (property.Name.Contains("ngay"))
                    {
                        DateTimePicker datePicker = new DateTimePicker()
                        {
                            Value = DateTime.Parse(value.ToString()),
                            Location = new System.Drawing.Point(200, y),
                            Tag = property,
                            CustomFormat = "dd/MM/yyyy",
                            Format = DateTimePickerFormat.Custom,
                        };

                        panel1.Controls.Add(label);
                        panel1.Controls.Add(datePicker);
                        continue;
                    }

                    TextBox textBox = new TextBox()
                    {
                        Text = value.ToString(),
                        Location = new System.Drawing.Point(200, y),
                        Tag = property,
                        Enabled = !property.Name.Contains("ma"),
                        Size = new Size(200, 120),
                    };

                    panel1.Controls.Add(label);
                    panel1.Controls.Add(textBox);
                }
            }

            editBtn.Tag = t;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            List<TextBox> list = panel1.Controls.OfType<TextBox>().ToList();
            List<DateTimePicker> dateList = panel1.Controls.OfType<DateTimePicker>().ToList();

            if (editBtn.Tag.GetType() == typeof(KhachHang))
            {
                KhachHang kh = new KhachHang();
                getData<KhachHang>(kh, list);
                new KhachHangDAO().updateData(kh);

                return;
            }

            if (editBtn.Tag.GetType() == typeof(NhanVien))
            {
                NhanVien nv = new NhanVien();
                getData<NhanVien>(nv, list, dateList);
                new NhanVienDAO().updateData(nv);

                return;
            }

            if (editBtn.Tag.GetType() == typeof(HoaDon))
            {
                HoaDon hd = new HoaDon();
                getData<HoaDon>(hd, list, dateList);
                new DatPhongDAO().updateData(hd);

                return;
            }

            if (editBtn.Tag.GetType() == typeof(Phong))
            {
                Phong phong = new Phong();
                getData<Phong>(phong, list);
                new PhongDAO().updateData(phong);

                return;
            }
        }

        //private void updateKhachHang(List<TextBox> list)
        //{
        //    KhachHang kh = new KhachHang();

        //    foreach (TextBox text in list)
        //    {
        //        PropertyInfo property = text.Tag as PropertyInfo;
        //        typeof(KhachHang).GetProperty(property.Name).SetValue(kh, text.Text);
        //    }

        //    new KhachHangDAO().updateData(kh);
        //}

        

        //private void updateNhanVien(List<TextBox> list, List<DateTimePicker> dateList)
        //{
        //    NhanVien kh = new NhanVien();

        //    foreach (TextBox text in list)
        //    {
        //        PropertyInfo property = text.Tag as PropertyInfo;
        //        typeof(NhanVien).GetProperty(property.Name).SetValue(kh, text.Text);
        //    }

        //    foreach (DateTimePicker datePicker in dateList)
        //    {
        //        PropertyInfo property = datePicker.Tag as PropertyInfo;
        //        typeof(NhanVien).GetProperty(property.Name).SetValue(kh, datePicker.Value);
        //    }

        //    new NhanVienDAO().updateData(kh);
        //}

        //private void updatePhong(List<TextBox> list)
        //{
        //    Phong kh = new Phong();

        //    foreach (TextBox text in list)
        //    {
        //        PropertyInfo property = text.Tag as PropertyInfo;
        //        typeof(Phong).GetProperty(property.Name).SetValue(kh, text.Text);
        //    }

        //    new PhongDAO().updateData(kh);
        //}

        //private void updateDatPhong(List<TextBox> list)
        //{
        //    HoaDon kh = new HoaDon();

        //    foreach (TextBox text in list)
        //    {
        //        PropertyInfo property = text.Tag as PropertyInfo;

        //        if (text.Text.Contains("/"))
        //        {
        //            typeof(HoaDon).GetProperty(property.Name).SetValue(kh, DateTime.Parse(text.Text));
        //            continue;
        //        }

        //        if (property.Name == "tienThanhToan") {
        //            typeof(HoaDon).GetProperty(property.Name).SetValue(kh, decimal.Parse(text.Text));
        //            continue;
        //        }

        //        typeof(HoaDon).GetProperty(property.Name).SetValue(kh, text.Text);
        //    }

        //    new DatPhongDAO().updateData(kh);
        //}

        private void addBtn_Click(object sender, EventArgs e)
        {
            List<TextBox> list = panel1.Controls.OfType<TextBox>().ToList();
            List<DateTimePicker> dateList = panel1.Controls.OfType<DateTimePicker>().ToList();

            if (addBtn.Tag.GetType() == typeof(KhachHang))
            {
                KhachHang kh = new KhachHang();
                getData<KhachHang>(kh, list);
                QuanLyDAO<KhachHang>.addData(kh);

                return;
            }

            if (addBtn.Tag.GetType() == typeof(NhanVien))
            {
                NhanVien nv = new NhanVien();
                getData<NhanVien>(nv, list, dateList);
                QuanLyDAO<NhanVien>.addData(nv);

                return;
            }

            if (addBtn.Tag.GetType() == typeof(HoaDon))
            {
                HoaDon hd = new HoaDon();
                getData<HoaDon>(hd, list);
                QuanLyDAO<HoaDon>.addData(hd);

                return;
            }

            if (addBtn.Tag.GetType() == typeof(Phong))
            {
                Phong phong = new Phong();
                getData<Phong>(phong, list);
                QuanLyDAO<Phong>.addData(phong);

                return;
            }
        }

        private object getData<T>(T t, List<TextBox> list, List<DateTimePicker> dateList = null)
        {
            foreach (TextBox text in list)
            {
                PropertyInfo property = text.Tag as PropertyInfo;

                if (property.Name == "tienThanhToan")
                {
                    typeof(HoaDon).GetProperty(property.Name).SetValue(t, decimal.Parse(text.Text));
                    continue;
                }

                typeof(T).GetProperty(property.Name).SetValue(t, text.Text);
            }

            if (dateList != null)
            {
                foreach (DateTimePicker datePicker in dateList)
                {
                    PropertyInfo property = datePicker.Tag as PropertyInfo;
                    typeof(T).GetProperty(property.Name).SetValue(t, datePicker.Value);
                }
            }

            return t;
        }
    }
}
