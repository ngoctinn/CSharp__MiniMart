using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.DTO
{
    public class KhuyenMai
    {
        public KhuyenMai()
        {
        }

        public KhuyenMai(string maKhuyenMai, string maQuanLi, string tenKhuyenMai, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string doiTuongApDung, string loaiGiaTri, decimal giaTriApDung)
        {
            this.maKhuyenMai = maKhuyenMai;
            this.maQuanLi = maQuanLi;
            this.tenKhuyenMai = tenKhuyenMai;
            this.thoiGianBatDau = thoiGianBatDau;
            this.thoiGianKetThuc = thoiGianKetThuc;
            this.doiTuongApDung = doiTuongApDung;
            this.loaiGiaTri = loaiGiaTri;
            this.giaTriApDung = giaTriApDung;
            trangThai = true;
        }

        public string maKhuyenMai {  get; set; }
        public string maQuanLi { get; set; }
        public string tenKhuyenMai { get; set; }
        public DateTime thoiGianBatDau { get; set; }
        public DateTime thoiGianKetThuc {  get; set; }
        public string doiTuongApDung { get; set; }
        public string loaiGiaTri { get; set; }
        public decimal giaTriApDung { get; set; }
        public bool trangThai {  get; set; }
    }
}
