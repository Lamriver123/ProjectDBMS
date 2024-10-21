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
    public partial class fThongKeTru : Form
    {
        public fThongKeTru()
        {
            InitializeComponent();
            DataTable dataTable = DAO.ThuongKhauTruDAO.LayTatCaKhauTru();
            foreach (DataRow dr in dataTable.Rows)
            {
                ucPhatNV uc = new ucPhatNV(dr);
                pnlDSPhat.Controls.Add(uc);
            }
            txtNam.Text = DateTime.Now.Year.ToString();
            addThang(DateTime.Now.Month);
            //Lay danh sach phong ban
            DataTable dtPhongBan = DAO.PhongBanDAO.LayTatCaPhongBan();
            DataRow dr0 = dtPhongBan.NewRow();
            dr0["MaPB"] = 0;
            dr0["TenPB"] = "Tất cả";
            dtPhongBan.Rows.InsertAt(dr0, 0);
            cbPhongBan.DisplayMember = "TenPB";
            cbPhongBan.ValueMember = "MaPB";
            cbPhongBan.DataSource = dtPhongBan;
            //Lay danh sach chuc vu
            DataTable dtChucVu = DAO.ChucVuDAO.LayTatCaChucVu();
            DataRow dr1 = dtChucVu.NewRow();
            dr1["MaCV"] = 0;
            dr1["TenCV"] = "Tất cả";
            dtChucVu.Rows.InsertAt(dr1, 0);
            cbChucVu.DisplayMember = "TenCV";
            cbChucVu.ValueMember = "MaCV";
            cbChucVu.DataSource = dtChucVu;
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
        private void btnThemPhat_Click(object sender, EventArgs e)
        {
            Form form = new fThemPhat();
            form.ShowDialog();
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

        private void cbSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDSPhat.Controls.Clear();
            if (cbSX.Text == "Tăng dần")
            {
                DataTable dt = ThuongKhauTruDAO.LayTatCaKhauTruTangDan();
                foreach (DataRow row in dt.Rows)
                {
                    ucPhatNV uc = new ucPhatNV(row);
                    pnlDSPhat.Controls.Add(uc);
                }
            }
            else
            {
                DataTable dt = ThuongKhauTruDAO.LayTatCaKhauTruGiamDan();
                foreach (DataRow row in dt.Rows)
                {
                    ucPhatNV uc = new ucPhatNV(row);
                    pnlDSPhat.Controls.Add(uc);
                }
            }
        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDSPhat.Controls.Clear();
            if (cbPhongBan.Text == "Tất cả")
            {
                DataTable dt = ThuongKhauTruDAO.LayTatCaKhauTru();
                foreach (DataRow row in dt.Rows)
                {
                    ucPhatNV uc = new ucPhatNV(row);
                    pnlDSPhat.Controls.Add(uc);
                }
            }
            else
            {
                DataTable dt = ThuongKhauTruDAO.LayKhauTruTheoPB(int.Parse(cbPhongBan.SelectedValue.ToString()));
                foreach (DataRow row in dt.Rows)
                {
                    ucPhatNV uc = new ucPhatNV(row);
                    pnlDSPhat.Controls.Add(uc);
                }
            }
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDSPhat.Controls.Clear();
            if (cbChucVu.Text == "Tất cả")
            {
                DataTable dt = ThuongKhauTruDAO.LayTatCaKhauTru();
                foreach (DataRow row in dt.Rows)
                {
                    ucPhatNV uc = new ucPhatNV(row);
                    pnlDSPhat.Controls.Add(uc);
                }
            }
            else
            {
                DataTable dt = ThuongKhauTruDAO.LayKhauTruTheoCV(int.Parse(cbChucVu.SelectedValue.ToString()));
                foreach (DataRow row in dt.Rows)
                {
                    ucPhatNV uc = new ucPhatNV(row);
                    pnlDSPhat.Controls.Add(uc);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Tìm kiếm theo tên
            pnlDSPhat.Controls.Clear();
            DataTable dt = ThuongKhauTruDAO.LayKhauTruTheoKey(txtSearch.Text);
            foreach (DataRow row in dt.Rows)
            {
                ucPhatNV uc = new ucPhatNV(row);
                pnlDSPhat.Controls.Add(uc);
            }
        }
    }
}
