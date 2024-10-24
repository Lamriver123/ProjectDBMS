using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectDBMS
{
    public partial class fLuongNV : Form
    {
        private Form activeForm = null;
        public fLuongNV()
        {
            InitializeComponent();
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
        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            btnDanhSach.CustomBorderColor = Color.FromArgb(88, 69, 194);
            btnThongKe.CustomBorderColor = Color.Gray;
            Form fChild = new fDanhSachLuong();
            AddChild(fChild);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            btnThongKe.CustomBorderColor = Color.FromArgb(88, 69, 194);
            btnDanhSach.CustomBorderColor = Color.Gray;
            Form fChild = new fThongKeLuong();
            AddChild(fChild);
        }
        private void AddChild(Form Child)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = Child;
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            pTrang.Controls.Add(Child);
            pTrang.Tag = Child;
            Child.BringToFront();
            Child.Show();
        }

        private void fLuongNV_Load(object sender, EventArgs e)
        {
            btnDanhSach_Click(sender, e);
        }

        private void txtThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime ngay = new DateTime(int.Parse(txtNam.Text), int.Parse(txtThang.Text), 1);
            fDanhSachLuong ds = pTrang.Controls[0] as fDanhSachLuong;
            fThongKeLuong tk = pTrang.Controls[0] as fThongKeLuong;
            if (ds != null)
            {
                ds.CapNhatNgay(ngay);
            }
            else
            {
                fDanhSachLuong.Ngay = ngay;
                tk.Load();
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
    }
}
