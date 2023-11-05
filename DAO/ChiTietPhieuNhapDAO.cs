using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class ChiTietPhieuNhapDAO
    {
        public ChiTietPhieuNhapDAO() { }

        public List<ChiTietPhieuNhap> GetListChiTietPhieuNhap(string maPhieuNhap, string maSanPham)
        {
            List<ChiTietPhieuNhap> listChiTietPhieuNhap = new List<ChiTietPhieuNhap>();

            string query = $"SELECT * FROM ChiTietPhieuNhap WHERE maPhieuNhap = '{maPhieuNhap}' AND maSanPham = '{maSanPham}';";


            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                ChiTietPhieuNhap ChiTietPhieuNhap = new ChiTietPhieuNhap();
                ChiTietPhieuNhap.maPhieuNhap = row["maPhieuNhap"].ToString();
                ChiTietPhieuNhap.maSanPham = row["maSanPham"].ToString();
                ChiTietPhieuNhap.soLuong = (int)row["soLuong"];
                ChiTietPhieuNhap.donGia = (decimal)row["donGia"];
                ChiTietPhieuNhap.thanhTien = (decimal)row["thanhTien"];

                listChiTietPhieuNhap.Add(ChiTietPhieuNhap);
            }

            return listChiTietPhieuNhap;
        }
    }
}
