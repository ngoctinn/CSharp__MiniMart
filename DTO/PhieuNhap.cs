using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.DTO
{
    public class PhieuNhap
    {
        public PhieuNhap()
        {
            trangThaiDuyet = false;
            trangThai = true;
        }

        public PhieuNhap(string maPhieuNhap, string maNhaCungCap, string maNhanVien, string maQuanLi, DateTime thoiGianTao, decimal thanhTien)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maNhaCungCap = maNhaCungCap;
            this.maNhanVien = maNhanVien;
            this.maQuanLi = maQuanLi;
            this.thoiGianTao = thoiGianTao;
            this.thanhTien = thanhTien;
            trangThaiDuyet = false;
            trangThai = true;
        }

        public string maPhieuNhap { get; set; }
        public string maNhaCungCap { get; set; }
        public string maNhanVien {  get; set; }
        public string maQuanLi { get; set; }
        public DateTime thoiGianTao { get; set; }
        public decimal thanhTien {  get; set; }
        public bool trangThaiDuyet { get; set; }
        public bool trangThai { get; set; }
    }
}
