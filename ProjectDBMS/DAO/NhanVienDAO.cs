using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDBMS.Model;

namespace ProjectDBMS.DAO
{
    internal class NhanVienDAO
    {
        public static void ThemNhanVien(NhanVien nhanVien)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())
            {

                SqlCommand command = new SqlCommand("proc_ThemNhanVien", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@HoTen", nhanVien.HoTen);
                command.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);

                command.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                command.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                command.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                command.Parameters.AddWithValue("@Email", nhanVien.Email);
                command.Parameters.AddWithValue("@MaPB", nhanVien.MaPB);

                command.Parameters.AddWithValue("@MaCV", nhanVien.MaCV);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void SuaNhanVien(NhanVien nhanVien)
        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                SqlCommand command = new SqlCommand("proc_CapNhatNhanVien", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaNV", nhanVien.MaNV);

                command.Parameters.AddWithValue("@HoTen", nhanVien.HoTen);

                command.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);

                command.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);

                command.Parameters.AddWithValue("@SDT", nhanVien.SDT);

                command.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);

                command.Parameters.AddWithValue("@Email", nhanVien.Email);

                command.Parameters.AddWithValue("@MaPB", nhanVien.MaPB);

                command.Parameters.AddWithValue("@MaCV", nhanVien.MaCV);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void XoaNhanVien(int maNV)

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                SqlCommand command = new SqlCommand("proc_XoaNhanVien", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaNV", maNV);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

            }
        }

        public static DataTable LayTatCaNhanVien()

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                connection.Open();

                SqlCommand command = new SqlCommand("Select * From V_DanhSachNhanVien", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();

                return dt;

            }
        }

        public static DataTable LayTatCaNhanVienLuongTangDan()

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                connection.Open();

                SqlCommand command = new SqlCommand("proc_DanhSachNVLuongTangDan", connection);

                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();

                return dt;

            }
        }

        public static DataTable LayTatCaNhanVienLuongGiamDan()

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                connection.Open();

                SqlCommand command = new SqlCommand("proc_DanhSachNVLuongGiamDan", connection);

                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();

                return dt;

            }
        }

        //Lay thong tin nhan vien theo ma nhan vien
        public static NhanVien LayNhanVienTheoMaNV(int maNV)

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                connection.Open();

                SqlCommand command = new SqlCommand("Select * From NhanVien Where MaNV = @MaNV", connection);

                command.Parameters.AddWithValue("@MaNV", maNV);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();

                NhanVien nhanVien = new NhanVien(dt.Rows[0]);

                return nhanVien;

            }
        }
        //lay danh sach nhan vien theo ma phong ban
        public static DataTable LayNhanVienTheoMaPB(int maPB)

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                connection.Open();

                SqlCommand command = new SqlCommand("Select * From fn_LocNhanVienTheoPhongBan(@MaPB)", connection);

                command.Parameters.AddWithValue("@MaPB", maPB);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();

                return dt;

            }
        }
        //lay danh sach nhan vien theo ma chuc vu
        public static DataTable LayNhanVienTheoMaCV(int maCV)

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                connection.Open();

                SqlCommand command = new SqlCommand("Select * From fn_LocNhanVienTheoChucVu(@MaCV)", connection);

                command.Parameters.AddWithValue("@MaCV", maCV);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();

                return dt;

            }
        }
        //lay danh sach nhan vien theo keyword
        public static DataTable LayNhanVienTheoKeyword(string keyword)

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                connection.Open();

                SqlCommand command = new SqlCommand("Select * From fn_TimKiemNhanVien(@SearchText)", connection);

                command.Parameters.AddWithValue("@SearchText", keyword);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();

                return dt;

            }
        }
        //lay thong tin nhan vien theo manv
        public static DataRow LayThongTinNhanVienTheoMaNV(int maNV)

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                connection.Open();

                SqlCommand command = new SqlCommand("proc_XemThongTinCaNhan", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaNV", maNV);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();

                return dt.Rows[0];

            }
        }
        //chi tiet luong nhan vien theo ma nhan vien
        public static DataRow LayChiTietLuongNhanVienTheoMaNV(int maNV, DateTime ngay)

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                connection.Open();

                SqlCommand command = new SqlCommand("proc_ChiTietLuongNhanVien", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaNV", maNV);

                command.Parameters.AddWithValue("@ngay", ngay);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();

                return dt.Rows[0];

            }
        }

        //Danh sach top nhan vien lam nhieu gio nhat
        public static DataTable DanhSachTopNhanVienLamNhieuGioNhat(DateTime ngay)

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                connection.Open();

                SqlCommand command = new SqlCommand("proc_NhanVienCoGioLamNhieuNhat", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ngay", ngay);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();

                return dt;

            }
        }

        public static DataTable DanhSachTopNhanVienTienBo(DateTime ngay)

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                connection.Open();

                SqlCommand command = new SqlCommand("proc_LietKeNhanVienTienBo", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@NgayHienTai", ngay);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();

                return dt;

            }
        }
        public static DataTable LayLuongNhanVienTheoNam(int maNV, int nam, int thang)

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                connection.Open();

                SqlCommand command = new SqlCommand("select * from fn_LuongThucNhanTheoNam(@MaNV, @Nam, @Thang)", connection);


                command.Parameters.AddWithValue("@MaNV", maNV);

                command.Parameters.AddWithValue("@Nam", nam);

                command.Parameters.AddWithValue("@Thang", thang);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();

                return dt;

            }
        }
        
        public static DataTable LayTKTNhanVienTheoNam(int maNV, int nam, string loai)

        {
            using (SqlConnection connection = ConnectDB.GetConnection())

            {

                connection.Open();

                SqlCommand command = new SqlCommand("select * from fn_TKThuongKhauTruTheoNam_NV(@MaNV, @Nam, @Loai)", connection);
                command.Parameters.AddWithValue("@MaNV", maNV);

                command.Parameters.AddWithValue("@Nam", nam);

                command.Parameters.AddWithValue("@Loai", loai);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();

                return dt;
            }
        }
    }
}
