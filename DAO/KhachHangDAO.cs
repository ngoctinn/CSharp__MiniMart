using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class KhachHangDAO
    {
        public KhachHangDAO() { }

        public List<KhachHang> GetAllKhachHang()
        {
            List<KhachHang> listKhachHang = new List<KhachHang>();

            string query = "SELECT * FROM KhachHang;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                KhachHang khachHang = new KhachHang();
                khachHang.maKhachHang = row["maKhachHang"].ToString();
                khachHang.hoTen = row["tenKhachHang"].ToString();
                khachHang.gioiTinh = row["gioiTinh"].ToString();
                khachHang.ngaySinh = (DateTime)row["ngaySinh"];
                khachHang.soDienThoai = row["soDienThoai"].ToString();
                khachHang.email = row["email"].ToString();
                khachHang.diaChi = row["diaChi"].ToString();
                khachHang.bacThanhVien = row["bacThanhVien"].ToString();
                khachHang.diemThanhVien = (int)row["diemThanhVien"];
                khachHang.diemTichLuy = (int)row["diemTichLuy"];

                listKhachHang.Add(khachHang);
            }

            return listKhachHang;
        }
    }
}
