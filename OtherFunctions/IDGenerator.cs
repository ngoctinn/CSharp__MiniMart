using C__Final_Project_MiniMart.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherFunctions
{
    public class IDGenerator
    {
        public IDGenerator() { }

        public void GenerateLoaiSanPhamID() 
        { 
            LoaiSanPhamBUS loaiSanPhamBUS = new LoaiSanPhamBUS();

            int count = loaiSanPhamBUS.DemSoLoaiSanPham();
        }
    }
}
