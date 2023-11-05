using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class QuanLiDAO
    {
        public QuanLiDAO() { }

        public List<QuanLi> GetAllQuanLi()
        {
            List<QuanLi> listQuanLi = new List<QuanLi>();

            string query = "SELECT * FROM QuanLi WHERE trangThai = 1;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                QuanLi quanLi = new QuanLi();
                quanLi.maQuanLi = row["maQuanLi"].ToString();
                quanLi.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                quanLi.hoTen = row["tenQuanLi"].ToString();
                quanLi.gioiTinh = row["gioiTinh"].ToString();
                quanLi.ngaySinh = (DateTime)row["ngaySinh"];
                quanLi.soDienThoai = row["soDienThoai"].ToString();
                quanLi.email = row["email"].ToString();
                quanLi.diaChi = row["diaChi"].ToString();
                quanLi.trangThai = (bool)row["trangThai"];

                listQuanLi.Add(quanLi);
            }

            return listQuanLi;
        }
    }
}
