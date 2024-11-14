using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDBMS.DAO
{
    internal class AccountDAO
    {
        public static bool Login(string userName, string passWord)
        {
            string query = "SELECT role, MaNV FROM dbo.fn_DangNhap(@uname, @pass)";
            using (SqlConnection connection = ConnectDB.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@uname", userName);
                command.Parameters.AddWithValue("@pass", passWord);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int role = reader.GetInt32(0);
                        int? maNV = reader.IsDBNull(1) ? (int?)null : reader.GetInt32(1);
                        if (role == 0)
                        {
                            fDangNhap.role = 0;
                            fDangNhap.MaNV = -1;
                        }
                        else
                        {
                            fDangNhap.role = 1;
                            fDangNhap.MaNV = maNV.Value;
                        }
                        return true;
                    }
                }
                return false;
            }
            
        }
    }
}
