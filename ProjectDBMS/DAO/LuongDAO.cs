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

    }
}
