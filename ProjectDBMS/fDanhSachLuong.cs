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
    public partial class fDanhSachLuong : Form
    {
        public fDanhSachLuong()
        {
            InitializeComponent();
            DataTable dt = LuongDAO.LayLuongThucNhanTheoNgay(DateTime.Now);
            foreach(DataRow dr in dt.Rows)
            {
                ucLuongNV uc = new ucLuongNV(dr);
                pnlDSLuong.Controls.Add(uc);
            }
            //Lay danh sach phong ban
            DataTable dtPhongBan = DAO.PhongBanDAO.LayTatCaPhongBan();
            DataRow dr0 = dtPhongBan.NewRow();
            dr0["MaPB"] = 0;
            dr0["TenPB"] = "Tất cả";
            dtPhongBan.Rows.InsertAt(dr0, 0);
            cbPB.DisplayMember = "TenPB";
            cbPB.ValueMember = "MaPB";
            cbPB.DataSource = dtPhongBan;
            //Lay danh sach chuc vu
            DataTable dtChucVu = DAO.ChucVuDAO.LayTatCaChucVu();
            DataRow dr1 = dtChucVu.NewRow();
            dr1["MaCV"] = 0;
            dr1["TenCV"] = "Tất cả";
            dtChucVu.Rows.InsertAt(dr1, 0);
            cbCV.DisplayMember = "TenCV";
            cbCV.ValueMember = "MaCV";
            cbCV.DataSource = dtChucVu;
        }
        public static DateTime Ngay = DateTime.Now;

        public void CapNhatNgay(DateTime ngay)
        {
            pnlDSLuong.Controls.Clear();
            Ngay = ngay;
            DataTable dt = LuongDAO.LayLuongThucNhanTheoNgay(ngay);
            foreach (DataRow dr in dt.Rows)
            {
                ucLuongNV uc = new ucLuongNV(dr);
                pnlDSLuong.Controls.Add(uc);
            }
        }

        private void cbSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sap xep tang dan, giam dan
            pnlDSLuong.Controls.Clear();
            if (cbSX.Text== "Lương tăng dần")
            {
                DataTable dt = LuongDAO.LayLuongThucNhanTangDan(Ngay);
                foreach (DataRow dr in dt.Rows)
                {
                    ucLuongNV uc = new ucLuongNV(dr);
                    pnlDSLuong.Controls.Add(uc);
                }
            }
            else
            {
                DataTable dt = LuongDAO.LayLuongThucNhanGiamDan(Ngay);
                foreach (DataRow dr in dt.Rows)
                {
                    ucLuongNV uc = new ucLuongNV(dr);
                    pnlDSLuong.Controls.Add(uc);
                }
            }
        }

        private void btnLuongNow_Click(object sender, EventArgs e)
        {
            CapNhatNgay(DateTime.Now);
        }

        private void cbPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loc theo phong ban
            pnlDSLuong.Controls.Clear();
            if (cbPB.Text == "Tất cả")
            {
                DataTable dt = LuongDAO.LayLuongThucNhanTheoNgay(Ngay);
                foreach (DataRow dr in dt.Rows)
                {
                    ucLuongNV uc = new ucLuongNV(dr);
                    pnlDSLuong.Controls.Add(uc);
                }
            }
            else
            {
                DataTable dt = LuongDAO.LayLuongThucNhanTheoPhongBan((int)cbPB.SelectedValue, Ngay);
                foreach (DataRow dr in dt.Rows)
                {
                    ucLuongNV uc = new ucLuongNV(dr);
                    pnlDSLuong.Controls.Add(uc);
                }
            }
        }

        private void cbCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loc theo chuc vu
            pnlDSLuong.Controls.Clear();
            if (cbCV.Text == "Tất cả")
            {
                DataTable dt = LuongDAO.LayLuongThucNhanTheoNgay(Ngay);
                foreach (DataRow dr in dt.Rows)
                {
                    ucLuongNV uc = new ucLuongNV(dr);
                    pnlDSLuong.Controls.Add(uc);
                }
            }
            else
            {
                DataTable dt = LuongDAO.LayLuongThucNhanTheoChucVu((int)cbCV.SelectedValue, Ngay);
                foreach (DataRow dr in dt.Rows)
                {
                    ucLuongNV uc = new ucLuongNV(dr);
                    pnlDSLuong.Controls.Add(uc);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //tim kiem theo key
            pnlDSLuong.Controls.Clear();
            DataTable dt = LuongDAO.TimKiemLuongTheoKey(txtSearch.Text,Ngay);
            foreach (DataRow dr in dt.Rows)
            {
                ucLuongNV uc = new ucLuongNV(dr);
                pnlDSLuong.Controls.Add(uc);
            }

        }
    }
}
