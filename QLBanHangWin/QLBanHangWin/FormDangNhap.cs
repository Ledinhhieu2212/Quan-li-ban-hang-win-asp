using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBanHangWin.Class;

namespace QLBanHangWin
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String sql = String.Format("SELECT TaiKhoan.IDTaiKhoan, TaiKhoan.MatKhau, TaiKhoan.PhanQuyen FROM TaiKhoan WHERE TaiKhoan.TenTaiKhoan = '{0}' AND TaiKhoan.MatKhau = '{1}' ", txtUserName.Text.Trim(), txtPassWord.Text.Trim());
            Class.Functions.Connect(0);
            if (Class.Functions.Login(sql))
            {
                frmMain FormMain = new frmMain(txtUserName.Text.Trim(), txtPassWord.Text.Trim());
                FormMain.ShowDialog();
                lberror.Visible = false;
            }
            else 
            {
                lberror.Visible = true;
            }
           
        }
        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPassWord.PasswordChar = (char)0;
            }
            else
            {
                txtPassWord.PasswordChar = '*';
            }
        }
    }
}
