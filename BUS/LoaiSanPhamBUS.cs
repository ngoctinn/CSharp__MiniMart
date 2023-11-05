using C__Final_Project_MiniMart.DAO;
using C__Final_Project_MiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.BUS
{
    public class LoaiSanPhamBUS
    {
        LoaiSanPhamDAO loaiSanPhamDAO;

        public LoaiSanPhamBUS()
        {
            loaiSanPhamDAO = new LoaiSanPhamDAO();
        }

        public List<LoaiSanPham> LayDanhSachLoaiSanPham()
        {
            List<LoaiSanPham> listLoaiSanPham = loaiSanPhamDAO.LayDanhSachLoaiSanPham();

            return listLoaiSanPham; 
        }

        public LoaiSanPham LayLoaiSanPhamTheoTen(string tenLoaiSanPham)
        {
            return loaiSanPhamDAO.LayLoaiSanPhamTheoTen(tenLoaiSanPham);
        }

        public int DemSoLoaiSanPham()
        {
            return loaiSanPhamDAO.DemSoLoaiSanPham();
        }
    }
}
