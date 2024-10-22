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
    public partial class fThongTinLuong : Form
    {
        public fThongTinLuong()
        {
            InitializeComponent();
            txtNam.Text = DateTime.Now.Year.ToString();
            addThang(DateTime.Now.Month);
        }

        public fThongTinLuong(DataRow dr)
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


            DataTable dt = ThuongKhauTruDAO.XemThuongKhauTruTheoMaNV(int.Parse(dr["MaNV"].ToString()));
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
            int num = 1;
            if (txtNam.Text != "" && int.TryParse(txtNam.Text, out num) && int.Parse(txtNam.Text) > 0)
            {
                if (txtNam.Text == DateTime.Now.Year.ToString())
                {
                    addThang(DateTime.Now.Month);
                }
                else if (int.Parse(txtNam.Text) < DateTime.Now.Year)
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
        }
    }

}
