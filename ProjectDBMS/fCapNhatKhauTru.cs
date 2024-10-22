using ProjectDBMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDBMS
{
    public partial class fCapNhatKhauTru : Form
    {
        public fCapNhatKhauTru(DataRow dr)
        {
            InitializeComponent();
            MaTKT = int.Parse(dr["MaTKT"].ToString());
            txtMaNV.Text = dr["MaNV"].ToString();
            txtHoTen.Text = dr["HoTen"].ToString();
            txtSoTien.Text = dr["SoTien"].ToString();
            txtLyDo.Text = dr["ChuThich"].ToString();
        }
        int MaTKT;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThuongKhauTru thuongKhauTru = new ThuongKhauTru(MaTKT, int.Parse(txtMaNV.Text), (int)double.Parse(txtSoTien.Text), txtLyDo.Text, "Khấu trừ", DateTime.Now.Date);
            if (DAO.ThuongKhauTruDAO.SuaThuongKhauTru(thuongKhauTru))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
