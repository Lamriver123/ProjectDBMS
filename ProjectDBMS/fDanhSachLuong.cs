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
        }

        public void CapNhatNgay(DateTime ngay)
        {
            pnlDSLuong.Controls.Clear();
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
                DataTable dt = LuongDAO.LayLuongThucNhanTangDan(DateTime.Now);
                foreach (DataRow dr in dt.Rows)
                {
                    ucLuongNV uc = new ucLuongNV(dr);
                    pnlDSLuong.Controls.Add(uc);
                }
            }
            else
            {
                DataTable dt = LuongDAO.LayLuongThucNhanGiamDan(DateTime.Now);
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
    }
}
