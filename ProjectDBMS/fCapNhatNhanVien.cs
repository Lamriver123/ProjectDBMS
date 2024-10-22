using ProjectDBMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            DataTable dtPhongBan = DAO.PhongBanDAO.LayTatCaPhongBan();
            txtTenPB.DisplayMember = "TenPB";
            txtTenPB.ValueMember = "MaPB";
            txtTenPB.DataSource = dtPhongBan;

            DataTable dtChucVu = DAO.ChucVuDAO.LayTatCaChucVu();
            txtTenCV.DisplayMember = "TenCV";
            txtTenCV.ValueMember = "MaCV";
            txtTenCV.DataSource = dtChucVu;
            NhanVien nhanVien = DAO.NhanVienDAO.LayNhanVienTheoMaNV(MaNV);
            maNV = MaNV;
            lblMaNV.Text = MaNV.ToString();
            txtHoTen.Text = nhanVien.HoTen;
            txtGioiTinh.Text = nhanVien.GioiTinh;
            txtNgaySinh.Value = nhanVien.NgaySinh;
            txtSDT.Text = nhanVien.SDT;
            txtDiaChi.Text = nhanVien.DiaChi;
            txtEmail.Text = nhanVien.Email;

            foreach (DataRow dt in dtPhongBan.Rows)
            {
                if (dt["MaPB"].ToString() == nhanVien.MaPB.ToString())
                {
                    txtTenPB.Text = dt["TenPB"].ToString();
                    break;
                }
            }
            //  txtTenPB.Text = nhanVien..ToString();
            foreach (DataRow dt in dtChucVu.Rows)
            {
                if (dt["MaCV"].ToString() == nhanVien.MaCV.ToString())
                {
                    txtTenCV.Text = dt["TenCV"].ToString();
                    break;
                }
            }
           // txtTenCV.Text = nhanVien.MaCV.ToString();
        }
        int maNV=0;   
        public static bool isCapNhat = false;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien(maNV, txtHoTen.Text,txtGioiTinh.Text,txtNgaySinh.Value,txtSDT.Text,txtDiaChi.Text,txtEmail.Text, int.Parse(txtTenPB.SelectedValue.ToString()), int.Parse(txtTenCV.SelectedValue.ToString()));
            try
            {
                DAO.NhanVienDAO.SuaNhanVien(nhanVien);
                MessageBox.Show("Cập nhật thành công");
                isCapNhat = true;
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
