using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDBMS.DAO
{
    internal class PhongBanDAO
    {
        public static DataTable LayTatCaPhongBan()
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select MaPB, TenPB From PhongBan", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }

        //tong thu nhap cua phong ban
        public static DataTable TongThuNhapTheoPhongBan(DateTime ngay)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from fn_TongThuNhapTheoPhongBan(@ngay)", connection);
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
