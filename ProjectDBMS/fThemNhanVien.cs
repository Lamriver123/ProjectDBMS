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
    public partial class fThemNhanVien : Form
    {
        public fThemNhanVien()
        {
            InitializeComponent();
            DataTable dtPhongBan = DAO.PhongBanDAO.LayTatCaPhongBan();
            txtMaPB.DisplayMember = "TenPB";
            txtMaPB.ValueMember = "MaPB";
            txtMaPB.DataSource = dtPhongBan;

            DataTable dtChucVu = DAO.ChucVuDAO.LayTatCaChucVu();
            txtMaCV.DisplayMember = "TenCV";
            txtMaCV.ValueMember = "MaCV";
            txtMaCV.DataSource = dtChucVu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Model.NhanVien nhanVien = new Model.NhanVien(1, txtHoTen.Text, txtGioiTinh.Text, txtNgaySinh.Value.Date, txtSDT.Text, txtDiaChi.Text, txtEmail.Text, int.Parse(txtMaPB.SelectedValue.ToString()), int.Parse(txtMaCV.SelectedValue.ToString()));
                DAO.NhanVienDAO.ThemNhanVien(nhanVien);
                MessageBox.Show("Thêm nhân viên thành công");
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
