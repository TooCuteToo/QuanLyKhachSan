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
using Guna.UI2.WinForms;

namespace DoAn_QuanLyKhachSan.UI
{
    public partial class EditForm : Form
    {
        public static bool isError;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        List<Guna2TextBox> list;
        List<Guna2DateTimePicker> dateList;
        List<Guna2ComboBox> cbList;

        public EditForm()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            EditForm_MouseDown(sender, e);
        }

        private void EditForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void getList()
        {
            list = panel1.Controls.OfType<Guna2TextBox>().ToList();
            dateList = panel1.Controls.OfType<Guna2DateTimePicker>().ToList();
            cbList = panel1.Controls.OfType<Guna2ComboBox>().ToList();
        }

        public void showAdd<T>(T t)
        {
            initTextBox(t);
            Show();
            getList();
        }

        private void initTextBox<T>(T t)
        {
            if (t == null) return;

            int y = 0;
            var keys = t.GetType().GetProperties();

            foreach (PropertyInfo property in keys)
            {
                Label label = new Label()
                {
                    Location = new System.Drawing.Point(10, y += 50),
                    Text = property.Name.ToUpper(),
                };

                if (property.Name.Contains("ngay"))
                {
                    createDatePicker(property, label, y, DateTime.Now);
                    continue;
                }

                if (property.Name.Contains("gioiTinh"))
                {
                    createComboBox(property, label, y, 0);
                    continue;
                }

                if (!property.Name.EndsWith("s") && !property.ToString().Contains("DoAn"))
                {
                    createTextBox(property, label, y, "");
                }
            }

            editBtn.Tag = t;
        }

        private void createDatePicker(PropertyInfo property, Label label, int y, DateTime value)
        {
            Guna2DateTimePicker datePicker = new Guna2DateTimePicker()
            {
                Value = value,
                Location = new System.Drawing.Point(200, y),
                Tag = property,
                CustomFormat = "dd/MM/yyyy",
                Format = DateTimePickerFormat.Custom,
                FillColor = Color.LightBlue,
            };

            panel1.Controls.Add(label);
            panel1.Controls.Add(datePicker);
        }

        private void createComboBox(PropertyInfo property, Label label, int y, int selectedIndex)
        {
            Guna2ComboBox combo = new Guna2ComboBox()
            {
                Location = new System.Drawing.Point(200, y),
                Tag = property,
            };

            combo.Items.Add("Nam");
            combo.Items.Add("Nữ");
            combo.SelectedIndex = selectedIndex;

            panel1.Controls.Add(label);
            panel1.Controls.Add(combo);
        }

        private void createTextBox(PropertyInfo property, Label label, int y, string value)
        {

            Guna2TextBox textBox = new Guna2TextBox()
            {
                Text = value,
                Location = new System.Drawing.Point(200, y),
                Tag = property,
                //Size = new Size(200, 120),
                Enabled = property.Name.Contains("tien") || property.Name.Contains("ma") && value != "" ? false : true,
            };

            panel1.Controls.Add(label);
            panel1.Controls.Add(textBox);
        }

        public void showEdit<T>(T t)
        {
            initTextBoxValue(t);
            Show();
            getList();
        }

        private void initTextBoxValue<T>(T t)
        {
            int y = 0;

            if (t == null) return;

            var keys = t.GetType().GetProperties();

            foreach (PropertyInfo property in keys)
            {
                Label label = new Label()
                {
                    Location = new System.Drawing.Point(10, y += 50),
                    Text = property.Name.ToUpper(),
                };

                var value = property.GetValue(t);

                if (value != null && !value.ToString().Contains("System"))
                {
                    if (property.Name.Contains("ngay"))
                    {
                        createDatePicker(property, label, y, DateTime.Parse(value.ToString()));
                        continue;
                    }

                    if (property.Name.Contains("gioiTinh"))
                    {
                        int selectedIndex = value.ToString().Contains("Nam") ? 0 : 1;
                        createComboBox(property, label, y, selectedIndex);
                        continue;
                    }

                    if (!property.Name.EndsWith("s") && !property.ToString().Contains("DoAn"))
                    {
                        createTextBox(property, label, y, value.ToString());
                    }
                }
            }

            editBtn.Tag = t;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            DialogResult isEdit = MessageBox.Show("Bạn có chắc chắn là muốn thay đổi dòng hiện tại!!!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (isEdit == DialogResult.No) return;

            if (editBtn.Tag.GetType() == typeof(KhachHang))
            {
                KhachHang kh = new KhachHang();
                getData<KhachHang>(kh, list, dateList, cbList);
                new KhachHangDAO().updateData(kh);
            }

            else if (editBtn.Tag.GetType() == typeof(NhanVien))
            {
                NhanVien nv = new NhanVien();
                getData<NhanVien>(nv, list, dateList, cbList);
                new NhanVienDAO().updateData(nv);
            }

            else if (editBtn.Tag.GetType() == typeof(HoaDon))
            {
                HoaDon hd = new HoaDon();
                getData<HoaDon>(hd, list, dateList, cbList);
                new DatPhongDAO().updateData(hd);
            }

            else if (editBtn.Tag.GetType() == typeof(Phong))
            {
                Phong phong = new Phong();
                getData<Phong>(phong, list, dateList, cbList);
                new PhongDAO().updateData(phong);
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
            DialogResult isEdit = MessageBox.Show("Bạn có chắc chắn là muốn thay đổi dòng hiện tại!!!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (isEdit == DialogResult.No) return;

            if (editBtn.Tag.GetType() == typeof(KhachHang))
            {
                KhachHang kh = new KhachHang();
                getData<KhachHang>(kh, list, dateList, cbList);
                QuanLyDAO<KhachHang>.addData(kh);

                return;
            }

            if (editBtn.Tag.GetType() == typeof(NhanVien))
            {
                NhanVien nv = new NhanVien();
                getData<NhanVien>(nv, list, dateList, cbList);
                QuanLyDAO<NhanVien>.addData(nv);

                return;
            }

            if (editBtn.Tag.GetType() == typeof(HoaDon))
            {
                HoaDon hd = new HoaDon();
                getData<HoaDon>(hd, list, dateList, cbList);
                QuanLyDAO<HoaDon>.addData(hd);

                return;
            }

            if (editBtn.Tag.GetType() == typeof(Phong))
            {
                Phong phong = new Phong();
                getData<Phong>(phong, list, dateList, cbList);
                QuanLyDAO<Phong>.addData(phong);

                return;
            }
        }

        private object getData<T>(T t, List<Guna2TextBox> list, List<Guna2DateTimePicker> dateList, List<Guna2ComboBox> cbList)
        {
            foreach (Guna2TextBox text in list)
            {
                PropertyInfo property = text.Tag as PropertyInfo;

                //if (property.Name.Contains("tien"))
                //{
                //    typeof(HoaDon).GetProperty(property.Name).SetValue(t, decimal.Parse(text.Text));
                //    continue;
                //}

                if (text.Text == "") continue;
                if (property.Name.Contains("tien")) continue;

                typeof(T).GetProperty(property.Name).SetValue(t, text.Text);
            }

            if (dateList.Count > 0)
            {
                foreach (Guna2DateTimePicker datePicker in dateList)
                {
                    PropertyInfo property = datePicker.Tag as PropertyInfo;
                    typeof(T).GetProperty(property.Name).SetValue(t, datePicker.Value);
                }
            }

            if (cbList.Count > 0)
            {
                foreach (Guna2ComboBox combo in cbList)
                {
                    PropertyInfo property = combo.Tag as PropertyInfo;
                    typeof(T).GetProperty(property.Name).SetValue(t, combo.SelectedItem);
                }
            }

            return t;
        }

        private void thoatBtn_Click(object sender, EventArgs e)
        {
            DialogResult isEdit = MessageBox.Show("Bạn có chắn chắn về những thay đổi này không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (isEdit == DialogResult.Yes) this.Close();
        }

    }
}
