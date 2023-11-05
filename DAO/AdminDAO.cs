using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class AdminDAO
    {
        public AdminDAO() { }

        public List<Admin> GetAllAdmin()
        {
            List<Admin> listAdmin = new List<Admin>();

            string query = "SELECT * FROM Admin WHERE trangThai = 1;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                Admin admin = new Admin();
                admin.maAdmin = row["maAdmin"].ToString();
                admin.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                admin.hoTen = row["tenAdmin"].ToString();
                admin.gioiTinh = row["gioiTinh"].ToString();
                admin.ngaySinh = (DateTime)row["ngaySinh"];
                admin.soDienThoai = row["soDienThoai"].ToString();
                admin.email = row["email"].ToString();
                admin.diaChi = row["diaChi"].ToString();
                admin.trangThai = (bool)row["trangThai"];

                listAdmin.Add(admin);
            }

            return listAdmin;
        }
    }
}
