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
    public partial class fThemNhanVien : Form
    {
        public fThemNhanVien()
        {
            InitializeComponent();
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
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Model.NhanVien nhanVien = new Model.NhanVien(1, txtHoTen.Text, txtGioiTinh.Text, txtNgaySinh.Value.Date, txtSDT.Text, txtDiaChi.Text, txtEmail.Text, int.Parse(txtMaPB.Text), int.Parse(txtMaCV.Text));
                DAO.NhanVienDAO.ThemNhanVien(nhanVien);
                MessageBox.Show("Thêm nhân viên thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm nhân viên thất bại" + ex);
            }
        }
    }
}
