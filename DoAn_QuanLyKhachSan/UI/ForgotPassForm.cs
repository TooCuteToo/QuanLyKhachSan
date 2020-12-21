using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan.UI
{
    public partial class ForgotPassForm : Form
    {
        public ForgotPassForm()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                string user = txtUser.Text;
                string sdt = txtSDT.Text;

                if (user == "" && sdt == "")
                {
                    return;
                }

                NhanVien nv = db.NhanViens.FirstOrDefault(x => x.tenDN == user && x.SDT == sdt);

                if (nv != null)
                {
                    txtPass.Text = nv.pass;
                    label5.Text = "";
                }
                else
                {
                    label5.Text = "User hoặc SĐT bạn nhập ko đúng";
                    txtPass.Text = "";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
