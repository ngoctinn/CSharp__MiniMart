using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.DTO
{
    public class NhanVien : ConNguoi
    {
        public NhanVien()
        {
            trangThai = true;
        }

        public NhanVien(string hoTen, string gioiTinh, DateTime ngaySinh, string soDienThoai, string email, string diaChi, string maNhanVien, string tenTaiKhoan) : base(hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi)
        {
            this.maNhanVien = maNhanVien;
            this.tenTaiKhoan = tenTaiKhoan;
            trangThai = true;
        }

        public string maNhanVien {  get; set; }
        public string tenTaiKhoan { get; set; }
        public bool trangThai {  get; set; }

    }
}
