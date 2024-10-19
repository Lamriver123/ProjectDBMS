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
    public partial class fQuanLy : Form
    {
        private Form activeForm = null;
        public fQuanLy()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDanhSachNV_Click(object sender, EventArgs e)
        {
            btnDanhSachNV.FillColor = Color.FromArgb(128, 128, 255);
            btnDanhSachThuong.FillColor = Color.Transparent;
            btnDanhSachTru.FillColor  = Color.Transparent;
            btnLuongNV.FillColor = Color.Transparent;

            Form fChild = new fDanhSachNV();
            AddChild(fChild);
        }
        
        
        private void btnDanhSachThuong_Click(object sender, EventArgs e)
        {
            btnDanhSachThuong.FillColor = Color.FromArgb(128, 128, 255);
            btnDanhSachNV.FillColor = Color.Transparent;
            btnDanhSachTru.FillColor = Color.Transparent;
            btnLuongNV.FillColor = Color.Transparent;

            Form fChild = new fThongKeThuong();
            AddChild(fChild);
        }

        private void btnDanhSachTru_Click(object sender, EventArgs e)
        {
            btnDanhSachTru.FillColor = Color.FromArgb(128, 128, 255);
            btnDanhSachNV.FillColor = Color.Transparent;
            btnDanhSachThuong.FillColor = Color.Transparent;
            btnLuongNV.FillColor = Color.Transparent;

            Form fChild = new fThongKeTru();
            AddChild(fChild);
        }

        private void btnLuongNV_Click(object sender, EventArgs e)
        {
            btnLuongNV.FillColor = Color.FromArgb(128, 128, 255);
            btnDanhSachNV.FillColor = Color.Transparent;
            btnDanhSachTru.FillColor = Color.Transparent;
            btnDanhSachThuong.FillColor = Color.Transparent;

            Form fChild = new fLuongNV();
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
            pChild.Controls.Add(Child);
            pChild.Tag = Child;
            Child.BringToFront();
            Child.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDanhSachNV_Click(sender, e);
        }
    }
}
