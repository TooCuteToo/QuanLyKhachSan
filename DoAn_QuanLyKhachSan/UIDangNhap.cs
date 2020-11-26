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
    public partial class UIDangNhap : UserControl
    {
        public static event EventHandler UserControlDragging;

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
            this.Hide();
        }
    }
}
