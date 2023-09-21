using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBanHangWin.Class; //Sử dụng class Functions.cs

namespace QLBanHangWin
{
    public partial class frmMain : Form
    {
        private String user, pass; 
        public frmMain(String User, String Pass)
        {
            InitializeComponent();
            this.user = User;
            this.pass = Pass;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect(1); //Mở kết nối
            lbLogin.Text = "Tài khoản: " +  user;
        }
        
        private Form currentFormChild;

        private void OpenChildForm(Form ChildForm) {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(ChildForm);
            panel_Body.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanvien());
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHang());
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDonBan());
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimHDBan());
        }
        
    }
}
