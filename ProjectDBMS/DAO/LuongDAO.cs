using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDBMS.DAO
{
    internal class LuongDAO
    {
        //lay tat ca luong thuc nhan theo ngay 
        public static DataTable LayLuongThucNhanTheoNgay(DateTime ngay)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM fn_DanhSachLuongNhanVien(@ngay)", connection);
                command.Parameters.AddWithValue("@ngay", ngay);
                connection.Open();
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                connection.Close();
                return dt;
            }
        }

        public static DataTable LayLuongThucNhanTangDan(DateTime ngay)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                SqlCommand command = new SqlCommand("proc_DanhSachLuongNVTangDan", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ngay", ngay);
                connection.Open();
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                connection.Close();
                return dt;
            }
        }

        public static DataTable LayLuongThucNhanGiamDan(DateTime ngay)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                SqlCommand command = new SqlCommand("proc_DanhSachLuongNVGiamDan", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ngay", ngay);
                connection.Open();
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                connection.Close();
                return dt;
            }
        }

        public static DataTable LayLuongThucNhanTheoPhongBan(int maPB, DateTime ngay)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM fn_LocLuongNVTheoPhongBan(@MaPB, @ngay)", connection);
                command.Parameters.AddWithValue("@MaPB", maPB);
                command.Parameters.AddWithValue("@ngay", ngay);
                connection.Open();
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                connection.Close();
                return dt;
            }
        }

        public static DataTable LayLuongThucNhanTheoChucVu(int maCV, DateTime ngay)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM fn_LocLuongNVTheoChucVu(@MaCV, @ngay)", connection);
                command.Parameters.AddWithValue("@MaCV", maCV);
                command.Parameters.AddWithValue("@ngay", ngay);
                connection.Open();
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                connection.Close();
                return dt;
            }
        }

        //tim kiem luong theo key
        public static DataTable TimKiemLuongTheoKey(string key, DateTime ngay)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM fn_TimKiemLuongNV(@key, @ngay)", connection);
                command.Parameters.AddWithValue("@key", key);
                command.Parameters.AddWithValue("@ngay", ngay);
                connection.Open();
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                connection.Close();
                return dt;
            }
        }
    }
}
