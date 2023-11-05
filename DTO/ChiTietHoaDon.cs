using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.DTO
{
    public class ChiTietHoaDon
    {
        public ChiTietHoaDon()
        {
        }

        public ChiTietHoaDon(string maHoaDon, string maSanPham, string maKhuyenMai, int soLuong, decimal donGia, decimal thanhTien)
        {
            this.maHoaDon = maHoaDon;
            this.maSanPham = maSanPham;
            this.maKhuyenMai = maKhuyenMai;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }

        public string maHoaDon {  get; set; }
        public string maSanPham { get; set; }
        public string maKhuyenMai {  get; set; }
        public int soLuong {  get; set; }
        public decimal donGia { get; set; }
        public decimal thanhTien {  get; set; }
    }
}
