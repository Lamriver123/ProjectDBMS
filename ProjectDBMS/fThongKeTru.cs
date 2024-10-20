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
        }

        private void btnThemPhat_Click(object sender, EventArgs e)
        {
            Form form = new fThemPhat();
            form.ShowDialog();
        }
    }
}
