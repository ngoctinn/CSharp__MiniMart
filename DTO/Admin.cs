using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.DTO
{
    public class Admin : ConNguoi
    {
        public Admin()
        {
            trangThai = true;
        }

        public Admin(string hoTen, string gioiTinh, DateTime ngaySinh, string soDienThoai, string email, string diaChi, string maAdmin, string tenTaiKhoan, bool trangThai) : base(hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi)
        {
            this.maAdmin = maAdmin;
            this.tenTaiKhoan = tenTaiKhoan;
            trangThai = true;
        }

        public string maAdmin {  get; set; }
        public string tenTaiKhoan { get; set; }
        public bool trangThai { get; set; }
    }
}
