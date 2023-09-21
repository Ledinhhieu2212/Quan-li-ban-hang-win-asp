using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;
using dataTable = System.Data.DataTable;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QLBanHangWin.Class
{
    internal class Functions
    {
        static String DuongDan = @"D:\BaiTapLonNhom2N01\";
        public static OleDbConnection Con;     
        public static void Connect(int n)
        {
            Con = new OleDbConnection();
            Con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ DuongDan +"QLBanHang.accdb";
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
                if (n != 0) {
                    MessageBox.Show("Kết nối thành công");
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối với dữ liệu");
            }
        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   
                Con.Dispose(); 
                Con = null;
            }
        }

        public static dataTable GetDataToTable(string sql)
        {
            OleDbDataAdapter dap = new OleDbDataAdapter(sql, Con);
            dataTable table = new dataTable();
            dap.Fill(table); 
            return table;
        }
        public static bool Login (String sql)
        {
            Boolean result = false;
            OleDbCommand cmd = new OleDbCommand(sql, Con);
            OleDbDataReader dt = cmd.ExecuteReader();
            if (dt.Read())
            {
                result = true;
            }
            dt.Close();
            return result;
        }

        public static bool CheckKey(string sql)
        {
            OleDbDataAdapter dap = new OleDbDataAdapter(sql, Con);
            dataTable table = new dataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        //Hàm thực hiện câu lệnh SQL
        public static void RunSQL(string sql)
        {
            OleDbCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new OleDbCommand();
            cmd.Connection = Con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }

        public static void RunSqlDel(string sql)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = Functions.Con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        public static bool IsDate(string date)
        {
            string[] elements = date.Split('/');
            if ((Convert.ToInt32(elements[0]) >= 1) && (Convert.ToInt32(elements[0]) <= 31) && (Convert.ToInt32(elements[1]) >= 1) && (Convert.ToInt32(elements[1]) <= 12) && (Convert.ToInt32(elements[2]) >= 1900))
                 return true;
            else return false;
        }

        
        public static string ConvertDateTime(string date)
        {   // cắt chuỗi có khoảng cách là /
            string[] elements = date.Split('/');
            //
            string dt = string.Format("{0}/{1}/{2} 00:00:00 AM", elements[0], elements[1], elements[2]);
            return dt;
        }
        public static string ConvertDateTime2(string date)
        {   // cắt chuỗi có khoảng cách là /
            string[] elements = date.Split('/');
            //
            if (Int32.Parse(elements[0]) >= 1 && Int32.Parse(elements[0]) <= 9)
            {
                elements[0] = Int32.Parse(elements[0]).ToString("00");
            }
            if (Int32.Parse(elements[1]) >= 1 && Int32.Parse(elements[1]) <= 9)
            {
                elements[1] = Int32.Parse(elements[1]).ToString("00");
            }
            string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
            return dt;
        }

        // Xuất file dữ liệu có trong bảng
        public static void ExportExcel(DataGridView g, String TenFile)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            obj.ActiveWorkbook.SaveCopyAs(DuongDan + TenFile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
            MessageBox.Show("Đã xuất file thành công", "Thông báo");
        }
    }
}
