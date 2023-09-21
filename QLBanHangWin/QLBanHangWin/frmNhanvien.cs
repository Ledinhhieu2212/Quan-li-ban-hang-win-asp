
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using dataTable = System.Data.DataTable;
using System.Windows.Forms;
using System.Data.OleDb;//Sử dụng thư viện để làm việc
using QLBanHangWin.Class; //Sử dụng class Functions.cs
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace QLBanHangWin
{   
    public partial class frmNhanvien : Form
    {
        dataTable tblNV; //Chứa dữ liệu bảng Chất liệu
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmDMNhanvien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            chkGioiTinh.Checked = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT NhanVien.MaNV, NhanVien.TenNV, Format([NgaySinh],'dd/mm/yyyy') AS N_S, IIf([GioiTinh],'Nam','Nữ') AS Gioi_Tinh, NhanVien.SoDT, NhanVien.DiaChi FROM NhanVien ORDER BY NhanVien.MaNV ";
            tblNV = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            BangNhanVien.DataSource = tblNV; //Nguồn dữ liệu           
            BangNhanVien.Columns[0].Width = 100;
            BangNhanVien.Columns[1].Width = 200;
            BangNhanVien.Columns[2].Width = 100;
            BangNhanVien.Columns[3].Width = 100;
            BangNhanVien.Columns[4].Width = 100;
            BangNhanVien.Columns[5].Width = 100;
            BangNhanVien.AllowUserToAddRows = false;
            BangNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void BangNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNhanVien.Text = BangNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTenNhanVien.Text = BangNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            if (BangNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                chkGioiTinh.Checked = true;
                chkGioiTinh.Text = "Nam";
            }
            else { 
                chkGioiTinh.Checked = false;
                chkGioiTinh.Text = "Nữ";
            }
            txtDiaChi.Text = BangNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = BangNhanVien.CurrentRow.Cells["SoDT"].Value.ToString();
            mskNgaySinh.Text = Functions.ConvertDateTime2(BangNhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tự động đặt mã
            String MaxMaNV = BangNhanVien.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToString(r.Cells["MaNV"].Value));
            String MaNV_Next;
            if (tblNV.Rows.Count == 0)
            {
                MaNV_Next = "001";
            }else{
                MaNV_Next = (Int32.Parse(MaxMaNV.Substring(2, 3)) + 1).ToString("000");
            }
            txtMaNhanVien.Text = "NV" + MaNV_Next;
            String sql;
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }
            if (mskNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaySinh.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaySinh.Focus();
                return;
            }
            sql = String.Format("INSERT INTO NhanVien VALUES ('{0}', '{1}', #{2}#, {3} ,'{4}', '{5}','{6}')", txtMaNhanVien.Text.Trim(), txtTenNhanVien.Text.Trim(), Class.Functions.ConvertDateTime(mskNgaySinh.Text.Trim()), chkGioiTinh.Checked, txtDienThoai.Text.Trim(), txtDiaChi.Text.Trim(), "#NV_admin");
            String ngay_sinh = Functions.ConvertDateTime(mskNgaySinh.Text);
            MessageBox.Show("Thông báo","Đã thêm thành công");
            Functions.RunSQL(sql);
            LoadDataGridView();
        }
        void ResetValues()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            chkGioiTinh.Checked = false;
            txtDiaChi.Text = "";
            mskNgaySinh.Text = "";
            txtDienThoai.Text = "";
        }
        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void chkGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGioiTinh.Checked)
            {
                chkGioiTinh.Text = "Nam";
            }
            else
            {
                chkGioiTinh.Text = "Nữ";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }
            if (mskNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaySinh.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaySinh.Text = "";
                mskNgaySinh.Focus();
                return;
            }
            sql = "UPDATE NhanVien SET  TenNV='" + txtTenNhanVien.Text.Trim().ToString() +
                    "',DiaChi='" + txtDiaChi.Text.Trim().ToString() +
                    "',NgaySinh='" + Functions.ConvertDateTime(mskNgaySinh.Text) +
                    "',GioiTinh=" + chkGioiTinh.Checked +
                    ",SoDT='" + txtDienThoai.Text.Trim().ToString() + 
                    "' WHERE MaNV='" + txtMaNhanVien.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE FROM NhanVien WHERE MaNV='" + txtMaNhanVien.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnXuat_Click(object sender, EventArgs e)
        {
            Class.Functions.ExportExcel(BangNhanVien, "FileXuat");
        }

    }
}
