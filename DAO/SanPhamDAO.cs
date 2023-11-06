using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class SanPhamDAO
    {
        public SanPhamDAO() { }

        public List<SanPham> LayDanhSachSanPham()
        {
            List<SanPham> listSanPham = new List<SanPham>();

            string query = "SELECT * FROM SanPham WHERE trangThai = 1;";


            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                SanPham sanPham = new SanPham();
                sanPham.maSanPham = row["maSanPham"].ToString();
                sanPham.maLoaiSanPham = row["maLoaiSanPham"].ToString();
                sanPham.maNhaCungCap = row["maNhaCungCap"].ToString();
                sanPham.tenSanPham = row["tenSanPham"].ToString();
                sanPham.donViTinh = row["donViTinh"].ToString();
                sanPham.soLuong = (int)row["soLuong"];
                sanPham.giaBan = (decimal)row["giaBan"];
                sanPham.duongDanAnh = row["duongDanAnh"].ToString();
                sanPham.trangThai = (bool)row["trangThai"];

                listSanPham.Add(sanPham);
            }

            return listSanPham;
        }

        public int DemSoSanPham()
        {
            string query = "SELECT COUNT(*) AS SoSanPham FROM SanPham;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoSanPham"];

            return count;
        }

        public bool ThemSanPham(SanPham sanPham)
        {
            string query = $"INSERT INTO SanPham VALUES('{sanPham.maSanPham}', '{sanPham.maLoaiSanPham}', '{sanPham.maNhaCungCap}', '{sanPham.tenSanPham}', '{sanPham.donViTinh}', '{sanPham.soLuong}', '{sanPham.giaBan}', '{sanPham.duongDanAnh}', 1);";

            int rowsAffected = DbHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool XoaSanPham(string maSanPham)
        {
            string query = $"UPDATE SanPham SET trangThai = 0, soLuong = 0 WHERE maSanPham = '{maSanPham}';";

            int rowsAffected = DbHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool SuaSanPham(SanPham sanPham)
        {
            string query = $"UPDATE SanPham SET tenSanPham = '{sanPham.tenSanPham}', maLoaiSanPham = '{sanPham.maLoaiSanPham}', maNhaCungCap = '{sanPham.maNhaCungCap}', donViTinh = '{sanPham.donViTinh}', giaBan = {sanPham.giaBan}, duongDanAnh = '{sanPham.duongDanAnh}' " +
                           $"WHERE maSanPham = '{sanPham.maSanPham}';";

            int rowsAffected = DbHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<SanPham> TimKiemSanPham(string keyword, string maLoaiSanPham, string maNhaCungCap)
        {
            List<SanPham> listSanPham = new List<SanPham> ();

            string query = $"SELECT SP.* " +
                           $"FROM SanPham SP " +
                           $"JOIN TaiKhoan TK ON NV.tenTaiKhoan = TK.tenTaiKhoan " +
                           $"JOIN PhanQuyen PQ ON TK.maPhanQuyen = PQ.maPhanQuyen " +
                           $"WHERE (LOWER(SP.tenSanPham) LIKE '%{keyword}%' " +
                           $"AND SP.trangThai = 1";

            if (!maLoaiSanPham.Equals("Mặc định") && !string.IsNullOrEmpty(maLoaiSanPham))
                query += $" AND SP.maLoaiSanPham = '{maLoaiSanPham}'";

            if (!maNhaCungCap.Equals("Mặc định") && !string.IsNullOrEmpty(maNhaCungCap))
                query += $" AND SP.maNhaCungCap = '{maNhaCungCap}'";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                SanPham sanPham = new SanPham();
                sanPham.maSanPham = row["maSanPham"].ToString();
                sanPham.maLoaiSanPham = row["maLoaiSanPham"].ToString();
                sanPham.maNhaCungCap = row["maNhaCungCap"].ToString();
                sanPham.tenSanPham = row["tenSanPham"].ToString();
                sanPham.donViTinh = row["donViTinh"].ToString();
                sanPham.soLuong = (int)row["soLuong"];
                sanPham.giaBan = (decimal)row["giaBan"];
                sanPham.duongDanAnh = row["duongDanAnh"].ToString();
                sanPham.trangThai = (bool)row["trangThai"];

                listSanPham.Add(sanPham);
            }

            return listSanPham;
        }
    }
}
