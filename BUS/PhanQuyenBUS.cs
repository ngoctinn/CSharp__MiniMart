using C__Final_Project_MiniMart.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.BUS
{
    public class PhanQuyenBUS
    {
        PhanQuyenDAO phanQuyenDAO;

        public PhanQuyenBUS()
        {
            phanQuyenDAO = new PhanQuyenDAO();
        }

        public List<PhanQuyen> LayDanhSachPhanQuyen()
        {
            List<PhanQuyen> listPhanQuyen = phanQuyenDAO.LayDanhSachPhanQuyen();
            return listPhanQuyen;
        }

        //Lấy phân quyền của tài khoản 
        public PhanQuyen LayPhanQuyenTheoTenTaiKhoan(string tenTaiKhoan)
        {              
            return phanQuyenDAO.LayPhanQuyenTheoTenTaiKhoan(tenTaiKhoan);
        }

        //Lấy phân quyền biết mã phân quyền
        public PhanQuyen LayPhanQuyenTheoMa(string maPhanQuyen)
        {
            return phanQuyenDAO.LayPhanQuyenTheoMa(maPhanQuyen);
        }
    }
}
