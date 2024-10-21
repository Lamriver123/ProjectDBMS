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
    public partial class fThongKeThuong : Form
    {
        public fThongKeThuong()
        {
            InitializeComponent();
            DataTable dt = ThuongKhauTruDAO.LayTatCaThuong();
            foreach (DataRow dr in dt.Rows)
            {
                ucThuongNV uc = new ucThuongNV(dr);
                pnlDSThuong.Controls.Add(uc);
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
        private void btnThemThuong_Click(object sender, EventArgs e)
        {
            Form form = new fThemThuong();
            form.ShowDialog();
            Load();
        }

        private void Load()
        {
            pnlDSThuong.Controls.Clear();
            DataTable dt = ThuongKhauTruDAO.LayTatCaThuong();
            foreach (DataRow dr in dt.Rows)
            {
                ucThuongNV uc = new ucThuongNV(dr);
                pnlDSThuong.Controls.Add(uc);
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

        private void btnAll_Click(object sender, EventArgs e)
        {
            pnlDSThuong.Controls.Clear();
            DataTable dt = ThuongKhauTruDAO.LayTatCaThuong();
            foreach (DataRow dr in dt.Rows)
            {
                ucThuongNV uc = new ucThuongNV(dr);
                pnlDSThuong.Controls.Add(uc);
            }
        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDSThuong.Controls.Clear();
            if(cbPhongBan.Text == "Tất cả")
            {
                DataTable dt = ThuongKhauTruDAO.LayTatCaThuong();
                foreach (DataRow row in dt.Rows)
                {
                    ucThuongNV uc = new ucThuongNV(row);
                    pnlDSThuong.Controls.Add(uc);
                }
            }
            else
            {
                DataTable dt = ThuongKhauTruDAO.LayThuongTheoPB(int.Parse(cbPhongBan.SelectedValue.ToString()));
                foreach (DataRow row in dt.Rows)
                {
                    ucThuongNV uc = new ucThuongNV(row);
                    pnlDSThuong.Controls.Add(uc);
                }
            }
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDSThuong.Controls.Clear();
            if (cbChucVu.Text == "Tất cả")
            {
                DataTable dt = ThuongKhauTruDAO.LayTatCaThuong();
                foreach (DataRow row in dt.Rows)
                {
                    ucThuongNV uc = new ucThuongNV(row);
                    pnlDSThuong.Controls.Add(uc);
                }
            }
            else
            {
                DataTable dt = ThuongKhauTruDAO.LayThuongTheoCV(int.Parse(cbChucVu.SelectedValue.ToString()));
                foreach (DataRow row in dt.Rows)
                {
                    ucThuongNV uc = new ucThuongNV(row);
                    pnlDSThuong.Controls.Add(uc);
                }
            }
        }

        private void cbSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sắp xếp tang dan, giam dan
            pnlDSThuong.Controls.Clear();
            if (cbSX.Text == "Tăng dần")
            {
                DataTable dt = ThuongKhauTruDAO.LayTatCaThuongTangDan();
                foreach (DataRow row in dt.Rows)
                {
                    ucThuongNV uc = new ucThuongNV(row);
                    pnlDSThuong.Controls.Add(uc);
                }
            }
            else
            {
                DataTable dt = ThuongKhauTruDAO.LayTatCaThuongGiamDan();
                foreach (DataRow row in dt.Rows)
                {
                    ucThuongNV uc = new ucThuongNV(row);
                    pnlDSThuong.Controls.Add(uc);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Tìm kiếm theo tên
            pnlDSThuong.Controls.Clear();
            DataTable dt = ThuongKhauTruDAO.LayThuongTheoKey(txtSearch.Text);
            foreach (DataRow row in dt.Rows)
            {
                ucThuongNV uc = new ucThuongNV(row);
                pnlDSThuong.Controls.Add(uc);
            }
        }
    }
}
