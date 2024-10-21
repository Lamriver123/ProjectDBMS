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
        }
        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            int num = 1;
            if (txtNam.Text != "" && int.TryParse(txtNam.Text, out num) && int.Parse(txtNam.Text)>0)
            {
                if (txtNam.Text == DateTime.Now.Year.ToString())
                {
                    txtThang.Items.Clear();
                    int tmp = DateTime.Now.Month;
                    for (int i = 1; i <= tmp; i++)
                    {
                        txtThang.Items.Add(i);
                        txtThang.Enabled = true;
                    }
                }
                else if (int.Parse(txtNam.Text) < DateTime.Now.Year)
                {
                    txtThang.Items.Clear();
                    for (int i = 1; i <= 12; i++)
                    {
                        txtThang.Items.Add(i);
                        txtThang.Enabled = true;
                    }
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
