using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.DTO
{
    public class SanPham
    {
        public SanPham()
        {
            trangThai = true;
        }

        public SanPham(string maSanPham, string maLoaiSanPham, string maNhaCungCap, string tenSanPham, string donViTinh, int soLuong, decimal giaBan, string duongDanAnh)
        {
            this.maSanPham = maSanPham;
            this.maLoaiSanPham = maLoaiSanPham;
            this.maNhaCungCap = maNhaCungCap;
            this.tenSanPham = tenSanPham;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.giaBan = giaBan;
            this.duongDanAnh = duongDanAnh;
            trangThai = true;
        }

        public string maSanPham {  get; set; }
        public string maLoaiSanPham { get; set; }
        public string maNhaCungCap { get; set; }
        public string tenSanPham { get; set; }
        public string donViTinh {  get; set; }
        public int soLuong {  get; set; }
        public decimal giaBan { get; set; }
        public string duongDanAnh {  get; set; }
        public bool trangThai {  get; set; }
    }
}
