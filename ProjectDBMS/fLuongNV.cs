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

namespace ProjectDBMS
{
    public partial class fLuongNV : Form
    {
        private Form activeForm = null;
        public fLuongNV()
        {
            InitializeComponent();
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
            ds.CapNhatNgay(ngay);
        }
    }
}
