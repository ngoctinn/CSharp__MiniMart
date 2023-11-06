using C__Final_Project_MiniMart.DAO;
using C__Final_Project_MiniMart.DTO;
using OtherFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO nhanVienDAO;

        public NhanVienBUS()
        {
            nhanVienDAO = new NhanVienDAO();
        }

        public List<NhanVien> LayDanhSachNhanVien()
        {
            return nhanVienDAO.LayDanhSachNhanVien();
        }

        public int DemSoNhanVien(string tenPhanQuyen)
        {
            return nhanVienDAO.DemSoNhanVien(tenPhanQuyen);
        }

        public string ThemNhanVien(string maNhanVien, string tenTaiKhoan, string hoTen, string gioiTinh, string ngaySinh, string soDienThoai, string email, string diaChi)
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
            List<TaiKhoan> listTaiKhoan = taiKhoanDAO.LayDanhSachTaiKhoanChuaDung();

            if (listTaiKhoan.Count == 0)
                return "Không có tài khoản có sẵn, liên hệ Admin tạo tài khoản mới để tiếp tục!";

            hoTen = hoTen.Trim();
            gioiTinh = gioiTinh.Trim();
            ngaySinh = ngaySinh.Trim();
            soDienThoai = soDienThoai.Trim();
            email = email.Trim();
            diaChi = diaChi.Trim();

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(tenTaiKhoan))
                return "Tên nhân viên và tên tài khoản không được để trống!";

            if (!string.IsNullOrEmpty(ngaySinh) && !InputValidate.BirthdayValidate(ngaySinh))
                return "Vui lòng nhập ngày sinh đúng định dạng!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            DateTime dateTime = DateTime.Parse(ngaySinh);

            NhanVien nhanVien = new NhanVien(hoTen, gioiTinh, dateTime, soDienThoai, email, diaChi, maNhanVien, tenTaiKhoan);

            if (nhanVienDAO.ThemNhanVien(nhanVien))
                return "Thêm nhân viên thành công!";
            else
                return "Thêm nhân viên thất bại!";
        }

        public string XoaNhanVien(string maNhanVien)
        {
            if (nhanVienDAO.XoaNhanVien(maNhanVien))
                return "Xóa nhân viên thành công!";

            return "Xóa nhân viên thất bại!";
        }

        public string SuaNhanVien(string maNhanVien, string tenTaiKhoan, string hoTen, string gioiTinh, string ngaySinh, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(hoTen))
                return "Họ tên không được bỏ trống!";

            if (!string.IsNullOrEmpty(ngaySinh) && !InputValidate.BirthdayValidate(ngaySinh))
                return "Vui lòng nhập ngày sinh đúng định dạng!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            DateTime dateTime = DateTime.Parse(ngaySinh);

            NhanVien nhanVien = new NhanVien(hoTen, gioiTinh, dateTime, soDienThoai, email, diaChi, maNhanVien, tenTaiKhoan);

            if (nhanVienDAO.SuaNhanVien(nhanVien))
                return "Sửa thông tin nhân viên thành công!";
            else
                return "Sửa thông tin nhân viên thất bại!";
        }

        public List<NhanVien> TimKiemNhanVien(string keyword, string phanQuyen = "Mặc định", string gioiTinh = "Mặc định") 
        {
            keyword = keyword.Trim().ToLower();

            return nhanVienDAO.TimKiemNhanVien(keyword, phanQuyen, gioiTinh);
        }
    }
}
