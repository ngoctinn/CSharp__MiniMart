using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class PhanQuyenDAO
    {
        public PhanQuyenDAO() { }

        public List<PhanQuyen> LayDanhSachPhanQuyen ()
        {
            List<PhanQuyen> listPhanQuyen = new List<PhanQuyen>();

            string query = "SELECT * FROM PhanQuyen;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);
            
            foreach (DataRow row in dataTable.Rows)
            {
                PhanQuyen phanQuyen = new PhanQuyen();
                phanQuyen.maPhanQuyen = row["maPhanQuyen"].ToString();
                phanQuyen.tenPhanQuyen = row["tenPhanQuyen"].ToString();
                
                listPhanQuyen.Add(phanQuyen);
            }

            return listPhanQuyen;
        }

        //Lấy phân quyền của tài khoản đã biết tên
        public PhanQuyen LayPhanQuyenTheoTenTaiKhoan(string tenTaiKhoan)
        {
            PhanQuyen phanQuyen = new PhanQuyen();

            string query = $"SELECT PhanQuyen.* " +
                           "FROM PhanQuyen " +
                           "INNER JOIN TaiKhoan ON PhanQuyen.maPhanQuyen = TaiKhoan.maPhanQuyen " +
                           "WHERE TaiKhoan.tenTaiKhoan = '{tenTaiKhoan}';";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            phanQuyen.maPhanQuyen = dataTable.Rows[0]["maPhanQuyen"].ToString();
            phanQuyen.tenPhanQuyen = dataTable.Rows[0]["tenPhanQuyen"].ToString();

            return phanQuyen;
        }

        //Lấy phân quyền biết mã phân quyền
        public PhanQuyen LayPhanQuyenTheoMa(string maPhanQuyen)
        {
            PhanQuyen phanQuyen = new PhanQuyen();

            string query = $"SELECT * FROM PhanQuyen WHERE maPhanQuyen = '{maPhanQuyen}';";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            phanQuyen.maPhanQuyen = dataTable.Rows[0]["maPhanQuyen"].ToString();
            phanQuyen.tenPhanQuyen = dataTable.Rows[0]["tenPhanQuyen"].ToString();

            return phanQuyen;
        }
    }
}
