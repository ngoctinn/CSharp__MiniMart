using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class LoaiSanPhamDAO
    {
        public LoaiSanPhamDAO() { }

        public List<LoaiSanPham> LayDanhSachLoaiSanPham()
        {
            List<LoaiSanPham> listLoaiSanPham = new List<LoaiSanPham>();

            string query = "SELECT * FROM LoaiSanPham WHERE trangThai = 1;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                LoaiSanPham loaiSanPham = new LoaiSanPham();
                loaiSanPham.maLoaiSanPham = row["maLoaiSanPham"].ToString();
                loaiSanPham.tenLoaiSanPham = row["tenLoaiSanPham"].ToString();
                
                listLoaiSanPham.Add(loaiSanPham);
            }

            return listLoaiSanPham;
        }

        public LoaiSanPham LayLoaiSanPhamTheoTenLoaiSanPham()
        {
            LoaiSanPham loaiSanPham = new LoaiSanPham();

            string query = "SELECT * FROM LoaiSanPham WHERE trangThai = 1;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            return loaiSanPham;
        }
    }
}
