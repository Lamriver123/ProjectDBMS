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
    public partial class fThongTinCaNhan : Form
    {
        public fThongTinCaNhan()
        {
            InitializeComponent();
        }
        public fThongTinCaNhan(DataRow dr)
        {
            InitializeComponent();
            lblMaNV.Text = dr["MaNV"].ToString();
            txtHoTen.Text = dr["HoTen"].ToString();
            txtGioiTinh.Text = dr["GioiTinh"].ToString();
            dtpNgaySinh.Value = (DateTime)dr["NgaySinh"];
            txtSDT.Text = dr["SDT"].ToString();
            txtEmail.Text = dr["Email"].ToString();
            txtDiaChi.Text = dr["DiaChi"].ToString();
            txtTenPB.Text = dr["TenPB"].ToString();
            txtTenCV.Text = dr["TenCV"].ToString();
            txtLoaiCV.Text ="Theo " + dr["LoaiCV"].ToString();
            txtLuongCoBan.Text = dr["LuongCoBan"].ToString();
        }
    }
}
