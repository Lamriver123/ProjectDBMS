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
    public partial class ucLuongNV : UserControl
    {
        public ucLuongNV()
        {
            InitializeComponent();
        }

        public ucLuongNV(DataRow dr)
        {
            InitializeComponent();
            txtHoTen.Text = dr["HoTen"].ToString();
            txtLuongThucNhan.Text = dr["LuongThucNhan"].ToString();
            txtTenCV.Text = dr["TenCV"].ToString();
            txtTenPB.Text = dr["TenPB"].ToString();
            lblSTT.Text = dr["MaNV"].ToString();
        }
        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Form form = new fChiTietLuong();
            form.ShowDialog();
        }

    }
}
