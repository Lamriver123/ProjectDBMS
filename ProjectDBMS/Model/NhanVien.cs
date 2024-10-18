using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDBMS.Model
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int MaPB { get; set; }
        public int MaCV { get; set; }

        public NhanVien(int maNV, string hoTen, string gioiTinh, DateTime ngaySinh, string sdt, string diaChi, string email, int maPB, int maCV)
        {
            MaNV = maNV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            SDT = sdt;
            DiaChi = diaChi;
            Email = email;
            MaPB = maPB;
            MaCV = maCV;
        }

        public NhanVien(DataRow dr)
        {
            MaNV = Convert.ToInt32(dr["MaNV"]);
            HoTen = dr["HoTen"].ToString();
            GioiTinh = dr["GioiTinh"].ToString();
            NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
            SDT = dr["SDT"].ToString();
            DiaChi = dr["DiaChi"].ToString();
            Email = dr["Email"].ToString();
            MaPB = Convert.ToInt32(dr["MaPB"]);
            MaCV = Convert.ToInt32(dr["MaCV"]);
        }

        public override string ToString()
        {
            return $"MaNV: {MaNV}, HoTen: {HoTen}, GioiTinh: {GioiTinh}, NgaySinh: {NgaySinh.ToShortDateString()}, SDT: {SDT}, DiaChi: {DiaChi}, Email: {Email}, MaPB: {MaPB}, MaCV: {MaCV}";
        }
    }
}
