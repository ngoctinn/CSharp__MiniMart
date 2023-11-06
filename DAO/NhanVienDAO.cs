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

        public List<NhanVien> LayDanhSachNhanVien()
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

        public int DemSoNhanVien(string tenPhanQuyen)
        {
            string query = "SELECT COUNT(*) AS SoNhanVien " +
                           "FROM NhanVien AS NV " +
                           "JOIN TaiKhoan AS TK ON NV.TenTaiKhoan = TK.TenTaiKhoan " +
                           "JOIN PhanQuyen AS PQ ON TK.MaPhanQuyen = PQ.MaPhanQuyen " +
                           $"WHERE PQ.TenPhanQuyen = '{tenPhanQuyen}';";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoNhanVien"];

            return count;
        }

        public bool ThemNhanVien(NhanVien nhanVien)
        {
            string query = $"INSERT INTO NhanVien VALUES('{nhanVien.maNhanVien}', '{nhanVien.tenTaiKhoan}', '{nhanVien.hoTen}', '{nhanVien.gioiTinh}', '{nhanVien.ngaySinh}', '{nhanVien.soDienThoai}', '{nhanVien.email}', '{nhanVien.diaChi}', 1);";

            int rowsAffected = DbHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool XoaNhanVien(string maNhanVien)
        {
            string query = $"UPDATE NhanVien SET trangThai = 0 WHERE maNhanVien = '{maNhanVien}';";

            int rowsAffected = DbHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool SuaNhanVien(NhanVien nhanVien)
        {
            string query = $"UPDATE NhanVien SET tenNhanVien = '{nhanVien.hoTen}', gioiTinh = '{nhanVien.gioiTinh}', ngaySinh = '{nhanVien.ngaySinh}', soDienThoai = '{nhanVien.soDienThoai}', email = '{nhanVien.email}', diaChi = '{nhanVien.diaChi}' WHERE maNhanVien = '{nhanVien.maNhanVien}';";

            int rowsAffected = DbHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<NhanVien> LocNhanVienTheoPhanQuyen(string maPhanQuyen)
        {
            List<NhanVien> listNhanVien = new List<NhanVien>();

            string query = "SELECT NV.* FROM NhanVien AS NV " +
                           "JOIN TaiKhoan AS TK ON NV.tenTaiKhoan = TK.tenTaiKhoan " +
                           "JOIN PhanQuyen AS PQ ON TK.maPhanQuyen = PQ.maPhanQuyen " +
                           $"WHERE PQ.maPhanQuyen = '{maPhanQuyen}' and NV.trangThai = 1;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                NhanVien nhanVien = new NhanVien();

                nhanVien.maNhanVien = row["maNhanVien"].ToString();
                nhanVien.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                nhanVien.hoTen = row["hoTen"].ToString();
                nhanVien.gioiTinh = row["gioiTinh"].ToString();
                nhanVien.ngaySinh = (DateTime)row["ngaySinh"];
                nhanVien.soDienThoai = row["soDienThoai"].ToString();
                nhanVien.email = row["email"].ToString();
                nhanVien.diaChi = row["diaChi"].ToString();

                listNhanVien.Add(nhanVien);
            }

            return listNhanVien;
        }

        public List<NhanVien> LocNhanVienTheoGioiTinh(string gioiTinh)
        {
            List<NhanVien> listNhanVien = new List<NhanVien>();

            string query = $"SELECT * FROM NhanVien WHERE gioiTinh = '{gioiTinh}';";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                NhanVien nhanVien = new NhanVien();

                nhanVien.maNhanVien = row["maNhanVien"].ToString();
                nhanVien.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                nhanVien.hoTen = row["hoTen"].ToString();
                nhanVien.gioiTinh = row["gioiTinh"].ToString();
                nhanVien.ngaySinh = (DateTime)row["ngaySinh"];
                nhanVien.soDienThoai = row["soDienThoai"].ToString();
                nhanVien.email = row["email"].ToString();
                nhanVien.diaChi = row["diaChi"].ToString();

                listNhanVien.Add(nhanVien);
            }

            return listNhanVien;
        }

        public List<NhanVien> TimKiemNhanVien(string keyword)
        {
            List<NhanVien> listNhanVien = new List<NhanVien>();

            string query = $"SELECT * FROM NhanVien WHERE LOWER(tenNhanVien) LIKE '%{keyword}%' " +
                           $"OR soDienThoai LIKE '%{keyword}%' " +
                           $"OR LOWER(email) LIKE '%{keyword}%' " +
                           $"OR LOWER(diaChi) LIKE '%{keyword}%' " +
                           $"AND trangThai = 1;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                NhanVien nhanVien = new NhanVien();

                nhanVien.maNhanVien = row["maNhanVien"].ToString();
                nhanVien.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                nhanVien.hoTen = row["hoTen"].ToString();
                nhanVien.gioiTinh = row["gioiTinh"].ToString();
                nhanVien.ngaySinh = (DateTime)row["ngaySinh"];
                nhanVien.soDienThoai = row["soDienThoai"].ToString();
                nhanVien.email = row["email"].ToString();
                nhanVien.diaChi = row["diaChi"].ToString();

                listNhanVien.Add(nhanVien);
            }

            return listNhanVien;
        }
    }
}
