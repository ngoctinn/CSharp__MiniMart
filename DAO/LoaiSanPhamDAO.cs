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

        public LoaiSanPham LayLoaiSanPhamTheoTen(string tenLoaiSanPham)
        {
            LoaiSanPham loaiSanPham = new LoaiSanPham();

            string query = $"SELECT * FROM LoaiSanPham WHERE trangThai = 1 AND tenLoaiSanPham = '{tenLoaiSanPham}';";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            loaiSanPham.maLoaiSanPham = dataTable.Rows[0]["maLoaiSanPham"].ToString();
            loaiSanPham.tenLoaiSanPham = dataTable.Rows[0]["tenLoaiSanPham"].ToString();

            return loaiSanPham;
        }

        public int DemSoLoaiSanPham()
        {
            string query = "SELECT COUNT(*) AS SoLoaiSanPham FROM LoaiSanPham;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoLoaiSanPham"];

            return count;
        }
    }
}
