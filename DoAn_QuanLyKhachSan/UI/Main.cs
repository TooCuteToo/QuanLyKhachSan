using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public static string status;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();

            UIQuanLy.UserControlDragging += new EventHandler(UserControlDragging);
            UIDangNhap.UserControlDragging += new EventHandler(UserControlDragging);

            UIDangNhap.LoginExit += new EventHandler(LoginExit);
        }

        private void UserControlDragging(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void LoginExit(object sender, EventArgs e)
        {
            this.Controls.RemoveAt(0);
            initUIQuanLy();
        }

        private void initUIQuanLy()
        {
            UIQuanLy uiQuanLy = new UIQuanLy(this.Tag.ToString());
            this.Controls.Add(uiQuanLy);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void uiDangNhap1_Load(object sender, EventArgs e)
        {

        }
    }
}
