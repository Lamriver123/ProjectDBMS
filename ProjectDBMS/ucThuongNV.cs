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
    public partial class ucThuongNV : UserControl
    {
        
        public ucThuongNV()
        {
            InitializeComponent();
        }
        public ucThuongNV(DataRow dr)
        {
            InitializeComponent();
            DR=dr;
            txtHoTen.Text = dr["HoTen"].ToString();
            lblSTT.Text = dr["MaNV"].ToString();
            txtSoTien.Text = dr["SoTien"].ToString();
            txtTenPB.Text = dr["TenPB"].ToString();
            txtTenCV.Text = dr["TenCV"].ToString();
            txtNgayCapNhat.Text = dr["NgayCapNhat"].ToString();
        }
        DataRow DR;
        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fCapNhatThuong f = new fCapNhatThuong(DR);
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
