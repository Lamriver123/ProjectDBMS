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
    }
}
