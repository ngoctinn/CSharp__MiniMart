using C__Final_Project_MiniMart.DAO;
using C__Final_Project_MiniMart.DTO;
using OtherFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO sanPhamDAO;
        public SanPhamBUS() 
        {
            sanPhamDAO = new SanPhamDAO();
        }
        
        public List<SanPham> LayDanhSachSanPham()
        {
            return sanPhamDAO.LayDanhSachSanPham();
        }

        public int DemSoSanPham()
        {
            return sanPhamDAO.DemSoSanPham();
        }

        public string ThemSanPham(string maSanPham, string maLoaiSanPham, string maNhaCungCap, string tenSanPham, string donViTinh, string giaBan, string duongDanAnh)
        {
            if (string.IsNullOrEmpty(maLoaiSanPham) || string.IsNullOrEmpty(maNhaCungCap) || string.IsNullOrEmpty(tenSanPham) || string.IsNullOrEmpty(donViTinh) || string.IsNullOrEmpty(giaBan) || string.IsNullOrEmpty(duongDanAnh)) 
                return "Vui lòng nhập đầy đủ thông tin!";

            SanPham sanPham = new SanPham();

            sanPham.maSanPham = maSanPham;
            sanPham.maLoaiSanPham = maLoaiSanPham;
            sanPham.maNhaCungCap = maNhaCungCap;
            sanPham.tenSanPham= tenSanPham;
            sanPham.donViTinh = donViTinh;
            sanPham.soLuong = 0;
            sanPham.giaBan = Decimal.Parse(giaBan);
            sanPham.duongDanAnh = duongDanAnh;

            if (sanPhamDAO.ThemSanPham(sanPham))
                return "Thêm sản phẩm thành công!";
            else
                return "Thêm sản phẩm thất bại!";
        }

        public string XoaSanPham(string maSanPham)
        {
            if (sanPhamDAO.XoaSanPham(maSanPham))
                return "Xóa sản phẩm thành công!";

            return "Xóa sản phẩm thất bại!";
        }

        public string SuaSanPham(string maSanPham, string maLoaiSanPham, string maNhaCungCap, string tenSanPham, string donViTinh, string giaBan, string duongDanAnh)
        {
            if (string.IsNullOrEmpty(tenSanPham))
                return "Tên sản phẩm không được bỏ trống!";

            if (string.IsNullOrEmpty(donViTinh))
                return "Đơn vị tính không được bỏ trống!";

            if (string.IsNullOrEmpty(giaBan))
                return "Giá bán không được bỏ trống!";

            SanPham sanPham = new SanPham(maSanPham, maLoaiSanPham, maNhaCungCap, tenSanPham, donViTinh, Decimal.Parse(giaBan), duongDanAnh);

            if (sanPhamDAO.SuaSanPham(sanPham))
                return "Sửa thông tin sản phẩm thành công!";
            else
                return "Sửa thông tin sản phẩm thất bại!";
        }

        public List<SanPham> TimKiemSanPham(string keyword, string tenLoaiSanPham = "Mặc định", string tenNhaCungCap = "Mặc định")
        {
            keyword = keyword.Trim().ToLower();

            LoaiSanPhamBUS loaiSanPhamBUS = new LoaiSanPhamBUS();
            LoaiSanPham loaiSanPham = loaiSanPhamBUS.LayLoaiSanPhamTheoTen(tenLoaiSanPham);

            NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
            NhaCungCap nhaCungCap = nhaCungCapBUS.LayNhaCungCapTheoTen(tenNhaCungCap);

            return sanPhamDAO.TimKiemSanPham(keyword, loaiSanPham.maLoaiSanPham, nhaCungCap.maNhaCungCap);
        }
    }
}
