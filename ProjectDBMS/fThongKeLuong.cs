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
using static System.Net.WebRequestMethods;

namespace ProjectDBMS
{
    public partial class fThongKeLuong : Form
    {
        public fThongKeLuong()
        {
            InitializeComponent();
            DataTable dtPB =  PhongBanDAO.TongThuNhapTheoPhongBan(fDanhSachLuong.Ngay);
            DataTable dtCV = ChucVuDAO.TongThuNhapTheoChucVu(fDanhSachLuong.Ngay);
            DataTable dtTop = NhanVienDAO.DanhSachTopNhanVienLamNhieuGioNhat(fDanhSachLuong.Ngay);
            //tao bieu do tron
            Series seriesPB = new Series
            {
                Name = "Thu nhập",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie,
            };
            Series seriesCV = new Series
            {
                Name = "Thu nhập",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };
            chartPB.Series.Add(seriesPB);
            chartCV.Series.Add(seriesCV);
            foreach (DataRow dr in dtPB.Rows)
            {
                chartPB.Series["Thu nhập"].Points.AddXY(dr["TenPB"].ToString(), dr["TongThuNhap"]);
            }
            chartPB.Series["Thu nhập"]["PieLabelStyle"] = "Disabled";
            foreach (DataRow dr in dtCV.Rows)
            {
                chartCV.Series["Thu nhập"].Points.AddXY(dr["TenCV"].ToString(), dr["TongThuNhap"]);
            }
            chartCV.Series["Thu nhập"]["PieLabelStyle"] = "Disabled";
            //Top 5
            dgvTop5.DataSource = dtTop;
        }

        public void Load()
        {
            DataTable dtPB = PhongBanDAO.TongThuNhapTheoPhongBan(fDanhSachLuong.Ngay);
            DataTable dtCV = ChucVuDAO.TongThuNhapTheoChucVu(fDanhSachLuong.Ngay);
            DataTable dtTop = NhanVienDAO.DanhSachTopNhanVienLamNhieuGioNhat(fDanhSachLuong.Ngay);
            chartPB.Series["Thu nhập"].Points.Clear();
            chartCV.Series["Thu nhập"].Points.Clear();
            foreach (DataRow dr in dtPB.Rows)
            {
                chartPB.Series["Thu nhập"].Points.AddXY(dr["TenPB"].ToString(), dr["TongThuNhap"]);
            }
            chartPB.Series["Thu nhập"]["PieLabelStyle"] = "Disabled";
            foreach (DataRow dr in dtCV.Rows)
            {
                chartCV.Series["Thu nhập"].Points.AddXY(dr["TenCV"].ToString(), dr["TongThuNhap"]);
            }
            chartCV.Series["Thu nhập"]["PieLabelStyle"] = "Disabled";
            dgvTop5.DataSource = dtTop;
        }
    }
}
