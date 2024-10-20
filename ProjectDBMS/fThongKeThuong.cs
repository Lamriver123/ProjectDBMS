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
        }

        private void btnThemThuong_Click(object sender, EventArgs e)
        {
            Form form = new fThemThuong();
            form.ShowDialog();
        }
    }
}
