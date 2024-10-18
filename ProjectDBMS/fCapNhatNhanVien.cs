using ProjectDBMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDBMS
{
    public partial class fCapNhatNhanVien : Form
    {
        public fCapNhatNhanVien(int MaNV)
        {
            InitializeComponent();
            isCapNhat = false;
            DataTable dt = DAO.PhongBanDAO.LayTatCaPhongBan();
            foreach (DataRow row in dt.Rows)
            {
                txtMaPB.Items.Add(row["MaPB"]);
            }
            DataTable dt1 = DAO.ChucVuDAO.LayTatCaChucVu();
            foreach (DataRow row in dt1.Rows)
            {
                txtMaCV.Items.Add(row["MaCV"]);
            }
            NhanVien nhanVien = DAO.NhanVienDAO.LayNhanVienTheoMaNV(MaNV);
            maNV = MaNV;
            txtHoTen.Text = nhanVien.HoTen;
            txtGioiTinh.Text = nhanVien.GioiTinh;
            txtNgaySinh.Value = nhanVien.NgaySinh;
            txtSDT.Text = nhanVien.SDT;
            txtDiaChi.Text = nhanVien.DiaChi;
            txtEmail.Text = nhanVien.Email;
            txtMaPB.Text = nhanVien.MaPB.ToString();
            txtMaCV.Text = nhanVien.MaCV.ToString();
        }
        int maNV=0;   
        public static bool isCapNhat = false;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien(maNV, txtHoTen.Text,txtGioiTinh.Text,txtNgaySinh.Value,txtSDT.Text,txtDiaChi.Text,txtEmail.Text,int.Parse(txtMaPB.Text),int.Parse(txtMaCV.Text));
            try
            {
                DAO.NhanVienDAO.SuaNhanVien(nhanVien);
                MessageBox.Show("Cập nhật thành công");
                isCapNhat = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
