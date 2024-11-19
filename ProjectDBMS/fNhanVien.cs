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
    public partial class fNhanVien : Form
    {
        private Form activeForm = null;
        public fNhanVien()
        {
            InitializeComponent();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            btnThongTinCaNhan.FillColor = Color.FromArgb(128, 128, 255);
            btnThongTinLuong.FillColor = Color.Transparent;

            DataRow dr = NhanVienDAO.LayThongTinNhanVienTheoMaNV(fDangNhap.MaNV);

            Form fChild = new fThongTinCaNhan(dr);
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
            fDangNhap.role = 0;
            this.Close();
        }

        private void btnThongTinLuong_Click(object sender, EventArgs e)
        {
            btnThongTinLuong.FillColor = Color.FromArgb(128, 128, 255);
            btnThongTinCaNhan.FillColor = Color.Transparent;
            DataRow dr =  NhanVienDAO.LayChiTietLuongNhanVienTheoMaNV(fDangNhap.MaNV,DateTime.Now);
            String loaiCV = NhanVienDAO.LayLoaiChucVu(fDangNhap.MaNV);
            if (loaiCV == "Tháng")
            {
                Form fChild = new fThongTinLuong(dr);
                AddChild(fChild);
            }
            else if (loaiCV == "Chỉ tiêu")
            {
                Form fChild = new fThongTinLuongKPI(dr);
                AddChild(fChild);
            }
            else
            {
                Form fChild = new fThongTinLuongTheoGio(dr);
                AddChild(fChild);
            }
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            
            btnThongTinCaNhan_Click(sender, e);
        }
    }
}
