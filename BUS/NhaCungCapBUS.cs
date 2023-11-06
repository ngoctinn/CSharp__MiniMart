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
    public class NhaCungCapBUS
    {
        private NhaCungCapDAO nhaCungCapDAO;

        public NhaCungCapBUS()
        {
            nhaCungCapDAO = new NhaCungCapDAO();
        }

        public int DemSoNhaCungCap()
        {
            return nhaCungCapDAO.DemSoNhaCungCap();
        }

        public string ThemNhaCungCap(string maNhaCungCap, string tenNhaCungCap, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(tenNhaCungCap) )
                return "Vui lòng nhập đầy đủ thông tin!";

            tenNhaCungCap = tenNhaCungCap.Trim();
            soDienThoai = soDienThoai.Trim();
            email = email.Trim();
            diaChi = diaChi.Trim(); 

            if (!string.IsNullOrEmpty (soDienThoai)) 
            { 
                if(InputValidate.PhoneNumberValidate(soDienThoai))
                    return "Vui lòng nhập đúng số điện thoại!";
            }

            if (!string.IsNullOrEmpty(email))
            {
                if (InputValidate.EmailValidate(email))
                    return "Vui lòng nhập đúng email!";
            }

            if (nhaCungCapDAO.KiemTraDaTonTai(tenNhaCungCap.ToLower()))
                return "Nhà cung cấp đã tồn tại, vui lòng chọn tên khác!";
            else
            {
                NhaCungCap NhaCungCap = new NhaCungCap(maNhaCungCap, tenNhaCungCap, soDienThoai, email, diaChi);

                if (nhaCungCapDAO.ThemNhaCungCap(NhaCungCap))
                    return "Thêm nhà cung cấp thành công!";
                else
                    return "Thêm nhà cung cấp thất bại!";
            }
        }

        public string SuaNhaCungCap(string maNhaCungCap, string tenNhaCungCap, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(tenNhaCungCap))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            NhaCungCap NhaCungCap = new NhaCungCap(maNhaCungCap, tenNhaCungCap, soDienThoai, email, diaChi);

            if (nhaCungCapDAO.SuaNhaCungCap(NhaCungCap))
                return "Sửa loại sản phẩm thành công!";
            else
                return "Sửa loại sản phẩm thất bại!";
        }

        public List<NhaCungCap> TimKiemNhaCungCap(string keyword)
        {
            keyword = keyword.Trim().ToLower();
            return nhaCungCapDAO.TimKiemNhaCungCap(keyword);
        }
    }
}
