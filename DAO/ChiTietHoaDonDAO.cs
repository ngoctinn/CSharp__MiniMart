using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class ChiTietHoaDonDAO
    {
        public ChiTietHoaDonDAO() { }

        public List<ChiTietHoaDon> GetListChiTietHoaDon(string maHoaDon, string maSanPham)
        {
            List<ChiTietHoaDon> listChiTietHoaDon = new List<ChiTietHoaDon>();

            string query = $"SELECT * FROM ChiTietHoaDon WHERE maHoaDon = '{maHoaDon}' AND maSanPham = '{maSanPham}';";


            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.maHoaDon = row["maHoaDon"].ToString();
                chiTietHoaDon.maSanPham = row["maSanPham"].ToString();
                chiTietHoaDon.maKhuyenMai = row["maKhuyenMai"].ToString();
                chiTietHoaDon.soLuong = (int)row["maSanPham"];
                chiTietHoaDon.donGia = (decimal)row["donGia"];
                chiTietHoaDon.thanhTien = (decimal)row["thanhTien"];

                listChiTietHoaDon.Add(chiTietHoaDon);
            }

            return listChiTietHoaDon;
        }
    }
}
