using C__Final_Project_MiniMart.BUS;
using C__Final_Project_MiniMart.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherFunctions
{
    public class IDGenerator
    {
        /*static void Main(string[] args)
        {
            //Console.WriteLine(GenerateLoaiSanPhamID());
            Console.WriteLine(GenerateNhaCungCapID());
        }*/

        public static string GenerateLoaiSanPhamID()
        {
            LoaiSanPhamBUS loaiSanPhamBUS = new LoaiSanPhamBUS();

            int count = loaiSanPhamBUS.DemSoLoaiSanPham();

            string loaiSanPhamID = string.Format("LSP{0:D3}", ++count);

            return loaiSanPhamID;
        }

        public static string GenerateNhaCungCapID()
        {
            NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();

            int count = nhaCungCapBUS.DemSoNhaCungCap();

            string nhaCungCapID = string.Format("NCC{0:D3}", ++count);

            return nhaCungCapID;
        }

        public static string GenerateNhanVienID(string tenPhanQuyen)
        {
            NhanVienDAO nhanVienDAO = new NhanVienDAO();

            string nhanVienID = "";

            if (tenPhanQuyen.Equals("Nhân viên bán hàng"))
            {
                int count = nhanVienDAO.DemSoNhanVien(tenPhanQuyen);
                
                nhanVienID = string.Format("NBH{0:D3}", ++count);
            }

            if (tenPhanQuyen.Equals("Nhân viên kho"))
            {
                int count = nhanVienDAO.DemSoNhanVien(tenPhanQuyen);

                nhanVienID = string.Format("NVK{0:D3}", ++count);
            }

            return nhanVienID;
        }
    }
}
