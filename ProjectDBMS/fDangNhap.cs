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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        public static int MaNV =-1;
        public static int role = 0;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(AccountDAO.Login(txtUserName.Text, txtPassword.Text))
            {
                if (role == 0)
                {
                   // role = 0;
                    Form form = new fQuanLy();
                    form.ShowDialog();
                }
                else
                {
                  //  role = 1;
                    Form form = new fNhanVien();
                    form.ShowDialog();
                }
            }
            else { 
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }   
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
