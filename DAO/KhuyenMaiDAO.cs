using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class KhuyenMaiDAO
    {
        public KhuyenMaiDAO() { }

        public List<KhuyenMai> GetAllKhuyenMai()
        {
            List<KhuyenMai> listKhuyenMai = new List<KhuyenMai>();

            string query = "SELECT * FROM KhuyenMai WHERE trangThai = 1 AND thoiGianKetThuc < GETDATE();";


            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                KhuyenMai khuyenMai = new KhuyenMai();
                khuyenMai.maQuanLi = row["maQuanLi"].ToString();
                khuyenMai.tenKhuyenMai = row["tenKhuyenMai"].ToString();
                khuyenMai.thoiGianBatDau = (DateTime)row["thoiGianBatDau"];
                khuyenMai.thoiGianKetThuc = (DateTime)row["thoiGianKetThuc"];
                khuyenMai.doiTuongApDung = row["doiTuongApDung"].ToString();
                khuyenMai.loaiGiaTri = row["loaiGiaTri"].ToString();
                khuyenMai.giaTriApDung = (decimal)row["giaTriApDung"];
                khuyenMai.trangThai = (bool)row["trangThai"];

                listKhuyenMai.Add(khuyenMai);
            }

            return listKhuyenMai;
        }
    }
}
