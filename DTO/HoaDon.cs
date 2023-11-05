using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.DTO
{
    public class HoaDon
    {
        public HoaDon()
        {
        }

        public HoaDon(string maHoaDon, string maNhanVien, string maKhachHang, string maKhuyenMai, DateTime thoiGianTao, decimal tongTien, decimal giaTriKhuyenMai, decimal thanhTien, decimal tienNhan, decimal tienThua)
        {
            this.maHoaDon = maHoaDon;
            this.maNhanVien = maNhanVien;
            this.maKhachHang = maKhachHang;
            this.maKhuyenMai = maKhuyenMai;
            this.thoiGianTao = thoiGianTao;
            this.tongTien = tongTien;
            this.giaTriKhuyenMai = giaTriKhuyenMai;
            this.thanhTien = thanhTien;
            this.tienNhan = tienNhan;
            this.tienThua = tienThua;
        }

        public string maHoaDon {  get; set; }
        public string maNhanVien { get; set; }
        public string maKhachHang { get; set; }
        public string maKhuyenMai { get; set; }
        public DateTime thoiGianTao { get; set; }
        public decimal tongTien {  get; set; }
        public decimal giaTriKhuyenMai { get; set; }
        public decimal thanhTien { get; set; }
        public decimal tienNhan { get; set; }
        public decimal tienThua {  get; set; }
    }
}
