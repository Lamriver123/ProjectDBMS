using ProjectDBMS.DAO;
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
    public partial class fChiTietLuong : Form
    {
        private int maNV;
        public fChiTietLuong(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fChiTietLuong_Load(object sender, EventArgs e)
        {
            DateTime ngay = fDanhSachLuong.Ngay;
            DataRow dr = NhanVienDAO.LayChiTietLuongNhanVienTheoMaNV(maNV, ngay);
            lblMaNV.Text = dr["MaNV"].ToString();
            txtHoTen.Text = dr["HoTen"].ToString();
            txtTenPB.Text = dr["TenPB"].ToString();
            txtTenCV.Text = dr["TenCV"].ToString();
            txtLuongCoBan.Text = dr["LuongCoBan"].ToString();
            txtTongThuong.Text = dr["TongThuong"].ToString();
            txtTongKT.Text = dr["TongKT"].ToString();
            lblLuongThucNhan.Text = dr["LuongThucNhan"].ToString();
            lblTitle.Text = "Chi tiết Lương tháng " + ngay.Month + " - " + ngay.Year;
            DataTable dt = ThuongKhauTruDAO.XemThuongKhauTruTheoMaNV(int.Parse(lblMaNV.Text));
            DataTable dtThuong = dt.Clone();
            DataTable dtKhauTru = dt.Clone();

            foreach (DataRow row in dt.Rows)
            {
                if (row["PhanLoai"].ToString() == "Thưởng")
                {
                    dtThuong.ImportRow(row);
                }
                else if (row["PhanLoai"].ToString() == "Khấu trừ")
                {
                    dtKhauTru.ImportRow(row);
                }
            }

            dgvThuong.DataSource = dtThuong;
            dgvKT.DataSource = dtKhauTru;
        }
    }
}
