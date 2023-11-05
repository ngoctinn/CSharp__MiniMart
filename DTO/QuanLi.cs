using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.DTO
{
    public class QuanLi : ConNguoi
    {
        public QuanLi()
        {
            trangThai = true;
        }

        public QuanLi(string hoTen, string gioiTinh, DateTime ngaySinh, string soDienThoai, string email, string diaChi, string maQuanLi, string tenTaiKhoan) : base(hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi)
        {
            this.maQuanLi = maQuanLi;
            this.tenTaiKhoan = tenTaiKhoan;
            trangThai = true;
        }

        public string maQuanLi {  get; set; }
        public string tenTaiKhoan { get; set; }
        public bool trangThai {  get; set; }
    }
}
