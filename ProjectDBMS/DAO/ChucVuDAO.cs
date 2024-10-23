using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDBMS.DAO
{
    internal class ChucVuDAO
    {
        public static DataTable LayTatCaChucVu()
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From ChucVu", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }

        //tong thu nhap theo tung chuc vu
        public static DataTable TongThuNhapTheoChucVu(DateTime ngay)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from fn_TongThuNhapTheoCongViec(@ngay)", connection);
                command.Parameters.AddWithValue("@ngay", ngay);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }
    }
}
