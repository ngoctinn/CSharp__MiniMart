using C__Final_Project_MiniMart.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO taiKhoanDAO;

        public TaiKhoanBUS()
        {
            taiKhoanDAO = new TaiKhoanDAO();
        }

        public List<TaiKhoan> LayDanhSachTaiKhoan()
        {
            List<TaiKhoan> listTaiKhoan = taiKhoanDAO.LayDanhSachTaiKhoan();
            return listTaiKhoan;
        }

        //Tìm kiếm tài khoản bằng tên tài khoản
        public List<TaiKhoan> TimTaiKhoanBangTenTaiKhoan(string tenTaiKhoan)
        {
            tenTaiKhoan = tenTaiKhoan.Trim().ToLower();
            List<TaiKhoan> listTaiKhoan = taiKhoanDAO.TimTaiKhoanBangTenTaiKhoan(tenTaiKhoan);
            return listTaiKhoan;
        }

        //Tìm kiếm tài khoản bằng mã phân quyền
        public List<TaiKhoan> TimTaiKhoanBangMaPhanQuyen (string maPhanQuyen) 
        {
            List<TaiKhoan> listTaiKhoan = taiKhoanDAO.TimTaiKhoanBangMaPhanQuyen(maPhanQuyen); 
            return listTaiKhoan;
        }

        //Kiểm tra đăng nhập
        public string KiemTraDangNhap(string tenTaiKhoan, string matKhau)
        {
            if (string.IsNullOrEmpty(tenTaiKhoan) || string.IsNullOrEmpty(matKhau)) 
                return "Vui lòng nhập đầy đủ thông tin!";
            else
            {
                if (taiKhoanDAO.KiemTraDangNhap(tenTaiKhoan, matKhau))
                    return "Đăng nhập thành công!";
                else
                    return "Thông tin đăng nhập không chính xác!";
            }
        }

        //Thêm tài khoản mới 
        public string ThemTaiKhoan(string maPhanQuyen, string tenTaiKhoan, string matKhau)
        {
            if (string.IsNullOrEmpty(tenTaiKhoan) || string.IsNullOrEmpty(matKhau))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (taiKhoanDAO.KiemTraTaiKhoanDaTonTai(tenTaiKhoan))
                return "Tên tài khoản đã tồn tại, vui lòng chọn tên khác!";
            else 
            {
                TaiKhoan taiKhoan = new TaiKhoan(maPhanQuyen, tenTaiKhoan, matKhau);

                if (taiKhoanDAO.ThemTaiKhoan(taiKhoan))
                    return "Thêm tài khoản thành công!";
                else
                    return "Thêm tài khoản thất bại!";
            }
        }

        //Đổi mật khẩu
        public string DoiMatKhau(string tenTaiKhoan, string matKhauCu, string matKhauMoi, string xacNhanMatKhauMoi)
        {
            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (!taiKhoanDAO.KiemTraDangNhap(tenTaiKhoan, matKhauCu))
                return "Mật khẩu sai!";

            if (!matKhauMoi.Equals(xacNhanMatKhauMoi))
                return "Xác nhận mật khẩu mới không chính xác!";

            if (matKhauCu.Equals(matKhauMoi))
                return "Mật khẩu mới giống với mật khẩu cũ!";

            if (taiKhoanDAO.DoiMatKhau(tenTaiKhoan, matKhauMoi))
                return "Đổi mật khẩu thành công!";
            else
                return "Đổi mật khẩu thất bại!";
        }

        //Khóa tài khoản
        public string KhoaTaiKhoan(string tenTaiKhoan)
        {
            if (taiKhoanDAO.KhoaTaiKhoan(tenTaiKhoan) == true)
                return "Khóa tài khoản thành công!";

            return "Khóa tài khoản thất bại!";
        }
    }
}
