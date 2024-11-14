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
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectDBMS
{
    public partial class fThongTinLuongTheoGio : Form
    {
        private int MaNV;
        public fThongTinLuongTheoGio()
        {
            InitializeComponent();
            txtNam.Text = DateTime.Now.Year.ToString();
            addThang(DateTime.Now.Month);
        }

        public fThongTinLuongTheoGio(DataRow dr)
        {
            InitializeComponent();
            txtNam.Text = DateTime.Now.Year.ToString();
            addThang(DateTime.Now.Month);
            lblMaNV.Text = dr["MaNV"].ToString();
            txtHoTen.Text = dr["HoTen"].ToString();
            txtTenPB.Text = dr["TenPB"].ToString();
            txtTenCV.Text = dr["TenCV"].ToString();

            txtLuongCoBan.Text = dr["LuongCoBan"].ToString();
            txtTongThuong.Text = dr["TongThuong"].ToString();
            txtTongKT.Text = dr["TongKT"].ToString();
            lblLuongThucNhan.Text = dr["LuongThucNhan"].ToString();
            MaNV = int.Parse(dr["MaNV"].ToString());
            lblTieuDe.Text = "Chi tiết Lương tháng " + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            
            DataRow dr2 = NhanVienDAO.TinhTongGioLamTheoMaNV(fDangNhap.MaNV, DateTime.Now);
            txtGioLam.Text = dr2["TongGioLam"].ToString();

            DataTable dt = ThuongKhauTruDAO.XemThuongKhauTruTheoMaNV(MaNV, DateTime.Now);
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

            Series seriesLuong = new Series
            {
                Name = "Luong",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Column
            };
            BieuDoTKLuong.Series.Add(seriesLuong);
            LoadBieuDoLuongTheoThang(MaNV);

            Series seriesTKT = new Series
            {
                Name = "TKT",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Column
            };
            BieuDoTKT.Series.Add(seriesTKT);
            LoadBieuDoTKT(MaNV);
        }

        private void LoadBieuDoTKT(int MaNV)
        {
            BieuDoTKT.Series["TKT"].Points.Clear();
            int nam = int.Parse(txtNam.Text);
            int thangHienTai = DateTime.Now.Month;
            DataTable dt = DAO.NhanVienDAO.LayTKTNhanVienTheoNam(MaNV, nam, cbTKT.Text);
            foreach (DataRow dr in dt.Rows)
            {
                BieuDoTKT.Series["TKT"].Points.AddXY(dr["Thang"], dr["SoTien"]);
            }
        }
        private void LoadBieuDoLuongTheoThang(int MaNV)
        {
            BieuDoTKLuong.Series["Luong"].Points.Clear();
            int nam = int.Parse(txtNam.Text);
            int thangHienTai = DateTime.Now.Month;
            DataTable dt = DAO.NhanVienDAO.LayLuongNhanVienTheoNam(MaNV, nam, thangHienTai);
            foreach (DataRow dr in dt.Rows)
            {
                BieuDoTKLuong.Series["Luong"].Points.AddXY(dr["Thang"], dr["LuongThucNhan"]);
            }
        }

        private void addThang(int a)
        {
            txtThang.Items.Clear();
            for (int i = 1; i <= a; i++)
            {
                txtThang.Items.Add(i);
                txtThang.Enabled = true;
            }
        }
        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            lblTKTheoNam.Text = "Thống kê lương năm " + txtNam.Text;
            lblTKThuongKhauTruTheoNam.Text = "Thống kê thưởng, khấu trừ năm " + txtNam.Text;
            LoadBieuDoLuongTheoThang(MaNV);
            LoadBieuDoTKT(MaNV);
            int num = 1;
            if (txtNam.Text != "" && int.TryParse(txtNam.Text, out num) && int.Parse(txtNam.Text) > 0)
            {
                if (txtNam.Text == DateTime.Now.Year.ToString())
                {
                    addThang(DateTime.Now.Month);
                }
                else if (int.Parse(txtNam.Text) < DateTime.Now.Year && int.Parse(txtNam.Text) > 2000)
                {
                    addThang(12);
                }
                else
                {
                    txtThang.Enabled = false;
                    txtThang.Items.Clear();
                }
            }
            else
            {
                txtThang.Enabled = false;
                txtThang.Items.Clear();
            }


        }

        private void txtThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nam = int.Parse(txtNam.Text);
            int thang = int.Parse(txtThang.Text);
            DateTime ngay = new DateTime(nam, thang, 1);
            DataRow dr = DAO.NhanVienDAO.LayChiTietLuongNhanVienTheoMaNV(int.Parse(lblMaNV.Text), ngay);
            lblMaNV.Text = dr["MaNV"].ToString();
            txtHoTen.Text = dr["HoTen"].ToString();
            txtTenPB.Text = dr["TenPB"].ToString();
            txtTenCV.Text = dr["TenCV"].ToString();

            txtLuongCoBan.Text = dr["LuongCoBan"].ToString();
            txtTongThuong.Text = dr["TongThuong"].ToString();
            txtTongKT.Text = dr["TongKT"].ToString();
            lblLuongThucNhan.Text = dr["LuongThucNhan"].ToString();
            lblTieuDe.Text = " Chi tiết Lương tháng " + txtThang.Text + "/ " + txtNam.Text;
            DataRow dr2 = NhanVienDAO.TinhTongGioLamTheoMaNV(fDangNhap.MaNV, ngay);
            txtGioLam.Text = dr2["TongGioLam"].ToString();

        }

        private void cbTKT_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBieuDoTKT(MaNV);
        }
    }
}
