using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class NhanVienDAO
    {
        public NhanVienDAO() { }

        public List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> listNhanVien = new List<NhanVien>();

            string query = "SELECT * FROM NhanVien WHERE trangThai = 1;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.maNhanVien = row["maNhanVien"].ToString();
                nhanVien.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                nhanVien.hoTen = row["tenNhanVien"].ToString();
                nhanVien.gioiTinh = row["gioiTinh"].ToString();
                nhanVien.ngaySinh = (DateTime)row["ngaySinh"];
                nhanVien.soDienThoai = row["soDienThoai"].ToString();
                nhanVien.email = row["email"].ToString();
                nhanVien.diaChi = row["diaChi"].ToString();
                nhanVien.trangThai = (bool)row["trangThai"];

                listNhanVien.Add(nhanVien);
            }

            return listNhanVien;
        }
    }
}
