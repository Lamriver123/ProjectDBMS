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
using System.Xml.Linq;

namespace ProjectDBMS
{
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
        }
        public ucNhanVien(DataRow dr)
        {
            InitializeComponent();
            MaNV = int.Parse(dr["MaNV"].ToString());
            txtHoTen.Text = dr["HoTen"].ToString();
            txtSDT.Text = dr["SDT"].ToString();
            txtTenCV.Text = dr["TenCV"].ToString();
            txtTenPB.Text = dr["TenPB"].ToString();
        }
        int MaNV = 0;
        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                NhanVienDAO.XoaNhanVien(MaNV);
                MessageBox.Show("Xóa nhân viên thành công");
                this.Dispose();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fCapNhatNhanVien f = new fCapNhatNhanVien(MaNV);
            f.ShowDialog();
            if (fCapNhatNhanVien.isCapNhat)
            {
                DataTable dt = NhanVienDAO.LayTatCaNhanVien();
                this.Controls.Clear();
                DataRow rs=null;
                foreach (DataRow dr in dt.Rows)
                {
                    if (int.Parse(dr["MaNV"].ToString()) == MaNV)
                    {
                        rs = dr;
                        break;
                    }
                }
                ucNhanVien uc = new ucNhanVien(rs);
                this.Controls.Add(uc);
            }
        }
    }
}
