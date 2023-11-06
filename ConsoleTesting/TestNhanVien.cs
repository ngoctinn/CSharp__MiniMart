using C__Final_Project_MiniMart.BUS;
using OtherFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    internal class TestNhanVien
    {
        static NhanVienBUS nhanVienBUS = new NhanVienBUS();

        static void Main(string[] args)
        {
            //TestThemNhanVien();
            TestXoaNhanVien();
        }

        static void TestThemNhanVien()
        {
            string maNhanVien = IDGenerator.GenerateNhanVienID("Nhân viên bán hàng");
            Console.Write("Nhap ten tai khoan: ");
            string tenTaiKhoan = Console.ReadLine();
            Console.Write("Nhap ten nhan vien: ");
            string tenNhanVien = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            string gioiTinh = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            string ngaySinh = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            string soDienThoai = Console.ReadLine();
            Console.Write("Nhap email: ");
            string email = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            string diaChi = Console.ReadLine();

            Console.WriteLine(nhanVienBUS.ThemNhanVien(maNhanVien, tenTaiKhoan, tenNhanVien, gioiTinh, ngaySinh, soDienThoai, email, diaChi));
        }

        static void TestXoaNhanVien()
        {
            Console.WriteLine("Nhap ma nhan vien: ");
            string maNhanVien = Console.ReadLine();
            Console.WriteLine(nhanVienBUS.XoaNhanVien(maNhanVien));
        }
    }
}
