using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.DTO
{
    public class NhaCungCap
    {
        public NhaCungCap()
        {
        }

        public NhaCungCap(string maNhaCungCap, string tenNhaCungCap, string soDienThoai, string email, string diaChi)
        {
            this.maNhaCungCap = maNhaCungCap;
            this.tenNhaCungCap = tenNhaCungCap;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.diaChi = diaChi;
        }

        public string maNhaCungCap {  get; set; }
        public string tenNhaCungCap { get; set; }
        public string soDienThoai { get; set; }
        public string email {  get; set; }
        public string diaChi { get; set; }

    }
}
