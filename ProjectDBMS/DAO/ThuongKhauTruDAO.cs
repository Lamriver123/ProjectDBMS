using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDBMS.DAO
{
    internal class ThuongKhauTruDAO
    {
        public static DataTable LayTatCaThuong()
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From V_XemThuong", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }

        public static DataTable LayTatCaThuongTangDan()
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From V_XemThuong Order by SoTien ASC", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }

        public static DataTable LayTatCaThuongGiamDan()
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From V_XemThuong Order by SoTien DESC", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }
        public static DataTable LayTatCaKhauTru()
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From V_XemKhauTru", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }
        public static DataTable LayTatCaKhauTruTangDan()
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From V_XemKhauTru Order by SoTien ASC", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }

        public static DataTable LayTatCaKhauTruGiamDan()
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From V_XemKhauTru Order by SoTien DESC", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }
        //insert thuongKhauTru
        public static bool ThemThuongKhauTru(Model.ThuongKhauTru thuongKhauTru)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("proc_ThemThuongVaKhauTru", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaNV", thuongKhauTru.MaNV);
                command.Parameters.AddWithValue("@SoTien", thuongKhauTru.SoTien);
                command.Parameters.AddWithValue("@ChuThich", thuongKhauTru.ChuThich);
                command.Parameters.AddWithValue("@PhanLoai", thuongKhauTru.PhanLoai);
                command.Parameters.AddWithValue("@NgayCapNhat", thuongKhauTru.NgayCapNhat);
                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }
        //update thuongKhauTru
        public static bool SuaThuongKhauTru(Model.ThuongKhauTru thuongKhauTru)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("proc_CapNhatThuongVaKhauTru", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaTKT", thuongKhauTru.MaTKT);
                command.Parameters.AddWithValue("@MaNV", thuongKhauTru.MaNV);
                command.Parameters.AddWithValue("@SoTien", thuongKhauTru.SoTien);
                command.Parameters.AddWithValue("@ChuThich", thuongKhauTru.ChuThich);
                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }
        //delete thuongKhauTru
        public static bool XoaThuongKhauTru(int maTKT, int maNV)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("proc_XoaThuongVaKhauTru", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaTKT", maTKT);
                command.Parameters.AddWithValue("@MaNV", maNV);
                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }

        //lay thuong theo pb
        public static DataTable LayThuongTheoPB(int maPB)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From fn_LocThuongTheoPhongBan(@MaPB)", connection);
                command.Parameters.AddWithValue("@MaPB", maPB);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }
        //lay thuong theo cv
        public static DataTable LayThuongTheoCV(int maCV)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From fn_LocThuongTheoChucVu(@MaCV)", connection);
                command.Parameters.AddWithValue("@MaCV", maCV);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }
        //lay thuong theo key
        public static DataTable LayThuongTheoKey(string key)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From fn_TimKiemThuong(@Key)", connection);
                command.Parameters.AddWithValue("@Key", key);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }
        //lay khau tru theo pb
        public static DataTable LayKhauTruTheoPB(int maPB)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From fn_LocKhauTruTheoPhongBan(@MaPB)", connection);
                command.Parameters.AddWithValue("@MaPB", maPB);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }

        //lay khau tru theo cv
        public static DataTable LayKhauTruTheoCV(int maCV)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From fn_LocKhauTruTheoChucVu(@MaCV)", connection);
                command.Parameters.AddWithValue("@MaCV", maCV);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }
        //lay khau tru theo key
        public static DataTable LayKhauTruTheoKey(string key)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From fn_TimKiemKhauTru(@Key)", connection);
                command.Parameters.AddWithValue("@Key", key);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }

        //Xem thuong khau tru theo maNV
        public static DataTable XemThuongKhauTruTheoMaNV(int maNV)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from fn_XemThuongVaKhauTru_NV(@MaNV)", connection);
                command.Parameters.AddWithValue("@MaNV", maNV);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }
    }
}
