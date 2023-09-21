using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLBanHangWin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDangNhap());
            // Tài khoản đăng nhập là 
            //Tên tài khoản: user
            //Mật khẩu: 654321;
        }
    }
}
