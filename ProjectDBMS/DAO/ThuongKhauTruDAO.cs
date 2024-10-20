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
    }
}
