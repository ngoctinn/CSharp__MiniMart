using C__Final_Project_MiniMart.BUS;
using C__Final_Project_MiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    internal static class TestTaiKhoan
    {
        private static TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        private static void Main()
        {
            //TestDangNhap();
            //TestThemTaiKhoan();
            //TestDoiMatKhau();
            //TestKhoaTaiKhoan();
            TestTimBangTen();
        } 

        //Test đăng nhập
        private static void TestDangNhap()
        {
            Console.Write("Nhap ten tai khoan: ");
            string tenTaiKhoan = Console.ReadLine();
            Console.Write("Nhap mat khau: ");
            string matKhau = Console.ReadLine();
            Console.WriteLine(taiKhoanBUS.KiemTraDangNhap(tenTaiKhoan, matKhau));
        }

        //Test thêm tài khoản 
        private static void TestThemTaiKhoan()
        {
            Console.Write("Nhap ten tai khoan: ");
            string tenTaiKhoan = Console.ReadLine();
            Console.Write("Nhap mat khau: ");
            string matKhau = Console.ReadLine();
            string maPhanQuyen = "PQ03"; //Trong GUI sẽ có combobox hiện phân quyền để chọn nên mã phân quyền lẽ luôn luôn đúng 
            Console.WriteLine(taiKhoanBUS.ThemTaiKhoan(maPhanQuyen, tenTaiKhoan, matKhau));
        }

        //Test đổi mật khẩu
        private static void TestDoiMatKhau()
        {
            Console.Write("Nhap ten tai khoan: ");  //Trong GUI là tự đổi mật khẩu của bản thân nên tên tài khoản luôn luôn đúng
            string tenTaiKhoan = Console.ReadLine();
            Console.Write("Nhap mat khau cu: ");
            string matKhauCu = Console.ReadLine();
            Console.Write("Nhap mat khau moi: ");
            string matKhauMoi = Console.ReadLine();
            Console.Write("Xac nhan mat khau moi: ");
            string xacNhanMatKhauMoi = Console.ReadLine();
            Console.WriteLine(taiKhoanBUS.DoiMatKhau(tenTaiKhoan, matKhauCu, matKhauMoi, xacNhanMatKhauMoi));
        }

        //Test khóa tài khoản
        private static void TestKhoaTaiKhoan()
        {
            Console.Write("Nhap ten tai khoan: ");  //Trong GUI là admin chọn tài khoản từ bảng danh sách nên tên tài khoản luôn luôn đúng
            string tenTaiKhoan = Console.ReadLine();
            Console.WriteLine(taiKhoanBUS.KhoaTaiKhoan(tenTaiKhoan));
            //Kiểm tra còn đăng nhập được nữa không
            TestDangNhap();
        }

        //Test tìm kiếm bằng tên tài khoản
        private static void TestTimBangTen()
        {
            Console.Write("Nhap ten tai khoan muon tim: ");
            string tenTaiKhoan = Console.ReadLine();
            List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan = taiKhoanBUS.TimTaiKhoanBangTenTaiKhoan(tenTaiKhoan);
            foreach(TaiKhoan taiKhoan in  listTaiKhoan)
            {
                Console.WriteLine("Ma phan quyen: " + taiKhoan.maPhanQuyen);
                Console.WriteLine("Ten tai khoan: " + taiKhoan.tenTaiKhoan);
                Console.WriteLine("Mat khau: " + taiKhoan.matKhau);
                Console.WriteLine("Trang thai: " + taiKhoan.trangThai);
                Console.WriteLine();
            }
        }
    }
}
