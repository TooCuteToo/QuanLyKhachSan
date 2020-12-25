using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DoAn_QuanLyKhachSan.UI;

namespace DoAn_QuanLyKhachSan
{
    public partial class UIDangNhap : UserControl
    {
        public static event EventHandler UserControlDragging;
        public static event EventHandler LoginExit;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public UIDangNhap()
        {
            InitializeComponent();
        }

        private void UIDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            if (UserControlDragging != null)
            {
                UserControlDragging(null, EventArgs.Empty);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                string user = txtUser.Text;
                string pass = txtPass.Text;

                if (user == "" && pass == "")
                {
                    return;
                }

                NhanVien nv = db.NhanViens.FirstOrDefault(x => x.tenDN == user && x.pass == pass);

                if (nv != null)
                {
                    // Luu lai tai khoan da dang nhap khi tick Remember Me
                    if (ckRemember.Checked == true)
                    {
                        String filepath = "..//..//..//user//remember.txt";
                        FileStream fs = new FileStream(filepath, FileMode.Create);
                        StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                        sWriter.WriteLine(user);
                        sWriter.WriteLine(pass);
                        sWriter.Flush();
                        fs.Close();
                    }

                    this.ParentForm.Tag = nv;
                    this.Alert("XIN CHÀO " + nv.tenNV.ToUpper(), AlertForm.enmType.Success);
                    LoginExit(null, EventArgs.Empty);
                }
                else
                {
                    label1.Text = "Tài khoản hoặc mật khẩu bạn nhập không đúng";
                }
            }
        }

        private void Alert(string msg, AlertForm.enmType type)
        {
            AlertForm frm = new AlertForm();
            frm.showAlert(msg, type);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WarningForm msg = new WarningForm();
            msg.Show();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void UIDangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("..//..//..//user//remember.txt");
                txtUser.Text = lines[0];
                txtPass.Text = lines[1];
            }
            catch
            {
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ForgotPassForm fgPass = new ForgotPassForm();
            fgPass.Show();
        }
    }
}
