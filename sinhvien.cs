using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TAHUUCONG_BUOI4
{
    internal class sinhvien
    {
        string MSSV;

        public void setMSSV(string MSSV)
        {
            this.MSSV = MSSV;
        }

        public string getMSSV()
        {
            return this.MSSV;
        }
        string hoTen;
        public void setHoTen(string hoTen)
        {
            this.hoTen = hoTen;
        }
        public string getHoTen()
        {
            return hoTen;
        }
        string gioiTinh;
        public void setGioiTinh(string gioiTinh)
        {
            this.gioiTinh = gioiTinh;
        }
        public string getGioiTinh()
        {
            return gioiTinh;
        }
        DateTime ngaySinh;

        public void setNgaySinh(DateTime ngaySinh)
        {
            this.ngaySinh = ngaySinh;
        }
        public DateTime getNgaySinh()
        {
            return ngaySinh;
        }
        string diaChi;
        public void setDiaChi(string diaChi)
        {
            this.diaChi = diaChi;
        }
        public string getDiaChi()
        {
            return diaChi;
        }

        // viết hàm khởi tạo
        // Hàm khởi tạo không có tham số
        public sinhvien() { }

        public sinhvien(string MSSV, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi)
        {
            this.MSSV = MSSV;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
        }
    }
}