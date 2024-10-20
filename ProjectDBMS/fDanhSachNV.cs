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
    public partial class fDanhSachNV : Form
    {
        public fDanhSachNV()
        {
            InitializeComponent();
            DataTable dt = DAO.NhanVienDAO.LayTatCaNhanVien();
            foreach (DataRow row in dt.Rows)
            {
                ucNhanVien uc = new ucNhanVien(row);
                pnlNhanVien.Controls.Add(uc);
            }
            //Lay danh sach phong ban
            DataTable dtPhongBan = DAO.PhongBanDAO.LayTatCaPhongBan();
            DataRow dr = dtPhongBan.NewRow();
            dr["MaPB"] = 0;
            dr["TenPB"] = "Tất cả";
            dtPhongBan.Rows.InsertAt(dr, 0);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            fThemNhanVien f = new fThemNhanVien();
            f.ShowDialog();
            //LoadForm();
        }
        //khoi tao lai form
        public void LoadForm()
        {
            pnlNhanVien.Controls.Clear();
            DataTable dt = DAO.NhanVienDAO.LayTatCaNhanVien();
            foreach (DataRow row in dt.Rows)
            {
                ucNhanVien uc = new ucNhanVien(row);
                pnlNhanVien.Controls.Add(uc);
            }
        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlNhanVien.Controls.Clear();
            if(cbPhongBan.Text == "Tất cả")
            {
                DataTable dt = DAO.NhanVienDAO.LayTatCaNhanVien();
                foreach (DataRow row in dt.Rows)
                {
                    ucNhanVien uc = new ucNhanVien(row);
                    pnlNhanVien.Controls.Add(uc);
                }
            }
            else
            {
                DataTable dt = DAO.NhanVienDAO.LayNhanVienTheoMaPB(int.Parse(cbPhongBan.SelectedValue.ToString()));
                foreach (DataRow row in dt.Rows)
                {
                    ucNhanVien uc = new ucNhanVien(row);
                    pnlNhanVien.Controls.Add(uc);
                }
            }
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlNhanVien.Controls.Clear();
            if (cbChucVu.Text == "Tất cả")
            {
                DataTable dt = DAO.NhanVienDAO.LayTatCaNhanVien();
                foreach (DataRow row in dt.Rows)
                {
                    ucNhanVien uc = new ucNhanVien(row);
                    pnlNhanVien.Controls.Add(uc);
                }
            }
            else
            {
                DataTable dt = DAO.NhanVienDAO.LayNhanVienTheoMaCV(int.Parse(cbChucVu.SelectedValue.ToString()));
                foreach (DataRow row in dt.Rows)
                {
                    ucNhanVien uc = new ucNhanVien(row);
                    pnlNhanVien.Controls.Add(uc);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            pnlNhanVien.Controls.Clear();
            DataTable dt = DAO.NhanVienDAO.LayNhanVienTheoKeyword(txtSearch.Text);
            foreach (DataRow row in dt.Rows)
            {
                ucNhanVien uc = new ucNhanVien(row);
                pnlNhanVien.Controls.Add(uc);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            pnlNhanVien.Controls.Clear();
            DataTable dt = DAO.NhanVienDAO.LayTatCaNhanVien();
            foreach (DataRow row in dt.Rows)
            {
                ucNhanVien uc = new ucNhanVien(row);
                pnlNhanVien.Controls.Add(uc);
            }
        }
    }
}
