﻿using System;
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

                SqlCommand command = new SqlCommand("ThemNhanVien", connection);
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

                SqlCommand command = new SqlCommand("CapNhatNhanVien", connection);

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

                SqlCommand command = new SqlCommand("XoaNhanVien", connection);

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
    }
}
