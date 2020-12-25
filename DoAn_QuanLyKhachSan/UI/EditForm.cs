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
using System.Text.RegularExpressions;
using System.Globalization;

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

        private List<string> listGioiTinh;
        private List<string> listQueQuan;

        private List<string> listPhongTrong;
        private List<string> listMaCV;

        private List<string> listMaNV;
        private List<string> listMaPhong;

        private List<string> listPhong;
        private List<string> listMaHD;

        public EditForm()
        {
            InitializeComponent();
            getListCBValue();
        }

        private void getListCBValue()
        {
            listPhongTrong = QuanLyDAO<Phong>.getData().Where(item => item.tinhTrang.Contains("Trống")).Select(item => item.soPhong).ToList();

            listQueQuan = QuanLyDAO<NhanVien>.getData().Select(item => item.diaChi).ToList();
            listQueQuan.AddRange(QuanLyDAO<KhachHang>.getData().Select(item => item.diaChi).ToList());

            listQueQuan = listQueQuan.Distinct().ToList();

            listGioiTinh = QuanLyDAO<NhanVien>.getData().Select(item => item.gioiTinh).Distinct().ToList();
            listMaCV = QuanLyDAO<ChucVu>.getData().Select(item => item.maCV).ToList();

            listMaNV = QuanLyDAO<NhanVien>.getData().Select(item => item.maNV).ToList();
            listMaPhong = QuanLyDAO<Phong>.getData().OrderBy(item => item.maLoai).Select(item => item.maLoai).Distinct().ToList();

            listPhong = QuanLyDAO<Phong>.getData().Select(item => item.soPhong).ToList();
            listMaHD = QuanLyDAO<HoaDon>.getData().Select(item => item.maHD).ToList();
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

        public void getControlList()
        {
            list = formGroupBox.Controls.OfType<Guna2TextBox>().ToList();
            dateList = formGroupBox.Controls.OfType<Guna2DateTimePicker>().ToList();
            cbList = formGroupBox.Controls.OfType<Guna2ComboBox>().ToList();
        }

        public void showAdd<T>(T t)
        {
            editBtn.Enabled = false;
            initTextBox(t);

            getControlList();
            Show();
        }

        private void initTextBox<T>(T t)
        {
            if (t == null) return;

            int i = 0;
            int y = 0;

            var keys = t.GetType().GetProperties();

            foreach (PropertyInfo property in keys)
            {

                int x = i % 2 == 0 ? 193 + 150 + 20 + 20 : 20;
                y += i % 2 != 0 ? 0 : 60;

                i++;

                Label label = new Label()
                {
                    Location = new System.Drawing.Point(x, y),
                    Text = property.Name.ToUpper(),
                    ForeColor = Color.Black,
                    BackColor = Color.Transparent,
                };


                bool comboxCondition = (
                    property.Name.Contains("gioiTinh") || property.Name.Contains("diaChi") ||
                    property.Name.Contains("maCV") || property.Name.Contains("maLoai")
                );

                bool textBoxCondition = (
                    property.Name.Contains("pass") ||
                    !property.Name.EndsWith("s") && !property.ToString().Contains("DoAn")
                );

                if (property.Name.Contains("tienThanhToan")) 
                {
                    continue;
                }

                if (property.Name.Contains("ngay"))
                {
                    createDatePicker(property, label, x, y, DateTime.Now);
                    continue;
                }

                if (comboxCondition)
                {
                    createComboBox(property, label, x, y, 0);
                    continue;
                }

                if (textBoxCondition)
                {
                    createTextBox(property, label, x, y, "");
                }
            }

            editBtn.Tag = t;
        }



        private void createDatePicker(PropertyInfo property, Label label, int x, int y, DateTime value)
        {
            Guna2DateTimePicker datePicker = new Guna2DateTimePicker()
            {
                Value = value,
                Location = new System.Drawing.Point(x += 120, y),
                Tag = property,
                CustomFormat = "dd/MM/yyyy",
                Format = DateTimePickerFormat.Custom,
                FillColor = Color.LightBlue,
                ForeColor = Color.Black,
            };

            formGroupBox.Controls.Add(label);
            formGroupBox.Controls.Add(datePicker);
        }

        private void createComboBox(PropertyInfo property, Label label, int x, int y, int selectedIndex)
        {
            Guna2ComboBox combo = new Guna2ComboBox()
            {
                Location = new System.Drawing.Point(x += 120, y),
                Tag = property,
            };

            if (property.Name.Contains("gioiTinh"))
            {
                combo.Items.AddRange(listGioiTinh.ToArray());
            }

            else if (property.Name.Contains("diaChi"))
            {
                combo.Items.AddRange(listQueQuan.ToArray());
            }

            else if (property.Name.Contains("soPhong"))
            {
                if (y == 60)
                {
                    combo.Items.AddRange(listPhong.ToArray());

                    combo.SelectedIndexChanged += new EventHandler(setPhongEdit);
                }
                else
                {
                    combo.Items.AddRange(listPhongTrong.ToArray());
                }
            }

            else if (property.Name.Contains("maNV"))
            {
                combo.Items.AddRange(listMaNV.ToArray());

                combo.SelectedIndexChanged += new EventHandler(setNhanVienEdit);
            }

            else if (property.Name.Contains("maCV"))
            {
                combo.Items.AddRange(listMaCV.ToArray());
            }

            else if (property.Name.Contains("maLoai"))
            {
                combo.Items.AddRange(listMaPhong.ToArray());
            }

            else if (property.Name.Contains("maHD"))
            {
                combo.Items.AddRange(listMaHD.ToArray());

                combo.SelectedIndexChanged += new EventHandler(setDatPhongEdit);
            }

            combo.SelectedIndex = selectedIndex;

            formGroupBox.Controls.Add(label);
            formGroupBox.Controls.Add(combo);
        }

        private void setNhanVienEdit(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            PropertyInfo property = cb.Tag as PropertyInfo;
            var result = QuanLyDAO<NhanVien>.getData(new NhanVien(), property.Name, cb.SelectedItem.ToString());

            getControlList();

            foreach (Guna2TextBox txt in list)
            {
                PropertyInfo txtProperty = txt.Tag as PropertyInfo;

                if (txtProperty.Name.Contains("tenNV"))
                {
                    txt.Text = result.tenNV;
                }

                else if (txtProperty.Name.Contains("SDT"))
                {
                    txt.Text = result.SDT;
                }

                else if (txtProperty.Name.Contains("tenDN"))
                {
                    txt.Text = result.tenDN;
                }

                else if (txtProperty.Name.Contains("pass"))
                {
                    txt.Text = result.pass;
                }
            }

            foreach (Guna2ComboBox gunaCB in cbList)
            {
                PropertyInfo cbProperty = gunaCB.Tag as PropertyInfo;

                if (cbProperty.Name.Contains("gioiTinh"))
                {
                    gunaCB.SelectedIndex = listGioiTinh.IndexOf(result.gioiTinh);
                }

                else if (cbProperty.Name.Contains("maCV"))
                {
                    gunaCB.SelectedIndex = listMaCV.IndexOf(result.maCV);
                }

                else if (cbProperty.Name.Contains("diaChi"))
                {
                    gunaCB.SelectedIndex = listQueQuan.IndexOf(result.diaChi);
                }
            }

            foreach (Guna2DateTimePicker datePicker in dateList)
            {
                PropertyInfo dateProperty = datePicker.Tag as PropertyInfo;

                if (dateProperty.Name.Contains("ngaySinh"))
                {
                    datePicker.Value = result.ngaySinh.Value;
                }

                else if (dateProperty.Name.Contains("ngayVaoLam"))
                {
                    datePicker.Value = result.ngayVaoLam.Value;
                }
            }
        }

        private void setDatPhongEdit(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            PropertyInfo property = cb.Tag as PropertyInfo;
            var result = QuanLyDAO<HoaDon>.getData(new HoaDon(), property.Name, cb.SelectedItem.ToString());

            getControlList();

            foreach (Guna2TextBox txt in list)
            {
                PropertyInfo txtProperty = txt.Tag as PropertyInfo;

                if (txtProperty.Name.Contains("CMND"))
                {
                    txt.Text = result.CMND;
                }

                else if (txtProperty.Name.Contains("tienThanhToan"))
                {
                    CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                    txt.Text = result.tienThanhToan.Value.ToString("#,###", cul.NumberFormat);
                }
            }

            foreach (Guna2ComboBox gunaCB in cbList)
            {
                PropertyInfo cbProperty = gunaCB.Tag as PropertyInfo;

                if (cbProperty.Name.Contains("maHD"))
                {
                    gunaCB.SelectedIndex = listMaHD.IndexOf(result.maHD);
                }

                else if (cbProperty.Name.Contains("maNV"))
                {
                    gunaCB.SelectedIndex = listMaNV.IndexOf(result.maNV);
                }

                else if (cbProperty.Name.Contains("soPhong"))
                {
                    gunaCB.Items.RemoveAt(gunaCB.Items.Count - 1);
                    gunaCB.Items.Add(result.soPhong);
                    gunaCB.SelectedIndex = gunaCB.Items.Count - 1;
                }
            }

            foreach (Guna2DateTimePicker datePicker in dateList)
            {
                PropertyInfo dateProperty = datePicker.Tag as PropertyInfo;

                if (dateProperty.Name.Contains("ngayDat"))
                {
                    datePicker.Value = result.ngayDat.Value;
                }

                else if (dateProperty.Name.Contains("ngayTra"))
                {
                    datePicker.Value = result.ngayTra.Value;
                }
            }
        }

        private void setPhongEdit(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            PropertyInfo property = cb.Tag as PropertyInfo;
            var result = QuanLyDAO<Phong>.getData(new Phong(), property.Name, cb.SelectedItem.ToString());

            getControlList();

            foreach (Guna2TextBox txt in list)
            {
                txt.Text = result.tinhTrang.ToString();
            }

            foreach (Guna2ComboBox gunaCB in cbList)
            {
                PropertyInfo cbProperty = gunaCB.Tag as PropertyInfo;

                if (cbProperty.Name.Contains("soPhong"))
                {
                    gunaCB.SelectedIndex = listPhong.IndexOf(result.soPhong);
                }

                else if (cbProperty.Name.Contains("maLoai"))
                {
                    gunaCB.SelectedIndex = listMaPhong.IndexOf(result.maLoai);
                }
            }
        }

        private void createTextBox(PropertyInfo property, Label label, int x, int y, string value)
        {
            bool enabledCondition = (
                (property.Name.Contains("tien") || property.Name.Contains("ma") &&
                !property.Name.Contains("maCV") || 
                property.Name.Contains("tenDN") || property.Name.Contains("pass")) &&
                addBtn.Enabled
            );

            Guna2TextBox textBox = new Guna2TextBox()
            {
                Text = value,
                Location = new System.Drawing.Point(x + 120, y),
                Tag = property,
                //Size = new Size(200, 120),
                Enabled = enabledCondition ? false : true,
            };

            if (property.Name.Contains("maNV"))
            {
                int count = QuanLyDAO<NhanVien>.countDataRow(new NhanVien()) + 1;
                string str = count.ToString().PadLeft(3, '0');
                textBox.Text = property.Name.Substring(2) + str;
            }

            else if (property.Name.Contains("tenDN"))
            {
                if (editBtn.Enabled)
                {
                    textBox.Text = value;
                }
                else
                {
                    int count = QuanLyDAO<NhanVien>.countDataRow(new NhanVien()) + 1;
                    string str = count.ToString().PadLeft(2, '0');
                    textBox.Text = "NV" + str;
                }
            } 

            else if (property.Name.Contains("tienThanhToan")) 
            {
                if (editBtn.Enabled)
                {
                    CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                    textBox.Text = decimal.Parse(value).ToString("#,###", cul.NumberFormat);
                    textBox.Enabled = false;
                }
            }

            else if (property.Name.Contains("tinhTrang"))
            {
                if (editBtn.Enabled)
                {
                    textBox.Text = value;
                    textBox.Enabled = false;
                }
                else
                {
                    textBox.Text = "Trống";
                    textBox.Enabled = false;
                }
            }

            else if (property.Name.Contains("pass"))
            {
                textBox.Text = "123";
            }

            else if (property.Name.Contains("maHD"))
            {
                int count = QuanLyDAO<HoaDon>.countDataRow(new HoaDon()) + 1;
                string str = count.ToString().PadLeft(2, '0');
                textBox.Text = property.Name.Substring(2) + str;
            }

            else if (property.Name.Contains("CMND") || property.Name.Contains("SDT"))
            {
                textBox.TextChanged += new EventHandler(checkTextBox);
            }

            formGroupBox.Controls.Add(label);
            formGroupBox.Controls.Add(textBox);
        }

        private void checkTextBox(object sender, EventArgs e)
        {
            Guna2TextBox txt = sender as Guna2TextBox;
            PropertyInfo property = txt.Tag as PropertyInfo;

            if (property.Name.Contains("CMND"))
            {
                if (!Regex.IsMatch(txt.Text, @"[0-9]{12}") || txt.Text.Length > 12)
                {
                    errorProvider.SetError(txt, "CMND không hợp lệ!!!");
                }
                else
                {
                    errorProvider.SetError(txt, null);
                }
            }

            else if (property.Name.Contains("SDT"))
            {
                if (!Regex.IsMatch(txt.Text, @"0\d{9,10}") || txt.Text.Length > 11)
                {
                    errorProvider.SetError(txt, "Số điện thoại không hợp lệ!!!");
                }
                else
                {
                    errorProvider.SetError(txt, null);
                }
            }
        }

        public void showEdit<T>(T t)
        {
            addBtn.Enabled = false;
            initTextBoxValue(t);

            Show();
            getControlList();
        }

        private void initTextBoxValue<T>(T t)
        {
            if (t == null) return;

            int y = 0;
            int i = 0;

            var keys = t.GetType().GetProperties();

            foreach (PropertyInfo property in keys)
            {
                int x = i % 2 == 0 ? 193 + 150 + 20 + 20 : 20;
                y += i % 2 != 0 ? 0 : 60;

                i++;

                Label label = new Label()
                {
                    Location = new System.Drawing.Point(x, y),
                    Text = property.Name.ToUpper(),
                    ForeColor = Color.Black,
                    BackColor = Color.Transparent,
                };

                bool comboBoxCondition = (
                    property.Name.Contains("gioiTinh") || property.Name.Contains("diaChi") ||
                    property.Name.Contains("soPhong") || property.Name.Contains("maCV") ||
                    (property.Name.Contains("maNV") && editBtn.Enabled) || property.Name.Contains("maLoai") ||
                    property.Name.Contains("maHD") 
                );

                bool textBoxCondition = (
                    property.Name.Contains("pass") ||
                    !property.Name.EndsWith("s") && !property.ToString().Contains("DoAn")
                );

                var value = property.GetValue(t);

                if (value != null && !value.ToString().Contains("System"))
                {
                    if (property.Name.Contains("ngay"))
                    {
                        createDatePicker(property, label, x, y, DateTime.Parse(value.ToString()));
                        continue;
                    }

                    if (comboBoxCondition)
                    {
                        int selectedIndex = 0;

                        if (listGioiTinh.Contains(value.ToString()))
                        {
                            selectedIndex = listGioiTinh.IndexOf(value.ToString());
                        }

                        else if (listQueQuan.Contains(value.ToString()))
                        {
                            selectedIndex = listQueQuan.IndexOf(value.ToString());
                        }

                        else if (listMaNV.Contains(value.ToString()))
                        {
                            selectedIndex = listMaNV.IndexOf(value.ToString());
                        }

                        else if (listMaCV.Contains(value.ToString()))
                        {
                            selectedIndex = listMaCV.IndexOf(value.ToString());
                        }

                        else if (listMaPhong.Contains(value.ToString()))
                        {
                            selectedIndex = listMaPhong.IndexOf(value.ToString());
                        }

                        else if (listMaHD.Contains(value.ToString()))
                        {
                            selectedIndex = listMaHD.IndexOf(value.ToString());
                        }

                        else if (listPhong.Contains(value.ToString()) && keys.Count() == 5)
                        {
                            selectedIndex = listPhong.IndexOf(value.ToString());
                        }

                        else
                        {
                            listPhongTrong.Add(value.ToString());
                            selectedIndex = listPhongTrong.IndexOf(value.ToString());
                        }

                        createComboBox(property, label, x, y, selectedIndex);

                        continue;
                    }

                    if (textBoxCondition)
                    {
                        createTextBox(property, label, x, y, value.ToString());
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
            DialogResult isEdit = MessageBox.Show("Bạn có muốn thêm dòng dữ liệu này ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
