using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.DTO
{
    public class LoaiSanPham
    {
        public LoaiSanPham()
        {
            trangThai = true;
        }

        public LoaiSanPham(string maLoaiSanPham, string tenLoaiSanPham)
        {
            this.maLoaiSanPham = maLoaiSanPham;
            this.tenLoaiSanPham = tenLoaiSanPham;
            trangThai = true;
        }

        public string maLoaiSanPham {  get; set; }
        public string tenLoaiSanPham { get; set; }
        public bool trangThai {  get; set; }
    }
}
