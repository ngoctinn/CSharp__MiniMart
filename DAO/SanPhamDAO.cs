using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class SanPhamDAO
    {
        public SanPhamDAO() { }

        public List<SanPham> GetAllSanPham()
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
    }
}
