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
            //DataTable dt = DAO.NhanVienDAO.LayTatCaNhanVien();
            //foreach (DataRow row in dt.Rows)
            //{
            //    ucNhanVien uc = new ucNhanVien(row);
            //    pnlNhanVien.Controls.Add(uc);
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

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

    }
}
