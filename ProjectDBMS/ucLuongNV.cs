using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
            Random rand = new Random();
            InitializeComponent();
            txtHoTen.Text = dr["HoTen"].ToString();
            txtLuongThucNhan.Text = dr["LuongThucNhan"].ToString();
            txtTenCV.Text = dr["TenCV"].ToString();
            txtTenPB.Text = dr["TenPB"].ToString();
            lblSTT.Text = dr["MaNV"].ToString();
            btnAvt.FillColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            btnAvt.Text = dr["HoTen"].ToString().Substring(0, 1);
        }
        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Form form = new fChiTietLuong();
            form.ShowDialog();
        }


    }
}
