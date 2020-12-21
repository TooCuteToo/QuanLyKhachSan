using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan
{
    public partial class UIQuanLy : UserControl
    {
        public static event EventHandler UserControlDragging;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public UIQuanLy(string status)
        {
            InitializeComponent();
            nameLB.Text = status.ToUpper();
        }

        private void nhanVienBtn_Click(object sender, EventArgs e)
        {
            sideBar_Animation(sender, e);
            uiNhanVien.BringToFront();
        }

        private void khachHangBtn_Click(object sender, EventArgs e)
        {
            sideBar_Animation(sender, e);
            uiKhachHang.BringToFront();
        }

        private void datPhongBtn_Click(object sender, EventArgs e)
        {
            uiDatPhong.BringToFront();
            sideBar_Animation(sender, e);
        }

        private void phongBtn_Click(object sender, EventArgs e)
        {
            sideBar_Animation(sender, e);
            uiPhong.BringToFront();
        }

        private void sideBar_Animation(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            sideBar.Height = btn.Height;
            sideBar.Top = btn.Top;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            UIQuanLy_MouseDown(sender, e);
        }

        private void UIQuanLy_MouseDown(object sender, MouseEventArgs e)
        {
            if (UserControlDragging != null)
            {
                UserControlDragging(null, EventArgs.Empty);
            }
        }

        private void thoatBtn_Click(object sender, EventArgs e)
        {
            WarningForm msg = new WarningForm();
            msg.Show();
        }


        private void social_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string targetURL = "";

            if (btn.Name == "fbBtn") targetURL = @"http://facebook.com";
            else if (btn.Name == "twitterBtn") targetURL = @"http://twitter.com";
            else if (btn.Name == "insBtn") targetURL = @"http://instagram.com";

            System.Diagnostics.Process.Start(targetURL);
        }


        public static void Alert(string msg, AlertForm.enmType type)
        {
            AlertForm frm = new AlertForm();
            frm.showAlert(msg, type);
        }
        
    }
}
