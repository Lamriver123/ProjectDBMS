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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ProjectDBMS
{
    public partial class ucPhatNV : UserControl
    {
        public ucPhatNV()
        {
            InitializeComponent();
        }
        public ucPhatNV(DataRow dr)
        {
            Random rand = new Random();
            InitializeComponent();
            DR = dr;
            txtHoTen.Text = dr["HoTen"].ToString();
            lblSTT.Text = dr["MaNV"].ToString();
            txtSoTien.Text = dr["SoTien"].ToString();
            txtTenPB.Text = dr["TenPB"].ToString();
            txtTenCV.Text = dr["TenCV"].ToString();
            txtNgayCapNhat.Text = dr["NgayCapNhat"].ToString();
            btnAvt.FillColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            btnAvt.Text = dr["HoTen"].ToString().Substring(0, 1);
        }
        DataRow DR;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fCapNhatKhauTru f = new fCapNhatKhauTru(DR);
            f.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ThuongKhauTruDAO.XoaThuongKhauTru(int.Parse(DR["MaTKT"].ToString()), int.Parse(DR["MaNV"].ToString())))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
