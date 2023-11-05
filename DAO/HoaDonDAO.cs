using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class HoaDonDAO
    {
        public HoaDonDAO() { }

        public List<HoaDon> GetAllHoaDon()
        {
            List<HoaDon> listHoaDon = new List<HoaDon>();

            string query = "SELECT * FROM HoaDon;";


            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.maHoaDon = row["maHoaDon"].ToString();
                hoaDon.maNhanVien = row["maNhanVien"].ToString();
                hoaDon.maKhachHang = row["maKhachHang"].ToString();
                hoaDon.maKhuyenMai = row["maKhuyenMai"].ToString();
                hoaDon.thoiGianTao = (DateTime)row["thoiGianTao"];
                hoaDon.tongTien = (decimal)row["tongTien"];
                hoaDon.giaTriKhuyenMai = (decimal)row["giaTriKhuyenMai"];
                hoaDon.thanhTien = (decimal)row["thanhTien"];
                hoaDon.tienNhan = (decimal)row["tienNhan"];
                hoaDon.tienThua = (decimal)row["tienThua"];
                listHoaDon.Add(hoaDon);
            }

            return listHoaDon;
        }
    }
}
