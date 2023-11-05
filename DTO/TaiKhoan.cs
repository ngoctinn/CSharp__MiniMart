using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.DTO
{
    public class TaiKhoan
    {
        public TaiKhoan()
        {
            trangThai = true;
        }

        public TaiKhoan(string maPhanQuyen, string tenTaiKhoan, string matKhau)
        {
            this.maPhanQuyen = maPhanQuyen;
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            trangThai = true;
        }

        public string maPhanQuyen { get; set; }
        public string tenTaiKhoan { get; set; }
        public string matKhau {  get; set; }
        public bool trangThai { get; set; }
    }
}
