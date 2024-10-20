using ProjectDBMS.DAO;
using ProjectDBMS.Model;
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
    public partial class fThemThuong : Form
    {
        public fThemThuong()
        {
            InitializeComponent();
        }
        private void btnDong_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            int ok;
            bool issuccess = int.TryParse(txtMaNV.Text, out ok);
            if (txtMaNV.Text!=""&& issuccess)
            {
                NhanVien nv = NhanVienDAO.LayNhanVienTheoMaNV(ok);
                if(nv != null)
                {
                    txtHoTen.Text = nv.HoTen;
                }
                else
                {
                    txtHoTen.Text = "";
                }
            }
            else
            {
                txtHoTen.Text = "";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThuongKhauTru thuongKhauTru = new ThuongKhauTru(0,int.Parse(txtMaNV.Text), int.Parse(txtSoTien.Text), txtChuThich.Text, "Thưởng",dtpNgayCapNhat.Value);
            try
            {
                ThuongKhauTruDAO.ThemThuongKhauTru(thuongKhauTru);
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại "+ex);
                throw;
            }
        }
    }
}
