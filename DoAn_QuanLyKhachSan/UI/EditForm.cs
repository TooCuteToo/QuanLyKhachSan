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

        public void showEdit<T>(T t)
        {
            showInfo(t);
            Show();
        }

        public void showInfo<T>(T t)
        {
            int x = 0;
            int y = 0;

            if (t == null) return;

            var keys = t.GetType().GetProperties();

            foreach (PropertyInfo property in keys)
            {
                var value = property.GetValue(t);

                if (value != null && !value.ToString().Contains("System"))
                {
                    TextBox textBox = new TextBox()
                    {
                        Text = value.ToString(),
                        Location = new System.Drawing.Point(200, y += 50),
                        Tag = property,
                    };

                    panel1.Controls.Add(textBox);
                }
            }

            editBtn.Tag = t;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            List<TextBox> list = panel1.Controls.OfType<TextBox>().ToList();

            if (editBtn.Tag.GetType() == typeof(KhachHang))
            {
                KhachHang kh = new KhachHang();

                foreach (TextBox text in list)
                {
                    PropertyInfo property = text.Tag as PropertyInfo;
                    typeof(KhachHang).GetProperty(property.Name).SetValue(kh, text.Text);
                }

                new KhachHangDAO().updateData(kh);
            }
            
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            editBtn.Tag = 0;
        }
    }
}
