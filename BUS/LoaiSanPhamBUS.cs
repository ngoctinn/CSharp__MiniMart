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

        public List<LoaiSanPham> TimKiemTheoTen(string tenLoaiSanPham)
        {
            tenLoaiSanPham = tenLoaiSanPham.Trim().ToLower();

            return loaiSanPhamDAO.TimKiemTheoTen(tenLoaiSanPham);
        }

        public string ThemLoaiSanPham(string maLoaiSanPham, string tenLoaiSanPham)
        {
            if (string.IsNullOrEmpty(tenLoaiSanPham))
                return "Vui lòng nhập đầy đủ thông tin!";

            tenLoaiSanPham = tenLoaiSanPham.Trim();

            if (loaiSanPhamDAO.KiemTraDaTonTai(tenLoaiSanPham.ToLower()))
                return "Loại sản phẩm đã tồn tại, vui lòng chọn tên khác!";
            else
            {
                LoaiSanPham loaiSanPham = new LoaiSanPham(maLoaiSanPham, tenLoaiSanPham);

                if (loaiSanPhamDAO.ThemLoaiSanPham(loaiSanPham))
                    return "Thêm loại sản phẩm thành công!";
                else
                    return "Thêm loại sản phẩm thất bại!";
            }
        }

        public string XoaLoaiSanPham(string maLoaiSanPham)
        {
            if (loaiSanPhamDAO.XoaLoaiSanPham(maLoaiSanPham))
                return "Xóa sản phẩm thành công!";

            return "Xóa sản phẩm thất bại!";
        }

        public string ChinhSuaLoaiSanPham(string maLoaiSanPham, string tenLoaiSanPham)
        {
            if (string.IsNullOrEmpty(tenLoaiSanPham))
                return "Vui lòng nhập đầy đủ thông tin!";
            
            LoaiSanPham loaiSanPham = new LoaiSanPham(maLoaiSanPham, tenLoaiSanPham);

            if (loaiSanPhamDAO.ChinhSuaLoaiSanPham(loaiSanPham))
                return "Chỉnh sửa loại sản phẩm thành công!";
            else
                return "Chỉnh sửa loại sản phẩm thất bại!";
        }
    }
}
