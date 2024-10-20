using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDBMS.Model
{
    internal class ThuongKhauTru
    {
        int maTKT;
        int maNV;
        int soTien;
        string chuThich;
        string phanLoai;
        DateTime ngayCapNhat;

        public int MaTKT { get => maTKT; set => maTKT = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public int SoTien { get => soTien; set => soTien = value; }
        public string ChuThich { get => chuThich; set => chuThich = value; }
        public string PhanLoai { get => phanLoai; set => phanLoai = value; }
        public DateTime NgayCapNhat { get => ngayCapNhat; set => ngayCapNhat = value; }

        public ThuongKhauTru(int maTKT, int maNV, int soTien, string chuThich, string phanLoai, DateTime ngayCapNhat)
        {
            this.MaTKT = maTKT;
            this.MaNV = maNV;
            this.SoTien = soTien;
            this.ChuThich = chuThich;
            this.PhanLoai = phanLoai;
            this.NgayCapNhat = ngayCapNhat;
        }
    }
}
