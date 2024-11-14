using ProjectDBMS.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDBMS
{
    internal class ConnectDB
    {
        static string connectStringNhanvien = "Data Source=DESKTOP-8RK3BU5;Initial Catalog=QUAN_LY_LUONG;Persist Security Info=True;User ID=NhanVienLogin;Password=123;Encrypt=False;";
        static string connectStringQuanLy = "Data Source=DESKTOP-8RK3BU5;Initial Catalog=QUAN_LY_LUONG;Persist Security Info=True;User ID=QuanLyLogin;Password=123;Encrypt=False;";
        static public SqlConnection GetConnection()
        {
            if(fDangNhap.role == 0)
            {
                return new SqlConnection(connectStringQuanLy);
            }
            else if (fDangNhap.role == 1)
            {
                return new SqlConnection(connectStringNhanvien);
            }
            return null;
        }
    }
}
