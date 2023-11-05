using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.DTO
{
    public class KhachHang : ConNguoi
    {
        public string maKhachHang {  get; set; }
        public string bacThanhVien { get; set; }
        public int diemThanhVien { get; set; }
        public int diemTichLuy {  get; set; }
        public KhachHang()
        {
        }

        public KhachHang(string hoTen, string gioiTinh, DateTime ngaySinh, string soDienThoai, string email, string diaChi, string maKhachHang, string bacThanhVien, int diemThanhVien, int diemTichLuy) : base(hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi)
        {
            this.maKhachHang = maKhachHang;
            this.bacThanhVien = bacThanhVien;
            this.diemThanhVien = diemThanhVien;
            this.diemTichLuy = diemTichLuy;
        }
    }
}
